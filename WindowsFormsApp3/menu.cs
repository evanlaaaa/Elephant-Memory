using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;

namespace StupidGame {
    public partial class menu : Form
    {
        private dialogName d;
        private Player p;
        private Player p2;
        private OnePlayerGamePlay gp;
        private TwoPlayersGamePlay gp2;
        private string name;
        private int diffi;
        private string theme;
        public menu()
        {
            AllocConsole();
            InitializeComponent();
        }

        //1 Players button event handler
        private void btn1p_Click(object sender, EventArgs e) {

            //Calling out dialogName
            using (d = new dialogName(1)) {

                //if user click ok on the dialog, save the name. Else do nothing
                if (d.ShowDialog() == DialogResult.OK) {

                    name = d.name;
                    p = new Player(name);

                    //if user click ok on the setting dialog, create object for deck and go to gameplay form
                    using (dialogGameSetting s = new dialogGameSetting()) {
                        if(s.ShowDialog() == DialogResult.OK) {
                            diffi = s.diffi;
                            theme = s.theme;
                            Deck ds;
                            if (diffi == 4) {
                                ds = new EasyDeck(theme);
                            } else {
                                ds = new HardDeck(theme);
                            }
                            gp = new OnePlayerGamePlay(p, ds);

                            //assign game play form closing event handler
                            gp.FormClosing += GameClosing;
                            
                            this.Hide();
                            gp.Show();
                        }
                    }
                }
            }
        }

        //2 Players button event handler
        private void btn2p_Click(object sender, EventArgs e) {

            //Calling out dialogName (first player)
            using (d = new dialogName(1)) {
                if (d.ShowDialog() == DialogResult.OK) {
                    name = d.name;
                    p = new Player(name);

                    //Calling out dialogName (second player)
                    using (d = new dialogName(2)) {
                        if (d.ShowDialog() == DialogResult.OK) {
                            name = d.name2;
                            p2 = new Player(name);

                            //Calling out game setting dialog
                            using (dialogGameSetting s = new dialogGameSetting(true)) {
                                if (s.ShowDialog() == DialogResult.OK) {
                                    diffi = s.diffi;
                                    theme = s.theme;
                                    Deck ds = new HardDeck(theme);
                                    gp2 = new TwoPlayersGamePlay(p, p2, ds);

                                    //assign game play form closing event handler
                                    gp2.FormClosing += GameClosing;

                                    gp2.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                }
            }
        }

        //scoreboard button event handler
        private void btnScore_Click(object sender, EventArgs e) {
            ScoreBoard sb = new ScoreBoard();
            sb.FormClosing += GameClosing;
            sb.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        //show menu when another form is closing
        private void GameClosing(object sender, FormClosingEventArgs e) {
             this.Show();
        }

        //
        //hover
        //
        private void btn1p_MouseEnter(object sender, EventArgs e) {
            btn1p.BackgroundImage = Properties.Resources.s1p;
        }
        private void btn1p_MouseLeave(object sender, EventArgs e) {
            btn1p.BackgroundImage = Properties.Resources.onep;
        }

        private void btn2p_MouseEnter(object sender, EventArgs e) {
            btn2p.BackgroundImage = Properties.Resources.s2p;
        }
        private void btn2p_MouseLeave(object sender, EventArgs e) {
            btn2p.BackgroundImage = Properties.Resources.twop;
        }

        private void btnScore_MouseEnter(object sender, EventArgs e) {
            btnScore.BackgroundImage = Properties.Resources.ssb;
        }
        private void btnScore_MouseLeave(object sender, EventArgs e) {
            btnScore.BackgroundImage = Properties.Resources.sb;
        }

        private void btnExit_MouseEnter(object sender, EventArgs e) {
            btnExit.BackgroundImage = Properties.Resources.sexit;
        }
        private void btnExit_MouseLeave(object sender, EventArgs e) {
            btnExit.BackgroundImage = Properties.Resources.exit;
        }

        //debug
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        static extern bool AllocConsole(); 
    }
}
