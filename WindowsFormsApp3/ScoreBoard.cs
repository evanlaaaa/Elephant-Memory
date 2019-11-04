using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StupidGame {
    public partial class ScoreBoard : Form {
        DB db = new DB();
        Chart c = new Chart();
        List<string[]> sb;
        int type_index;
        public ScoreBoard() {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            pb1pEasy_Click(null, null);
            pbMenu.Parent = panel1;
            pbChart.Parent = panel1;
        }

        private void pb1pEasy_Click(object sender, EventArgs e) {
            if (c.Visible)
                c.Close();
            sb = db.getScoreBoard(1);
            removeLabels();
            createScoreboard1p(sb);
            type_index = 1;
        }

        private void pb1pHard_Click(object sender, EventArgs e) {
            if (c.Visible)
                c.Close();
            sb = db.getScoreBoard(2);
            removeLabels();
            createScoreboard1p(sb);
            type_index = 2;
        }

        private void pb2p_Click(object sender, EventArgs e) {
            if (c.Visible)
                c.Close();
            sb = db.getScoreBoard(3);
            removeLabels();
            createScoreboard2p(sb);           
        }

        private void pbMenu_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void pbChart_Click(object sender, EventArgs e) {
            if(!c.Visible) {
                c = new Chart(type_index);
                c.Show();
            } 
        }

        private void createScoreboard1p(List<string[]> s) {
            pbChart.Show();
            if (sb.Count == 0) {
                MessageBox.Show("No available record in this mode");
                pbChart.Enabled = false;
                return;
            }
            pbChart.Enabled = true;
            Label lblRank = createLabel(95, 55, "Rank");
            Label lblName = createLabel(233, 55, "Name");
            Label lblScore = createLabel(383, 55, "Score");
            Label lblTime = createLabel(528, 55, "Time");
            this.Controls.Add(lblRank);
            this.Controls.Add(lblName);
            this.Controls.Add(lblScore);
            this.Controls.Add(lblTime);
            lblRank.Parent = panel1;
            lblName.Parent = panel1;
            lblScore.Parent = panel1;
            lblTime.Parent = panel1;

            int i = 1;
            int stackX = 95;
            int sX = 139;
            int stackY = 100;
            int sY = 38;
            foreach (string[] x in s) {
                stackX = 95;
                Label rank = createLabel(stackX, stackY, i.ToString());
                stackX += sX;
                Label name = createLabel(stackX, stackY, x[0]);
                stackX += sX;
                Label score = createLabel(stackX, stackY, x[1]);
                stackX += sX;
                Label time = createLabel(stackX, stackY, x[2]);
                stackY += sY;

                this.Controls.Add(rank);
                this.Controls.Add(name);
                this.Controls.Add(score);
                this.Controls.Add(time);
                rank.Parent = panel1;
                name.Parent = panel1;
                score.Parent = panel1;
                time.Parent = panel1;
                i++;
            }
        }

        private void createScoreboard2p(List<string[]> s) {
            pbChart.Hide();
            Label lblRank = createLabel(65, 55, "Rank");
            Label lblName = createLabel(350, 55, "Details");
            Label lblScore = createLabel(635, 55, "Winner");
            this.Controls.Add(lblRank);
            this.Controls.Add(lblName);
            this.Controls.Add(lblScore);
            lblRank.Parent = panel1;
            lblName.Parent = panel1;
            lblScore.Parent = panel1;
            
            int i = 1;
            int stackX = 65;
            int sX = 100;
            int stackY = 100;
            int sY = 38;
            foreach (string[] x in s) {
                stackX = 65;
                Label rank = createLabel(stackX, stackY, i.ToString());
                stackX += sX;
                Label name = createLabel(stackX, stackY, x[0]+" ("+x[2]+") vs "+x[1]+" ("+x[3]+")");
                stackX = stackX + sX + 370;
                Label score = createLabel(stackX, stackY, x[0]);
                stackY += sY;

                this.Controls.Add(rank);
                this.Controls.Add(name);
                this.Controls.Add(score);
                rank.Parent = panel1;
                name.Parent = panel1;
                score.Parent = panel1;
                i++;
            }
        }

        private void removeLabels() {
            panel1.Visible = false;
            pb1pEasy.Parent = this;
            pb1pHard.Parent = this;
            pb2p.Parent = this;
            pbMenu.Parent = this;
            pbChart.Parent = this;

            panel1.Controls.Clear();
            
            pb1pEasy.Parent = panel1;
            pb1pHard.Parent = panel1;
            pb2p.Parent = panel1;
            pbMenu.Parent = panel1;
            pbChart.Parent = panel1;
            panel1.Visible = true;
        }

        private Label createLabel(int stackX, int stackY, string label) {
            return new Label {
                Font = new Font("MV Boli", 18),
                ForeColor = Color.White,
                Size = new Size(74, 31),
                AutoSize = true,
                Location = new Point(stackX, stackY),
                Text = label,
                BackColor = Color.Transparent
            };
        }

    }
}
