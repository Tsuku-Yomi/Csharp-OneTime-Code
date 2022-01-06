using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ATP {
    public partial class TextChooseDialog : UserControl {
        public TextChooseDialog() {
            InitializeComponent();
            GetFile();
        }
        const string TXT_PATH = "./articles";
        public GameStartMessage startMsg;
        void GetFile() {
            DirectoryInfo root = new DirectoryInfo(TXT_PATH);
            FileInfo[] files = root.GetFiles();
            textChoose.Items.Clear();
            foreach(FileInfo file in files) {
                if (Path.GetExtension(file.Name) == ".txt") {
                    textChoose.Items.Add(Path.GetFileNameWithoutExtension(file.Name));
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e) {
            string t = TXT_PATH + (string)textChoose.SelectedItem+".txt";
            startMsg(t,nameTextBox.Text);
            Hide();
            Dispose();
            return;            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) {

        }
    }
}
