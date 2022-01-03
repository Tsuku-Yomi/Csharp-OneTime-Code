
namespace ATP {
    partial class TextChooseDialog {
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
            this.usingUserSetting = new System.Windows.Forms.CheckBox();
            this.textComboBox = new System.Windows.Forms.ComboBox();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usingUserSetting
            // 
            this.usingUserSetting.AutoSize = true;
            this.usingUserSetting.Location = new System.Drawing.Point(33, 84);
            this.usingUserSetting.Name = "usingUserSetting";
            this.usingUserSetting.Size = new System.Drawing.Size(111, 21);
            this.usingUserSetting.TabIndex = 0;
            this.usingUserSetting.Text = "使用自定义设置";
            this.usingUserSetting.UseVisualStyleBackColor = true;
            // 
            // textComboBox
            // 
            this.textComboBox.FormattingEnabled = true;
            this.textComboBox.Location = new System.Drawing.Point(33, 31);
            this.textComboBox.Name = "textComboBox";
            this.textComboBox.Size = new System.Drawing.Size(121, 25);
            this.textComboBox.TabIndex = 3;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(33, 149);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "开始游戏";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // TextChooseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.textComboBox);
            this.Controls.Add(this.usingUserSetting);
            this.Name = "TextChooseDialog";
            this.Size = new System.Drawing.Size(422, 255);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox usingUserSetting;
        private System.Windows.Forms.ComboBox textComboBox;
        private System.Windows.Forms.Button startButton;
    }
}
