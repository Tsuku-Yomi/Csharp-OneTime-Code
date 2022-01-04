
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
            this.fontChooseBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.clrLChooseBtn = new System.Windows.Forms.Button();
            this.clrRChooseBtn = new System.Windows.Forms.Button();
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
            this.textComboBox.SelectedIndexChanged += new System.EventHandler(this.textComboBox_SelectedIndexChanged);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(33, 203);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "开始游戏";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // fontChooseBtn
            // 
            this.fontChooseBtn.Location = new System.Drawing.Point(181, 84);
            this.fontChooseBtn.Name = "fontChooseBtn";
            this.fontChooseBtn.Size = new System.Drawing.Size(84, 23);
            this.fontChooseBtn.TabIndex = 5;
            this.fontChooseBtn.Text = "修改字体";
            this.fontChooseBtn.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(33, 111);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(127, 63);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // clrLChooseBtn
            // 
            this.clrLChooseBtn.Location = new System.Drawing.Point(181, 113);
            this.clrLChooseBtn.Name = "clrLChooseBtn";
            this.clrLChooseBtn.Size = new System.Drawing.Size(84, 23);
            this.clrLChooseBtn.TabIndex = 7;
            this.clrLChooseBtn.Text = "修改颜色1";
            this.clrLChooseBtn.UseVisualStyleBackColor = true;
            // 
            // clrRChooseBtn
            // 
            this.clrRChooseBtn.Location = new System.Drawing.Point(181, 142);
            this.clrRChooseBtn.Name = "clrRChooseBtn";
            this.clrRChooseBtn.Size = new System.Drawing.Size(84, 23);
            this.clrRChooseBtn.TabIndex = 8;
            this.clrRChooseBtn.Text = "修改颜色2";
            this.clrRChooseBtn.UseVisualStyleBackColor = true;
            // 
            // TextChooseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clrRChooseBtn);
            this.Controls.Add(this.clrLChooseBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.fontChooseBtn);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.textComboBox);
            this.Controls.Add(this.usingUserSetting);
            this.Name = "TextChooseDialog";
            this.Size = new System.Drawing.Size(295, 255);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox usingUserSetting;
        private System.Windows.Forms.ComboBox textComboBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button fontChooseBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button clrLChooseBtn;
        private System.Windows.Forms.Button clrRChooseBtn;
    }
}
