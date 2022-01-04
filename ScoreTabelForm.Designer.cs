
namespace ATP {
    partial class ScoreTabelForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.updateDataBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // updateDataBtn
            // 
            this.updateDataBtn.Location = new System.Drawing.Point(40, 515);
            this.updateDataBtn.Name = "updateDataBtn";
            this.updateDataBtn.Size = new System.Drawing.Size(93, 60);
            this.updateDataBtn.TabIndex = 1;
            this.updateDataBtn.Text = "获取新数据";
            this.updateDataBtn.UseVisualStyleBackColor = true;
            this.updateDataBtn.Click += new System.EventHandler(this.updateDataBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(204, 516);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(100, 59);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "关闭排行榜";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 41;
            this.listBox.Items.AddRange(new object[] {
            "玩家ID：玩家分数"});
            this.listBox.Location = new System.Drawing.Point(13, 13);
            this.listBox.Name = "listBox";
            this.listBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox.Size = new System.Drawing.Size(332, 455);
            this.listBox.TabIndex = 3;
            // 
            // ScoreTabelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 587);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.updateDataBtn);
            this.Name = "ScoreTabelForm";
            this.Text = "ScoreTabelForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateDataBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ListBox listBox;
    }
}