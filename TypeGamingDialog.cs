using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATP {
    public partial class TypeGamingDialog : UserControl {
        public TypeGamingDialog(string text) {
            this.text = text;
            waitTextInputPointer = 0;
            InitializeComponent();
            
        }
        public ComponentMessage successMsg;
        public string text;
        public string lenText;
        public int waitTextInputPointer;
        public int totalInput = 0;
        private void TypeGamingDialog_Load(object sender, EventArgs e) {
            textOutBox.Text = text;
            textOutBox.Select(0, text.Length);
            textOutBox.SelectionBackColor = Color.GreenYellow;
            totalInput = 0;
            progressBar.Maximum = textOutBox.Text.Length;
            progressBar.Value = 0;
            lenText = textOutBox.Text.Length.ToString();
            progressIndicator.Text = "0/" + lenText;
        }

        public void TypeGamingDialog_KeyPress(object sender, KeyPressEventArgs e) {
            //TODO Better show up effect
            //短路防溢出
            if (waitTextInputPointer < text.Length &&
                e.KeyChar == text[waitTextInputPointer]) {
                textOutBox.Select(waitTextInputPointer, 1);
                textOutBox.SelectionBackColor = Color.Yellow;
                textOutBox.SelectionStart = waitTextInputPointer;
                textOutBox.ScrollToCaret();
                textOutBox.Select(0, 0);
                waitTextInputPointer++;
                progressBar.Value = waitTextInputPointer;
                progressIndicator.Text = waitTextInputPointer.ToString() + "/" + lenText;
                if (waitTextInputPointer == text.Length) {
                    //TODO success form
                }
            }
            totalInput++;
            accuracyIndicator.Text = ((double)waitTextInputPointer/ totalInput).ToString("P");
            
        }
    }
}
