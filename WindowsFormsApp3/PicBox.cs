using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;

namespace WindowsFormsApp3 {
    class PicBox {
        PictureBox current;
        List<PictureBox> lpb;
        Deck ds;
        private int i = 1;
        private int cons;
        private int defaultX;
        private int defaultY;
        private int defaultW;
        private int defaultH;
        private int nsX;
        private int nsY;
        const int sX = 108;
        const int sY = 133;

        public PicBox(Deck ds){
            this.ds = ds;
            if (ds.Difficulty == 4) {
                defaultX = 12;
                defaultY = 12;
                defaultW = 82;//+ 50;
                defaultH = 115;// + 50;
                nsX = sX - 5;// + 50;
                nsY = sY;// + 50;
            }
            else {
                defaultX = 12;
                defaultY = 12;
                defaultW = 82 - 30;
                defaultH = 115 - 35;
                nsX = sX - 40;
                nsY = sY - 45;
            }
        }

        public void createPictureBox(gamePlay x) {
            lpb = new List<PictureBox>(ds.Difficulty * ds.Difficulty);
            int stackY = defaultY;
            for (int i = 0; i < ds.Difficulty; i++) {
                int stackX = defaultX;
                for (int j = 0; j < ds.Difficulty; j++) {
                    PictureBox picture = new PictureBox {
                        Name = "pbImg" + (ds.Difficulty * i + j),
                        Size = new Size(defaultW, defaultH),
                        Location = new Point(stackX, stackY),
                        Image = Image.FromFile(@"..\..\resource\back1.png"),
                        Tag = ds.Difficulty * i + j
                    };
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    lpb.Add(picture);
                    x.Controls.Add(picture);
                    stackX += nsX;
                }
                stackY += nsY;
            }
        }

        
    }
}
