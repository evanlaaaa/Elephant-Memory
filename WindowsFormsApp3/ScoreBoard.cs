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
        private DB db = new DB();
        private Chart c = new Chart();
        private List<string[]> sb;
        private int type_index;
        public ScoreBoard() {
            InitializeComponent();

            //change background to semi-transparent
            plBackground.BackColor = Color.FromArgb(100, 0, 0, 0);

            //trigger click event to display first mode scoreboard
            pb1pEasy_Click(null, null);

            //make those pictureboxes' background blend to background
            pbMenu.Parent = plBackground;
            pbChart.Parent = plBackground;
        }

        private void pb1pEasy_Click(object sender, EventArgs e) {
            //whenever player click to show another mode of scoreboard
            //check if chart form was opened or not
            //if yes then close the chart form
            if (c.Visible)
                c.Close();
            
            //call db function to get data
            sb = db.getScoreBoard(1);

            //call function to clear all label
            removeLabels();

            //pass data pack to function and start create label
            createScoreboard1p(sb);

            //change type_index for chart form purpose
            type_index = 1;
        }

        private void pb1pHard_Click(object sender, EventArgs e) {
            //whenever player click to show another mode of scoreboard
            //check if chart form was opened or not
            //if yes then close the chart form
            if (c.Visible)
                c.Close();

            //call db function to get data
            sb = db.getScoreBoard(2);

            //call function to clear all label
            removeLabels();

            //pass data pack to function and start create label
            createScoreboard1p(sb);

            //change type_index for chart form purpose
            type_index = 2;
        }

        private void pb2p_Click(object sender, EventArgs e) {
            //whenever player click to show another mode of scoreboard
            //check if chart form was opened or not
            //if yes then close the chart form
            if (c.Visible)
                c.Close();

            //call db function to get data
            sb = db.getScoreBoard(3);

            //call function to clear all label
            removeLabels();

            //pass data pack to function and start create label
            createScoreboard2p(sb);

            //as player 2 mode doesn't support chart, so nothing to assign to type_idnex
        }

        private void pbMenu_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void pbChart_Click(object sender, EventArgs e) {
            //open chart form only when chart form isn't opened
            if(!c.Visible) {
                c = new Chart(type_index);
                c.Show();
            } 
        }

        private void createScoreboard1p(List<string[]> s) {
            pbChart.Show();

            //if the mode doesn't have record, pop dialog box and disable chart button
            if (sb.Count == 0) {
                MessageBox.Show("No available record in this mode");
                pbChart.Enabled = false;
                return;
            }

            pbChart.Enabled = true;

            //create header
            Label lblRank = createLabel(95, 55, "Rank");
            Label lblName = createLabel(233, 55, "Name");
            Label lblScore = createLabel(383, 55, "Score");
            Label lblTime = createLabel(528, 55, "Time");

            //add header to form
            this.Controls.Add(lblRank);
            this.Controls.Add(lblName);
            this.Controls.Add(lblScore);
            this.Controls.Add(lblTime);

            //and assign their parent to the panel background
            lblRank.Parent = plBackground;
            lblName.Parent = plBackground;
            lblScore.Parent = plBackground;
            lblTime.Parent = plBackground;

            //variables for create label
            int i = 1;
            int stackX = 95;
            int sX = 139;
            int stackY = 100;
            int sY = 38;

            //loop through all the data and create label and output to form
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
                rank.Parent = plBackground;
                name.Parent = plBackground;
                score.Parent = plBackground;
                time.Parent = plBackground;
                i++;
            }
        }

        private void createScoreboard2p(List<string[]> s) {
            pbChart.Hide();

            //create header for two player mode score board
            Label lblRank = createLabel(65, 55, "Rank");
            Label lblName = createLabel(350, 55, "Details");
            Label lblScore = createLabel(635, 55, "Winner");

            //add header to form
            this.Controls.Add(lblRank);
            this.Controls.Add(lblName);
            this.Controls.Add(lblScore);
            lblRank.Parent = plBackground;
            lblName.Parent = plBackground;
            lblScore.Parent = plBackground;
            
            //variables for create label for two player mode
            int i = 1;
            int stackX = 65;
            int sX = 100;
            int stackY = 100;
            int sY = 38;

            //loop through all the data and create label and output to form
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
                rank.Parent = plBackground;
                name.Parent = plBackground;
                score.Parent = plBackground;
                i++;
            }
        }

        private void removeLabels() {
            //making panel invisible and then clear can get better performance
            plBackground.Visible = false;

            //change all the "button" parent to form to prevent from delete
            pb1pEasy.Parent = this;
            pb1pHard.Parent = this;
            pb2p.Parent = this;
            pbMenu.Parent = this;
            pbChart.Parent = this;

            //clear all label in the panel
            plBackground.Controls.Clear();
            
            //assign all "button" back to panel
            pb1pEasy.Parent = plBackground;
            pb1pHard.Parent = plBackground;
            pb2p.Parent = plBackground;
            pbMenu.Parent = plBackground;
            pbChart.Parent = plBackground;

            //make panel visible
            plBackground.Visible = true;
        }

        //function to create label
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
