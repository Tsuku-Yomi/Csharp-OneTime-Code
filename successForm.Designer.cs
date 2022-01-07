
namespace ATP {
    partial class successForm {
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
            this.staticLabel = new System.Windows.Forms.Label();
            this.staticLabel2 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // staticLabel
            // 
            this.staticLabel.AutoSize = true;
            this.staticLabel.Location = new System.Drawing.Point(12, 30);
            this.staticLabel.Name = "staticLabel";
            this.staticLabel.Size = new System.Drawing.Size(24, 17);
            this.staticLabel.TabIndex = 0;
            this.staticLabel.Text = "ID:";
            // 
            // staticLabel2
            // 
            this.staticLabel2.AutoSize = true;
            this.staticLabel2.Location = new System.Drawing.Point(12, 51);
            this.staticLabel2.Name = "staticLabel2";
            this.staticLabel2.Size = new System.Drawing.Size(35, 17);
            this.staticLabel2.TabIndex = 1;
            this.staticLabel2.Text = "分数:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(61, 30);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 17);
            this.nameLabel.TabIndex = 2;
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(61, 51);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(0, 17);
            this.gradeLabel.TabIndex = 3;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(70, 103);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "上传分数";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // successForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 150);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.staticLabel2);
            this.Controls.Add(this.staticLabel);
            this.Name = "successForm";
            this.Text = "你赢了！";
            this.Load += new System.EventHandler(this.successForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label staticLabel;
        private System.Windows.Forms.Label staticLabel2;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Button exitBtn;
    }
}