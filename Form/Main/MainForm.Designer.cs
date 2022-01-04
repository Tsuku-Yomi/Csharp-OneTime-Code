
namespace ATP {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highScoreTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.highScoreTableToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(622, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseTextToolStripMenuItem,
            this.randomTextToolStripMenuItem});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // chooseTextToolStripMenuItem
            // 
            this.chooseTextToolStripMenuItem.Name = "chooseTextToolStripMenuItem";
            this.chooseTextToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.chooseTextToolStripMenuItem.Text = "Choose Text";
            this.chooseTextToolStripMenuItem.Click += new System.EventHandler(this.chooseTextToolStripMenuItem_Click);
            // 
            // randomTextToolStripMenuItem
            // 
            this.randomTextToolStripMenuItem.Name = "randomTextToolStripMenuItem";
            this.randomTextToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.randomTextToolStripMenuItem.Text = "Random Text";
            // 
            // highScoreTableToolStripMenuItem
            // 
            this.highScoreTableToolStripMenuItem.Name = "highScoreTableToolStripMenuItem";
            this.highScoreTableToolStripMenuItem.Size = new System.Drawing.Size(120, 21);
            this.highScoreTableToolStripMenuItem.Text = "High Score Table";
            this.highScoreTableToolStripMenuItem.Click += new System.EventHandler(this.highScoreTableToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft YaHei UI", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(69, 57);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(477, 111);
            this.label.TabIndex = 1;
            this.label.Text = "打字练习机";
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startBtn.Location = new System.Drawing.Point(170, 230);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(253, 70);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "开始游戏";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 382);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.Text = "I am a ruthless typing machine";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highScoreTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomTextToolStripMenuItem;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button startBtn;
    }
}

