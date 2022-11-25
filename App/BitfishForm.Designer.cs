
namespace Bitfish
{
    partial class BitfishForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BitfishForm));
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FishCaughtLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WintergraspCheckbox = new System.Windows.Forms.CheckBox();
            this.NearybyPlayerCheckbox = new System.Windows.Forms.CheckBox();
            this.FishingPoleSelector = new System.Windows.Forms.ComboBox();
            this.AutoEquipCheckbox = new System.Windows.Forms.CheckBox();
            this.InventoryFullCheckbox = new System.Windows.Forms.CheckBox();
            this.SaveOptions = new System.Windows.Forms.Button();
            this.TimerDuration = new System.Windows.Forms.NumericUpDown();
            this.LogoutWhenDeadCheckBox = new System.Windows.Forms.CheckBox();
            this.HearthstoneCheckBox = new System.Windows.Forms.CheckBox();
            this.LogoutWhenDoneCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EnableTimerCheckBox = new System.Windows.Forms.CheckBox();
            this.CurrentSessionBox = new System.Windows.Forms.GroupBox();
            this.OpenLogButton = new System.Windows.Forms.Button();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.ConfirmProcessButton = new System.Windows.Forms.Button();
            this.WowIDList = new System.Windows.Forms.ComboBox();
            this.ProcIdLabel = new System.Windows.Forms.Label();
            this.RetryButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimerDuration)).BeginInit();
            this.CurrentSessionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(114, 51);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(67, 15);
            this.StatusLabel.TabIndex = 0;
            this.StatusLabel.Text = "准备就绪";
            // 
            // StartButton
            // 
            this.StartButton.Enabled = false;
            this.StartButton.Location = new System.Drawing.Point(46, 187);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(159, 71);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "开始钓鱼";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(46, 266);
            this.StopButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(159, 72);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "停止";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "状态:";
            // 
            // FishCaughtLabel
            // 
            this.FishCaughtLabel.AutoSize = true;
            this.FishCaughtLabel.Location = new System.Drawing.Point(7, 44);
            this.FishCaughtLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FishCaughtLabel.Name = "FishCaughtLabel";
            this.FishCaughtLabel.Size = new System.Drawing.Size(60, 15);
            this.FishCaughtLabel.TabIndex = 4;
            this.FishCaughtLabel.Text = "上钩数:";
            this.FishCaughtLabel.Click += new System.EventHandler(this.FishCaughtLabel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WintergraspCheckbox);
            this.groupBox1.Controls.Add(this.NearybyPlayerCheckbox);
            this.groupBox1.Controls.Add(this.FishingPoleSelector);
            this.groupBox1.Controls.Add(this.AutoEquipCheckbox);
            this.groupBox1.Controls.Add(this.InventoryFullCheckbox);
            this.groupBox1.Controls.Add(this.SaveOptions);
            this.groupBox1.Controls.Add(this.TimerDuration);
            this.groupBox1.Controls.Add(this.LogoutWhenDeadCheckBox);
            this.groupBox1.Controls.Add(this.HearthstoneCheckBox);
            this.groupBox1.Controls.Add(this.LogoutWhenDoneCheckBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.EnableTimerCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(480, 163);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(263, 302);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选项";
            // 
            // WintergraspCheckbox
            // 
            this.WintergraspCheckbox.AutoSize = true;
            this.WintergraspCheckbox.Location = new System.Drawing.Point(12, 182);
            this.WintergraspCheckbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.WintergraspCheckbox.Name = "WintergraspCheckbox";
            this.WintergraspCheckbox.Size = new System.Drawing.Size(161, 19);
            this.WintergraspCheckbox.TabIndex = 20;
            this.WintergraspCheckbox.Text = "冬拥湖活动期间暂停";
            this.WintergraspCheckbox.UseVisualStyleBackColor = true;
            this.WintergraspCheckbox.CheckedChanged += new System.EventHandler(this.WintergraspCheckbox_CheckedChanged);
            // 
            // NearybyPlayerCheckbox
            // 
            this.NearybyPlayerCheckbox.AutoSize = true;
            this.NearybyPlayerCheckbox.Location = new System.Drawing.Point(12, 156);
            this.NearybyPlayerCheckbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NearybyPlayerCheckbox.Name = "NearybyPlayerCheckbox";
            this.NearybyPlayerCheckbox.Size = new System.Drawing.Size(191, 19);
            this.NearybyPlayerCheckbox.TabIndex = 19;
            this.NearybyPlayerCheckbox.Text = "附近有人长时间观察停止";
            this.NearybyPlayerCheckbox.UseVisualStyleBackColor = true;
            this.NearybyPlayerCheckbox.CheckedChanged += new System.EventHandler(this.NearybyPlayerCheckbox_CheckedChanged);
            // 
            // FishingPoleSelector
            // 
            this.FishingPoleSelector.FormattingEnabled = true;
            this.FishingPoleSelector.Items.AddRange(new object[] {
            "Mastercraft Kalu\'ak Fishing Pole",
            "Jeweled Fishing Pole",
            "Bone Fishing Pole",
            "Arcanite Fishing Pole",
            "Fishing Pole",
            "Strong Fishing Pole",
            "Big Iron Fishing Pole",
            "Nat Pagle\'s Extreme Angler FC-5000",
            "Nat\'s Lucky Fishing Pole",
            "Seth\'s Graphite Fishing Pole",
            "Blump Family Fishing Pole",
            "Darkwood Fishing Pole",
            "Crafty\'s Pole"});
            this.FishingPoleSelector.Location = new System.Drawing.Point(12, 235);
            this.FishingPoleSelector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FishingPoleSelector.Name = "FishingPoleSelector";
            this.FishingPoleSelector.Size = new System.Drawing.Size(239, 23);
            this.FishingPoleSelector.TabIndex = 18;
            this.FishingPoleSelector.SelectedIndexChanged += new System.EventHandler(this.FishingPoleSelector_SelectedIndexChanged);
            // 
            // AutoEquipCheckbox
            // 
            this.AutoEquipCheckbox.AutoSize = true;
            this.AutoEquipCheckbox.Location = new System.Drawing.Point(12, 209);
            this.AutoEquipCheckbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AutoEquipCheckbox.Name = "AutoEquipCheckbox";
            this.AutoEquipCheckbox.Size = new System.Drawing.Size(124, 19);
            this.AutoEquipCheckbox.TabIndex = 14;
            this.AutoEquipCheckbox.Text = "自动装备鱼竿:";
            this.AutoEquipCheckbox.UseVisualStyleBackColor = true;
            this.AutoEquipCheckbox.CheckedChanged += new System.EventHandler(this.AutoEquipCheckbox_CheckedChanged);
            // 
            // InventoryFullCheckbox
            // 
            this.InventoryFullCheckbox.AutoSize = true;
            this.InventoryFullCheckbox.Location = new System.Drawing.Point(12, 129);
            this.InventoryFullCheckbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InventoryFullCheckbox.Name = "InventoryFullCheckbox";
            this.InventoryFullCheckbox.Size = new System.Drawing.Size(86, 19);
            this.InventoryFullCheckbox.TabIndex = 13;
            this.InventoryFullCheckbox.Text = "包满停止";
            this.InventoryFullCheckbox.UseVisualStyleBackColor = true;
            this.InventoryFullCheckbox.CheckedChanged += new System.EventHandler(this.InventoryFullCheckbox_CheckedChanged);
            // 
            // SaveOptions
            // 
            this.SaveOptions.Enabled = false;
            this.SaveOptions.Location = new System.Drawing.Point(11, 267);
            this.SaveOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveOptions.Name = "SaveOptions";
            this.SaveOptions.Size = new System.Drawing.Size(243, 28);
            this.SaveOptions.TabIndex = 7;
            this.SaveOptions.Text = "保存";
            this.SaveOptions.UseVisualStyleBackColor = true;
            this.SaveOptions.Click += new System.EventHandler(this.SaveOptions_Click);
            // 
            // TimerDuration
            // 
            this.TimerDuration.Location = new System.Drawing.Point(129, 21);
            this.TimerDuration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TimerDuration.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TimerDuration.Name = "TimerDuration";
            this.TimerDuration.Size = new System.Drawing.Size(61, 25);
            this.TimerDuration.TabIndex = 6;
            this.TimerDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TimerDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TimerDuration.ValueChanged += new System.EventHandler(this.TimerDuration_ValueChanged);
            // 
            // LogoutWhenDeadCheckBox
            // 
            this.LogoutWhenDeadCheckBox.AutoSize = true;
            this.LogoutWhenDeadCheckBox.Location = new System.Drawing.Point(12, 76);
            this.LogoutWhenDeadCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LogoutWhenDeadCheckBox.Name = "LogoutWhenDeadCheckBox";
            this.LogoutWhenDeadCheckBox.Size = new System.Drawing.Size(101, 19);
            this.LogoutWhenDeadCheckBox.TabIndex = 11;
            this.LogoutWhenDeadCheckBox.Text = "死亡后下线";
            this.LogoutWhenDeadCheckBox.UseVisualStyleBackColor = true;
            this.LogoutWhenDeadCheckBox.CheckedChanged += new System.EventHandler(this.LogoutWhenDeadCheckBox_CheckedChanged);
            // 
            // HearthstoneCheckBox
            // 
            this.HearthstoneCheckBox.AutoSize = true;
            this.HearthstoneCheckBox.Location = new System.Drawing.Point(12, 103);
            this.HearthstoneCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HearthstoneCheckBox.Name = "HearthstoneCheckBox";
            this.HearthstoneCheckBox.Size = new System.Drawing.Size(101, 19);
            this.HearthstoneCheckBox.TabIndex = 12;
            this.HearthstoneCheckBox.Text = "结束后炉石";
            this.HearthstoneCheckBox.UseVisualStyleBackColor = true;
            this.HearthstoneCheckBox.CheckedChanged += new System.EventHandler(this.HearthstoneCheckBox_CheckedChanged);
            // 
            // LogoutWhenDoneCheckBox
            // 
            this.LogoutWhenDoneCheckBox.AutoSize = true;
            this.LogoutWhenDoneCheckBox.Location = new System.Drawing.Point(12, 50);
            this.LogoutWhenDoneCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LogoutWhenDoneCheckBox.Name = "LogoutWhenDoneCheckBox";
            this.LogoutWhenDoneCheckBox.Size = new System.Drawing.Size(101, 19);
            this.LogoutWhenDoneCheckBox.TabIndex = 10;
            this.LogoutWhenDoneCheckBox.Text = "结束后下线";
            this.LogoutWhenDoneCheckBox.UseVisualStyleBackColor = true;
            this.LogoutWhenDoneCheckBox.CheckedChanged += new System.EventHandler(this.LogoutWhenDoneCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "分钟";
            // 
            // EnableTimerCheckBox
            // 
            this.EnableTimerCheckBox.AutoSize = true;
            this.EnableTimerCheckBox.Location = new System.Drawing.Point(12, 23);
            this.EnableTimerCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EnableTimerCheckBox.Name = "EnableTimerCheckBox";
            this.EnableTimerCheckBox.Size = new System.Drawing.Size(86, 19);
            this.EnableTimerCheckBox.TabIndex = 0;
            this.EnableTimerCheckBox.Text = "启用计时";
            this.EnableTimerCheckBox.UseVisualStyleBackColor = true;
            this.EnableTimerCheckBox.CheckedChanged += new System.EventHandler(this.EnableTimerCheckBox_CheckedChanged);
            // 
            // CurrentSessionBox
            // 
            this.CurrentSessionBox.Controls.Add(this.OpenLogButton);
            this.CurrentSessionBox.Controls.Add(this.TimerLabel);
            this.CurrentSessionBox.Controls.Add(this.FishCaughtLabel);
            this.CurrentSessionBox.Location = new System.Drawing.Point(60, 372);
            this.CurrentSessionBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CurrentSessionBox.Name = "CurrentSessionBox";
            this.CurrentSessionBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CurrentSessionBox.Size = new System.Drawing.Size(199, 111);
            this.CurrentSessionBox.TabIndex = 14;
            this.CurrentSessionBox.TabStop = false;
            this.CurrentSessionBox.Text = "当前状态";
            this.CurrentSessionBox.Visible = false;
            this.CurrentSessionBox.Enter += new System.EventHandler(this.CurrentSessionBox_Enter);
            // 
            // OpenLogButton
            // 
            this.OpenLogButton.Enabled = false;
            this.OpenLogButton.Location = new System.Drawing.Point(8, 76);
            this.OpenLogButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OpenLogButton.Name = "OpenLogButton";
            this.OpenLogButton.Size = new System.Drawing.Size(183, 28);
            this.OpenLogButton.TabIndex = 6;
            this.OpenLogButton.Text = "打开日志";
            this.OpenLogButton.UseVisualStyleBackColor = true;
            this.OpenLogButton.Click += new System.EventHandler(this.OpenLogButton_Click);
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Location = new System.Drawing.Point(7, 23);
            this.TimerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(45, 15);
            this.TimerLabel.TabIndex = 5;
            this.TimerLabel.Text = "用时:";
            // 
            // ConfirmProcessButton
            // 
            this.ConfirmProcessButton.Location = new System.Drawing.Point(570, 48);
            this.ConfirmProcessButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ConfirmProcessButton.Name = "ConfirmProcessButton";
            this.ConfirmProcessButton.Size = new System.Drawing.Size(100, 27);
            this.ConfirmProcessButton.TabIndex = 15;
            this.ConfirmProcessButton.Text = "确认";
            this.ConfirmProcessButton.UseVisualStyleBackColor = true;
            this.ConfirmProcessButton.Click += new System.EventHandler(this.ConfirmProcessButton_Click);
            // 
            // WowIDList
            // 
            this.WowIDList.FormattingEnabled = true;
            this.WowIDList.Location = new System.Drawing.Point(328, 52);
            this.WowIDList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.WowIDList.Name = "WowIDList";
            this.WowIDList.Size = new System.Drawing.Size(80, 23);
            this.WowIDList.TabIndex = 16;
            // 
            // ProcIdLabel
            // 
            this.ProcIdLabel.AutoSize = true;
            this.ProcIdLabel.Location = new System.Drawing.Point(416, 55);
            this.ProcIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProcIdLabel.Name = "ProcIdLabel";
            this.ProcIdLabel.Size = new System.Drawing.Size(109, 15);
            this.ProcIdLabel.TabIndex = 17;
            this.ProcIdLabel.Text = "进程 ID: 7862";
            this.ProcIdLabel.Visible = false;
            // 
            // RetryButton
            // 
            this.RetryButton.Location = new System.Drawing.Point(682, 48);
            this.RetryButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RetryButton.Name = "RetryButton";
            this.RetryButton.Size = new System.Drawing.Size(100, 27);
            this.RetryButton.TabIndex = 18;
            this.RetryButton.Text = "刷新列表";
            this.RetryButton.UseVisualStyleBackColor = true;
            this.RetryButton.Visible = false;
            this.RetryButton.Click += new System.EventHandler(this.RetryButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(299, 550);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Wotlk 3.3.5 Build 12340";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(325, 522);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Miaofish 1.0.0";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BitfishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RetryButton);
            this.Controls.Add(this.ProcIdLabel);
            this.Controls.Add(this.WowIDList);
            this.Controls.Add(this.ConfirmProcessButton);
            this.Controls.Add(this.CurrentSessionBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BitfishForm";
            this.Text = "小猫钓鱼";
            this.Load += new System.EventHandler(this.BitfishOnLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimerDuration)).EndInit();
            this.CurrentSessionBox.ResumeLayout(false);
            this.CurrentSessionBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label FishCaughtLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox EnableTimerCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox LogoutWhenDoneCheckBox;
        private System.Windows.Forms.CheckBox LogoutWhenDeadCheckBox;
        private System.Windows.Forms.CheckBox HearthstoneCheckBox;
        private System.Windows.Forms.NumericUpDown TimerDuration;
        private System.Windows.Forms.GroupBox CurrentSessionBox;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Button OpenLogButton;
        private System.Windows.Forms.Button SaveOptions;
        private System.Windows.Forms.Button ConfirmProcessButton;
        private System.Windows.Forms.ComboBox WowIDList;
        private System.Windows.Forms.Label ProcIdLabel;
        private System.Windows.Forms.CheckBox InventoryFullCheckbox;
        private System.Windows.Forms.CheckBox AutoEquipCheckbox;
        private System.Windows.Forms.ComboBox FishingPoleSelector;
        private System.Windows.Forms.CheckBox NearybyPlayerCheckbox;
        private System.Windows.Forms.Button RetryButton;
        private System.Windows.Forms.CheckBox WintergraspCheckbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

