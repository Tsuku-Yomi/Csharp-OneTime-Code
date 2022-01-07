using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATP {
    public partial class successForm : Form {
        public successForm(GameRecord gameRecord) {
            InitializeComponent();
            gameR = gameRecord;
            nameLabel.Text = gameRecord.name;
            gradeLabel.Text = gameRecord.score.ToString();
        }
        GameRecord gameR;
        private void successForm_Load(object sender, EventArgs e) {

        }

        private void exitBtn_Click(object sender, EventArgs e) {
            NetworkConnect.UpdateScore(gameR);
            Hide();
            Dispose();
        }
    }
}
