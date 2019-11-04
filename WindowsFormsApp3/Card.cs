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

namespace StupidGame {
    public class Card {
        private int CardID;
        private PictureBox pb;
        private Image img;
        public bool isFlipped { get; set; }

        public Card(int id, Image i) {
            this.img = i;
            this.CardID = id;
            this.isFlipped = false;
        }

        public void flipCard() {
            //toggle flip status
            isFlipped = true;

            //change its picturebox to animated gif
            pb.Image = Image.FromFile(@"..\..\resource\animatedBack.gif");

            //Timer to set the picturebox to card image after the gif done one period of animation
            System.Timers.Timer animateFlipTime = new System.Timers.Timer();
            animateFlipTime.Elapsed += (sender2, e2) => flipCardTimer(sender2, e2, animateFlipTime);
            animateFlipTime.Interval = 270;
            animateFlipTime.Enabled = true;
        }

        public void flipCardTimer(Object source, ElapsedEventArgs e, System.Timers.Timer t) {
            pb.Image = img;
            t.Stop();
        }

        public void flipCloseCard() {
            //toggle flip status
            isFlipped = false;

            //Timer to set the picturebox back to 'card back' image after the gif done one period of animation
            pb.Image = Image.FromFile(@"..\..\resource\animatedBackClose.gif");

            System.Timers.Timer animateFlipTime = new System.Timers.Timer();
            animateFlipTime.Elapsed += (sender2, e2) => flipCloseCardTimer(sender2, e2, animateFlipTime);
            animateFlipTime.Interval = 370;
            animateFlipTime.Enabled = true;
        }

        public void flipCloseCardTimer(Object source, ElapsedEventArgs e, System.Timers.Timer t) {
            pb.Image = Image.FromFile(@"..\..\resource\back1.png");
            t.Stop();
        }

        public int ID {
            get {
                return CardID;
            }
            set {
                CardID = value;
            }
        }

        public PictureBox PB {
            get {
                return pb;
            }
            set {
                pb = value;
            }
        }
    }
}
