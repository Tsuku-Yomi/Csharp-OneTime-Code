using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATP {
    public delegate void GameStartMsg(string t);
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void MainForm_Load(object sender, EventArgs e) {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            (new AboutForm()).ShowDialog();
        }

        private void chooseTextToolStripMenuItem_Click(object sender, EventArgs e) {
            TextChooseDialog textChooseDialog = new TextChooseDialog();
            textChooseDialog.startMsg += this.StartGame;
            textChooseDialog.AutoSize = true;
            textChooseDialog.Location = new System.Drawing.Point(40, 40);
            Controls.Add(textChooseDialog);
            textChooseDialog.Show();
        }

        private TypeGamingDialog gamingDialog;
        private int gameState=0;
        private ScoreTabelForm scoreTabelForm=null;

        public void StartGame(string t) {
            gamingDialog = new TypeGamingDialog(t);
            gamingDialog.AutoSize = true;
            gamingDialog.Location = new System.Drawing.Point(40, 40);
            Controls.Add(gamingDialog);
            gamingDialog.Show();
            gameState = 1;
        }

        private void EndGame() {

        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e) {
            if (gameState == 1) {
                gamingDialog.TypeGamingDialog_KeyPress(sender, e);
            }
        }

        private void highScoreTableToolStripMenuItem_Click(object sender, EventArgs e) {
            if (scoreTabelForm == null) { scoreTabelForm = new ScoreTabelForm(); }
            scoreTabelForm.Show();
        }

        private void startBtn_Click(object sender, EventArgs e) {
            chooseTextToolStripMenuItem_Click(sender, e);
        }
    }
}
