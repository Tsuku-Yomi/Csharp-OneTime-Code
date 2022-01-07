using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ATP {
    public partial class TypeGamingDialog : UserControl {
        public TypeGamingDialog(string text,string name) {
            FileStream file = new FileStream(text, FileMode.Open);
            StreamReader streamReader = new StreamReader(file);
            this.text = streamReader.ReadToEnd().Replace('\n',' ').Replace('\r',' ');
            streamReader.Close();
            file.Close();
            playerName = name;
            waitTextInputPointer = 0;
            InitializeComponent();
            
        }
        string playerName;
        bool StartTimer = false;
        int tickTime;
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
            textOutBox.SelectionStart = waitTextInputPointer;
            textOutBox.Select(waitTextInputPointer, 1);
            textOutBox.ScrollToCaret();
        }

        

        public void TypeGamingDialog_KeyPress(object sender, KeyPressEventArgs e) {
            //TODO Better show up effect
            //短路防溢出
            if (waitTextInputPointer < text.Length &&
                e.KeyChar == text[waitTextInputPointer]) {
                textOutBox.SelectionBackColor = Color.Yellow;
                textOutBox.SelectionStart = waitTextInputPointer;
                textOutBox.ScrollToCaret();
                //textOutBox.Select(0, 0);
                waitTextInputPointer++;
                textOutBox.Select(waitTextInputPointer, 1);
                progressBar.Value = waitTextInputPointer;
                progressIndicator.Text = waitTextInputPointer.ToString() + "/" + lenText;
                if (waitTextInputPointer == text.Length) {
                    successMsg(new GameRecord((int)((text.Length*5-tickTime)* (double)waitTextInputPointer / totalInput),playerName));
                }
            }
            if (totalInput==0) { tickTime = 0; StartTimer = true; }
            totalInput++;
            accuracyIndicator.Text = ((double)waitTextInputPointer/ totalInput).ToString("P");
            
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if(StartTimer) {
                tickTime += 1;
                timeLabel.Text = (tickTime / 60).ToString() + ":" + (tickTime % 60).ToString();
            }
                
        }

        private void textOutBox_KeyPress(object sender, KeyPressEventArgs e) {
            TypeGamingDialog_KeyPress(sender, e);
        }
    }
}
