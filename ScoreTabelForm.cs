using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATP {

    public partial class ScoreTabelForm : Form {
        public ScoreTabelForm() {
            InitializeComponent();
            if (GameRecordList.gameRecords == null) {
                GameRecordList.gameRecords = NetworkConnect.UpdateScore(new GameRecord(1, "Player"));
            }
            listBox.Items.Clear();
            listBox.Items.Add("玩家名称 - 玩家分数");
            foreach(GameRecord gameRecord in GameRecordList.gameRecords) {
                listBox.Items.Add(gameRecord.name + " - " + gameRecord.score.ToString());
            }
        }

        private void updateDataBtn_Click(object sender, EventArgs e) {
            GameRecordList.gameRecords = NetworkConnect.GetGameRecords();
            listBox.Items.Clear();
            listBox.Items.Add("玩家名称 - 玩家分数");
            foreach (GameRecord gameRecord in GameRecordList.gameRecords) {
                listBox.Items.Add(gameRecord.name + " - " + gameRecord.score.ToString());
            }
        }

        private void exitBtn_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
