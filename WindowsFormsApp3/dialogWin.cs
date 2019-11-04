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
    public partial class dialogWin : Form {
        public dialogWin(Player p) {
            InitializeComponent();
            lblMessage.Text = "Congratulations " + p.Name + ", \r\nYou win the game with " + p.Score + " scores!";
        }
        public dialogWin(Player p, Player p2) {
            InitializeComponent();
            if (p.Score > p2.Score)
                lblMessage.Text = "Congratulations " + p.Name + ", \r\nYou win the game with " + p.Score + " scores!";
            else
                lblMessage.Text = "Congratulations " + p2.Name + ", \r\nYou win the game with " + p2.Score + " scores!";
        }
    }
}
