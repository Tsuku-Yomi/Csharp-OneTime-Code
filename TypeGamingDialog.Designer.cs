
namespace ATP {
    partial class TypeGamingDialog {
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
            this.components = new System.ComponentModel.Container();
            this.staticLabel1 = new System.Windows.Forms.Label();
            this.progressIndicator = new System.Windows.Forms.Label();
            this.staticLabel2 = new System.Windows.Forms.Label();
            this.accuracyIndicator = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.textOutBox = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.staticLabel3 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // staticLabel1
            // 
            this.staticLabel1.AutoSize = true;
            this.staticLabel1.Location = new System.Drawing.Point(11, 14);
            this.staticLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.staticLabel1.Name = "staticLabel1";
            this.staticLabel1.Size = new System.Drawing.Size(32, 17);
            this.staticLabel1.TabIndex = 0;
            this.staticLabel1.Text = "进度";
            // 
            // progressIndicator
            // 
            this.progressIndicator.AutoSize = true;
            this.progressIndicator.Location = new System.Drawing.Point(62, 14);
            this.progressIndicator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.progressIndicator.Name = "progressIndicator";
            this.progressIndicator.Size = new System.Drawing.Size(27, 17);
            this.progressIndicator.TabIndex = 1;
            this.progressIndicator.Text = "0/0";
            // 
            // staticLabel2
            // 
            this.staticLabel2.AutoSize = true;
            this.staticLabel2.Location = new System.Drawing.Point(350, 14);
            this.staticLabel2.Name = "staticLabel2";
            this.staticLabel2.Size = new System.Drawing.Size(44, 17);
            this.staticLabel2.TabIndex = 2;
            this.staticLabel2.Text = "准确率";
            // 
            // accuracyIndicator
            // 
            this.accuracyIndicator.AutoSize = true;
            this.accuracyIndicator.Location = new System.Drawing.Point(400, 14);
            this.accuracyIndicator.Name = "accuracyIndicator";
            this.accuracyIndicator.Size = new System.Drawing.Size(43, 17);
            this.accuracyIndicator.TabIndex = 3;
            this.accuracyIndicator.Text = "0.00%";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(114, 14);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(213, 23);
            this.progressBar.TabIndex = 4;
            // 
            // textOutBox
            // 
            this.textOutBox.BackColor = System.Drawing.Color.White;
            this.textOutBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textOutBox.Location = new System.Drawing.Point(49, 106);
            this.textOutBox.Name = "textOutBox";
            this.textOutBox.ReadOnly = true;
            this.textOutBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.textOutBox.Size = new System.Drawing.Size(380, 143);
            this.textOutBox.TabIndex = 6;
            this.textOutBox.Text = "";
            // 
            // staticLabel3
            // 
            this.staticLabel3.AutoSize = true;
            this.staticLabel3.Location = new System.Drawing.Point(11, 51);
            this.staticLabel3.Name = "staticLabel3";
            this.staticLabel3.Size = new System.Drawing.Size(32, 17);
            this.staticLabel3.TabIndex = 7;
            this.staticLabel3.Text = "用时";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(62, 51);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(49, 17);
            this.timeLabel.TabIndex = 8;
            this.timeLabel.Text = "0:00:00";
            // 
            // TypeGamingDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.staticLabel3);
            this.Controls.Add(this.textOutBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.accuracyIndicator);
            this.Controls.Add(this.staticLabel2);
            this.Controls.Add(this.progressIndicator);
            this.Controls.Add(this.staticLabel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "TypeGamingDialog";
            this.Size = new System.Drawing.Size(505, 293);
            this.Load += new System.EventHandler(this.TypeGamingDialog_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TypeGamingDialog_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label staticLabel1;
        private System.Windows.Forms.Label progressIndicator;
        private System.Windows.Forms.Label staticLabel2;
        private System.Windows.Forms.Label accuracyIndicator;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.RichTextBox textOutBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label staticLabel3;
        private System.Windows.Forms.Label timeLabel;
    }
}
