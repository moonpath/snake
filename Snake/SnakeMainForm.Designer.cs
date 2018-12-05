namespace Snake
{
    partial class SnakeMainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnakeMainForm));
            this.run = new System.Windows.Forms.Timer(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.GameMenu = new System.Windows.Forms.MenuStrip();
            this.GameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IntroductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SubPanel = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.LevelBox = new System.Windows.Forms.TextBox();
            this.CurrentScoreBox = new System.Windows.Forms.TextBox();
            this.HighestScoreBox = new System.Windows.Forms.TextBox();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.CurrentScoreLabel = new System.Windows.Forms.Label();
            this.HighestScoreLabel = new System.Windows.Forms.Label();
            this.GameMenu.SuspendLayout();
            this.SubPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // run
            // 
            this.run.Interval = 200;
            this.run.Tick += new System.EventHandler(this.run_Tick);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Location = new System.Drawing.Point(3, 28);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(503, 503);
            this.MainPanel.TabIndex = 0;
            // 
            // GameMenu
            // 
            this.GameMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GameToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.GameMenu.Location = new System.Drawing.Point(0, 0);
            this.GameMenu.Name = "GameMenu";
            this.GameMenu.Size = new System.Drawing.Size(641, 25);
            this.GameMenu.TabIndex = 1;
            this.GameMenu.Text = "menuStrip1";
            // 
            // GameToolStripMenuItem
            // 
            this.GameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartToolStripMenuItem,
            this.EndToolStripMenuItem});
            this.GameToolStripMenuItem.Name = "GameToolStripMenuItem";
            this.GameToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.GameToolStripMenuItem.Text = "游戏";
            // 
            // StartToolStripMenuItem
            // 
            this.StartToolStripMenuItem.Name = "StartToolStripMenuItem";
            this.StartToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.StartToolStripMenuItem.Text = "开始";
            this.StartToolStripMenuItem.Click += new System.EventHandler(this.StartToolStripMenuItem_Click);
            // 
            // EndToolStripMenuItem
            // 
            this.EndToolStripMenuItem.Name = "EndToolStripMenuItem";
            this.EndToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.EndToolStripMenuItem.Text = "退出";
            this.EndToolStripMenuItem.Click += new System.EventHandler(this.EndToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IntroductionToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.HelpToolStripMenuItem.Text = "帮助";
            // 
            // IntroductionToolStripMenuItem
            // 
            this.IntroductionToolStripMenuItem.Name = "IntroductionToolStripMenuItem";
            this.IntroductionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.IntroductionToolStripMenuItem.Text = "说明";
            this.IntroductionToolStripMenuItem.Click += new System.EventHandler(this.IntroductionToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AboutToolStripMenuItem.Text = "关于";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // SubPanel
            // 
            this.SubPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.SubPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubPanel.Controls.Add(this.StartButton);
            this.SubPanel.Controls.Add(this.LevelBox);
            this.SubPanel.Controls.Add(this.CurrentScoreBox);
            this.SubPanel.Controls.Add(this.HighestScoreBox);
            this.SubPanel.Controls.Add(this.LevelLabel);
            this.SubPanel.Controls.Add(this.CurrentScoreLabel);
            this.SubPanel.Controls.Add(this.HighestScoreLabel);
            this.SubPanel.Location = new System.Drawing.Point(509, 28);
            this.SubPanel.Name = "SubPanel";
            this.SubPanel.Size = new System.Drawing.Size(129, 503);
            this.SubPanel.TabIndex = 2;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(27, 424);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "开始";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // LevelBox
            // 
            this.LevelBox.Location = new System.Drawing.Point(73, 259);
            this.LevelBox.Name = "LevelBox";
            this.LevelBox.ReadOnly = true;
            this.LevelBox.Size = new System.Drawing.Size(29, 21);
            this.LevelBox.TabIndex = 5;
            // 
            // CurrentScoreBox
            // 
            this.CurrentScoreBox.Location = new System.Drawing.Point(73, 171);
            this.CurrentScoreBox.Name = "CurrentScoreBox";
            this.CurrentScoreBox.ReadOnly = true;
            this.CurrentScoreBox.Size = new System.Drawing.Size(29, 21);
            this.CurrentScoreBox.TabIndex = 4;
            // 
            // HighestScoreBox
            // 
            this.HighestScoreBox.Location = new System.Drawing.Point(73, 80);
            this.HighestScoreBox.Name = "HighestScoreBox";
            this.HighestScoreBox.ReadOnly = true;
            this.HighestScoreBox.Size = new System.Drawing.Size(29, 21);
            this.HighestScoreBox.TabIndex = 3;
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Location = new System.Drawing.Point(17, 262);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(65, 12);
            this.LevelLabel.TabIndex = 2;
            this.LevelLabel.Text = "当前等级：";
            // 
            // CurrentScoreLabel
            // 
            this.CurrentScoreLabel.AutoSize = true;
            this.CurrentScoreLabel.Location = new System.Drawing.Point(17, 174);
            this.CurrentScoreLabel.Name = "CurrentScoreLabel";
            this.CurrentScoreLabel.Size = new System.Drawing.Size(65, 12);
            this.CurrentScoreLabel.TabIndex = 1;
            this.CurrentScoreLabel.Text = "当前分数：";
            // 
            // HighestScoreLabel
            // 
            this.HighestScoreLabel.AutoSize = true;
            this.HighestScoreLabel.Location = new System.Drawing.Point(17, 83);
            this.HighestScoreLabel.Name = "HighestScoreLabel";
            this.HighestScoreLabel.Size = new System.Drawing.Size(65, 12);
            this.HighestScoreLabel.TabIndex = 0;
            this.HighestScoreLabel.Text = "最高分数：";
            // 
            // SnakeMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(641, 534);
            this.Controls.Add(this.SubPanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.GameMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.GameMenu;
            this.MaximizeBox = false;
            this.Name = "SnakeMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "贪吃蛇";
            this.Load += new System.EventHandler(this.SnakeMainForm_Load);
            this.GameMenu.ResumeLayout(false);
            this.GameMenu.PerformLayout();
            this.SubPanel.ResumeLayout(false);
            this.SubPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer run;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.MenuStrip GameMenu;
        private System.Windows.Forms.ToolStripMenuItem GameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IntroductionToolStripMenuItem;
        private System.Windows.Forms.Panel SubPanel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox LevelBox;
        private System.Windows.Forms.TextBox CurrentScoreBox;
        private System.Windows.Forms.TextBox HighestScoreBox;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label CurrentScoreLabel;
        private System.Windows.Forms.Label HighestScoreLabel;
        private System.Windows.Forms.ToolStripMenuItem EndToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
    }
}

