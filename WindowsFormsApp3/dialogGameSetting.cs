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
    public partial class dialogGameSetting : Form
    {
        public int diffi;
        public string theme;
        public dialogGameSetting()
        {
            InitializeComponent();
        }

        public dialogGameSetting(bool x) {
            InitializeComponent();
            if (x) {
                rbEasy.Enabled = false;
                rbNormal.Enabled = false;
                rbNormal.Checked = true;
            }
        }

        private void btnSettingOK_Click(object sender, EventArgs e) {
            diffi = (rbEasy.Checked) ? 4 : 6;
            theme = (rbAnimal.Checked) ? "Fruit" : "Shape";
        }
    }
}
