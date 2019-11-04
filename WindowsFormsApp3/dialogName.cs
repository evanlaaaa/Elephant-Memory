using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StupidGame
{
    public partial class dialogName : Form
    {
        public string name;
        public string name2;
        private int player_index;
        public dialogName(int player_index)
        {
            this.player_index = player_index;
            InitializeComponent();
            lblMessage.Text = "What is your name? (Player " + player_index + ")";
        }

        private void btnNameOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 15) {
                lblWarning.Text = "Your name is too long";
                this.DialogResult = DialogResult.None;
            }
            else if(txtName.Text.Length == 0) {
                lblWarning.Text = "Enter a valid name";
                this.DialogResult = DialogResult.None;
            }
            else {
                if (player_index == 1)
                    name = txtName.Text;
                else
                    name2 = txtName.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnNameCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
