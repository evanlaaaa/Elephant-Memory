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
    public partial class dialogRules : Form {
        public dialogRules() {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
