﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Bitfish
{
    /// <summary>
    /// TODO:
    /// Logging
    /// </summary>
    public class Bot
    {
        public struct Stats 
        {
            public static int afkTime = 290;
            public int
                seconds,
                startTime,
                fishCaught,
                nextAfkTime;
        }

        private readonly BackgroundWorker worker;
        private readonly BackgroundWorker clock;
        private readonly MemoryReader mem;
        private readonly Random random;
        private readonly BotFunctions func;
        private Config config;
        private Stats session;

        // blacklist these guids, clicked bobbers stay in memory for a small time
        // the que will hold last 5 bobbers
        private readonly Queue<ulong> prevBobbers;

        // Tracks wheter the bot as failed to fish {maxFails} number times in a row
        private bool failed;
        private readonly int maxFails;

        public Bot(MemoryReader mem)
        {
            this.mem = mem;
            worker = new BackgroundWorker();
            clock = new BackgroundWorker();
            random = new Random();
            prevBobbers = new Queue<ulong>();
            session = new Stats();
            func = new BotFunctions(mem);

            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += new DoWorkEventHandler(DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Finished);
            worker.ProgressChanged += new ProgressChangedEventHandler(FishCaught);

            clock.WorkerReportsProgress = true;
            clock.WorkerSupportsCancellation = true;
            clock.DoWork += new DoWorkEventHandler(ClockWork);
            clock.ProgressChanged += new ProgressChangedEventHandler(ClockTick);

            failed = false;
            maxFails = 3;
        }

        /// <summary>
        /// Starts the bot. Before we start the fishing routune we first load current 
        /// config from option GUI.
        /// </summary>
        internal void Start(out bool started)
        {
            started = false;

            // Check if we need to reinit the object manager due to logout
            if(!mem.StatusCheckObjectManager())
            {
                BitfishForm.instance.UpdateStatus(false, true);
                Console.WriteLine("Can't find object list. Please enter world.");
                started = false;
                return;
            }

            // load config with current option values
            config = BitfishForm.instance.ReadOptionValues();
            func.SetConfig(config);

            // Create a background worker and start fishing
            if (!worker.IsBusy)
            {
                func.EquipFishingPole();

                worker.RunWorkerAsync();
                clock.RunWorkerAsync();
                started = true;
            }
        }

        /// <summary>
        /// Stops the bot. When stopped it can be started again and the current session
        /// will keep on going as normal.
        /// </summary>
        internal void Stop()
        {
            Console.WriteLine("停止钓鱼 ...");
            worker.CancelAsync();
            clock.CancelAsync();
        }

        /// <summary>
        /// Make character start fish
        /// </summary>
        private void BeginFishing()
        {
            mem.LuaDoString("CastSpellByName('钓鱼')");
            Thread.Sleep(800);
        }

        /// <summary>
        /// Main bot routine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoWork(object sender, DoWorkEventArgs e)
        {
            // If routine generates too many fails we stop
            int fails = 0;

            session.nextAfkTime = Stats.afkTime + session.startTime;
            session.startTime = session.seconds;

            Point fishingPosition = mem.ReadPlayerPosition();

            bool inWintergrasp = func.IsPlayerInWG();
            int wgStartTime = 0;
            if(inWintergrasp)
            {
                wgStartTime = func.GetWGTimer() + session.startTime;
                Console.WriteLine($"[{session.seconds}] 冬拥湖开始时间: [{wgStartTime}]");
            }

            // wait a global for fish pole equip
            if (config.AutoEquip)
                Thread.Sleep(1000);

            while (fails < maxFails)
            {
                #region BreakEvents

                if (CancellationPending(worker, e))
                {
                    Console.WriteLine("A cancellation is pending.");
                    break;
                }

                if (func.IsPlayerDead())
                {
                    Console.WriteLine("Player is dead.");
                    break;
                }

                if(func.HasPlayerMoved(fishingPosition))
                {
                    Console.WriteLine("Player has moved.");
                    break;
                }

                if (func.HasTimerExpired(session))
                {
                    Console.WriteLine("Timer has expired.");
                    break;
                }    

                if (func.NearbyPlayers(40, 25, session))
                {
                    Console.WriteLine("Detected nearby players for too long");
                    break;
                }

                if(inWintergrasp && config.Wintergrasp)
                {
                    if(session.seconds > wgStartTime - 300)
                    {
                        Console.WriteLine("Wintergrasp is starting soon!");
                        break;
                    }
                }

                #endregion BreakEvents

                // Prevent <Away> tag
                if(func.IsPlayerAfk(ref session))
                {
                    KeyHandler.PressKey(0x53, 50); // press S key
                    KeyHandler.PressKey(0x57, 50); // press W key
                }

                // Start cast
                BeginFishing();

                // Search for bobber
                GameObject bobber = mem.FindBobber(prevBobbers);
                if (bobber == null)
                {
                    fails++;
                    Console.WriteLine("没有找到鱼漂!");
                    Thread.Sleep(2000);
                    continue;
                }

                bool fish = false;  // fish hooked?
                int timeout = 12;   // seconds until we stop
                int ticks = 0;

                // wait for fish to hook.
                // Stop if either timer has exceeded or a fish is on the hook.
                while(!fish && ticks < timeout)
                {
                    // check if we should cancel
                    if (CancellationPending(worker, e) || func.HasPlayerMoved(fishingPosition) || func.IsPlayerDead())
                        break;

                    Thread.Sleep(1000);
                    fish = mem.ReadBobberStatus(bobber);
                    ticks++;
                }
                
                // check if a fish was hooked
                if(fish)
                {
                    // click bobber after random amount of ms
                    Thread.Sleep(random.Next(600) + 500);
                    mem.LuaMouseoverInteract(bobber);
                    session.fishCaught++;
                    worker.ReportProgress(session.fishCaught);

                    // add guid to blacklist
                    prevBobbers.Enqueue(bobber.guid);
                    if (prevBobbers.Count > 5)
                        prevBobbers.Dequeue();

                    // check slots left
                    if(config.StopIfInventoryFull)
                    {
                        int slots = func.GetFreeInventorySlots();
                        if(slots == 0)
                        {
                            Console.WriteLine("背包满了, 停止工作");
                            break;
                        }
                    }
                } 
                else
                {
                    Console.WriteLine("Failed to click on bobber");
                    // add guid to blacklist
                    prevBobbers.Enqueue(bobber.guid);
                    if (prevBobbers.Count > 5)
                        prevBobbers.Dequeue();
                    fails++;
                }

                Thread.Sleep(random.Next(500) + 500);
            }

            if (fails == maxFails)
                failed = true;
        }

        /// <summary>
        /// Updates the fish caught label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FishCaught(object sender, ProgressChangedEventArgs e)
        {
            BitfishForm.instance.UpdateFishCaught(e.ProgressPercentage);
        }

        /// <summary>
        /// Update clock label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClockTick(object sender, ProgressChangedEventArgs e)
        {
            BitfishForm.instance.UpdateTimer(session.seconds);
        }

        /// <summary>
        /// Ticks the clock 1 sec
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClockWork(object sender, DoWorkEventArgs e)
        {
            while(true)
            {
                clock.ReportProgress(session.seconds);
                if (CancellationPending(clock, e))
                    break;
                Thread.Sleep(1000);
                session.seconds++;
            }
        }

        /// <summary>
        /// Routine when bot has finished fishing. In this state we can be either safe,
        /// in combat or dead. If we are in combat we should just wait and die, release spirit
        /// and check if logout.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Finished(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine("钓鱼已停止.");
            BitfishForm.instance.UpdateStatus(false);

            if (clock.IsBusy)
                clock.CancelAsync();

            if (failed)
                Console.WriteLine("尝试次数太多,停止工作!");

            bool dead = func.IsPlayerDead();

            if(dead)
                func.ReleaseAndLogout(random.Next(1000) + 500);
            else
            {
                // we are alive, but are we in combat?
                bool combat = func.IsPlayerInCombat();
                if(combat)
                {
                    // yea, let's wait till we die
                    // warning: this could potentially get stuck in a loop
                    Console.WriteLine("我们被攻击了! 等待死亡吧 ...");
                    while (!func.IsPlayerDead())
                        Thread.Sleep(1000);

                    Console.WriteLine("玩家已死亡.");
                    func.ReleaseAndLogout(random.Next(1300) + 500);
                }
            }

            if (config.HearthstoneWhenDone)
            {
                Console.WriteLine("使用炉石中");
                mem.LuaDoString("UseItemByName(\"炉石\")");
                if(config.LogoutWhenDone)
                {
                    // wait 20s for hearthstone and loading
                    Console.WriteLine("等待20秒以退出游戏 ...");
                    Thread.Sleep(20000);
                    mem.LuaDoString("Logout()");
                }
            }
            else if (config.LogoutWhenDone)
                mem.LuaDoString("Logout()");
        }

        /// <summary>
        /// Check if we have a cancel pending
        /// </summary>
        /// <param name="e"></param>
        /// <returns>true if worker is cancelled</returns>
        private bool CancellationPending(BackgroundWorker w, DoWorkEventArgs e)
        {
            // Check if we have a cancel pending
            if (w.CancellationPending)
            {
                e.Cancel = true;
                return true;
            }
            return false;
        }
    }
}
