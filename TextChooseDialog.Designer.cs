
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
            this.textChoose = new System.Windows.Forms.ComboBox();
            this.startButton = new System.Windows.Forms.Button();
            this.fontChooseBtn = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.RichTextBox();
            this.clrLChooseBtn = new System.Windows.Forms.Button();
            this.clrRChooseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usingUserSetting
            // 
            this.usingUserSetting.AutoSize = true;
            this.usingUserSetting.Enabled = false;
            this.usingUserSetting.Location = new System.Drawing.Point(33, 84);
            this.usingUserSetting.Name = "usingUserSetting";
            this.usingUserSetting.Size = new System.Drawing.Size(111, 21);
            this.usingUserSetting.TabIndex = 0;
            this.usingUserSetting.Text = "使用自定义设置";
            this.usingUserSetting.UseVisualStyleBackColor = true;
            // 
            // textChoose
            // 
            this.textChoose.FormattingEnabled = true;
            this.textChoose.Location = new System.Drawing.Point(39, 36);
            this.textChoose.Name = "textChoose";
            this.textChoose.Size = new System.Drawing.Size(121, 25);
            this.textChoose.TabIndex = 3;
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
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(33, 142);
            this.nameTextBox.Multiline = false;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.nameTextBox.Size = new System.Drawing.Size(127, 25);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.Text = "Player";
            this.nameTextBox.WordWrap = false;
            this.nameTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "玩家ID";
            // 
            // TextChooseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clrRChooseBtn);
            this.Controls.Add(this.clrLChooseBtn);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.fontChooseBtn);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.textChoose);
            this.Controls.Add(this.usingUserSetting);
            this.Name = "TextChooseDialog";
            this.Size = new System.Drawing.Size(295, 255);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox usingUserSetting;
        private System.Windows.Forms.ComboBox textChoose;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button fontChooseBtn;
        private System.Windows.Forms.RichTextBox nameTextBox;
        private System.Windows.Forms.Button clrLChooseBtn;
        private System.Windows.Forms.Button clrRChooseBtn;
        private System.Windows.Forms.Label label1;
    }
}
