
namespace ATP {
    partial class UserSetting {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.fontBtn = new System.Windows.Forms.Button();
            this.fontUnfinishTest = new System.Windows.Forms.Label();
            this.fontFinishTest = new System.Windows.Forms.Label();
            this.unfinishClrBtn = new System.Windows.Forms.Button();
            this.finishClrBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fontBtn
            // 
            this.fontBtn.Location = new System.Drawing.Point(3, 38);
            this.fontBtn.Name = "fontBtn";
            this.fontBtn.Size = new System.Drawing.Size(97, 23);
            this.fontBtn.TabIndex = 0;
            this.fontBtn.Text = "修改显示字体";
            this.fontBtn.UseVisualStyleBackColor = true;
            this.fontBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // fontUnfinishTest
            // 
            this.fontUnfinishTest.AutoSize = true;
            this.fontUnfinishTest.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fontUnfinishTest.Location = new System.Drawing.Point(150, 38);
            this.fontUnfinishTest.Name = "fontUnfinishTest";
            this.fontUnfinishTest.Size = new System.Drawing.Size(112, 27);
            this.fontUnfinishTest.TabIndex = 1;
            this.fontUnfinishTest.Text = "未完成ABC";
            // 
            // fontFinishTest
            // 
            this.fontFinishTest.AutoSize = true;
            this.fontFinishTest.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fontFinishTest.Location = new System.Drawing.Point(150, 96);
            this.fontFinishTest.Name = "fontFinishTest";
            this.fontFinishTest.Size = new System.Drawing.Size(112, 27);
            this.fontFinishTest.TabIndex = 2;
            this.fontFinishTest.Text = "已完成ABC";
            // 
            // unfinishClrBtn
            // 
            this.unfinishClrBtn.Location = new System.Drawing.Point(4, 68);
            this.unfinishClrBtn.Name = "unfinishClrBtn";
            this.unfinishClrBtn.Size = new System.Drawing.Size(96, 23);
            this.unfinishClrBtn.TabIndex = 3;
            this.unfinishClrBtn.Text = "修改起始颜色";
            this.unfinishClrBtn.UseVisualStyleBackColor = true;
            // 
            // finishClrBtn
            // 
            this.finishClrBtn.Location = new System.Drawing.Point(4, 98);
            this.finishClrBtn.Name = "finishClrBtn";
            this.finishClrBtn.Size = new System.Drawing.Size(96, 23);
            this.finishClrBtn.TabIndex = 4;
            this.finishClrBtn.Text = "修改完成颜色";
            this.finishClrBtn.UseVisualStyleBackColor = true;
            // 
            // UserSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.finishClrBtn);
            this.Controls.Add(this.unfinishClrBtn);
            this.Controls.Add(this.fontFinishTest);
            this.Controls.Add(this.fontUnfinishTest);
            this.Controls.Add(this.fontBtn);
            this.Name = "UserSetting";
            this.Size = new System.Drawing.Size(292, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fontBtn;
        private System.Windows.Forms.Label fontUnfinishTest;
        private System.Windows.Forms.Label fontFinishTest;
        private System.Windows.Forms.Button unfinishClrBtn;
        private System.Windows.Forms.Button finishClrBtn;
    }
}
