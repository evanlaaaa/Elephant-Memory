using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace StupidGame {
    public partial class OnePlayerGamePlay : StupidGame.gamePlay {
        DateTime timer = new DateTime();
        System.Windows.Forms.Timer Counter = new System.Windows.Forms.Timer();
        public OnePlayerGamePlay(){
            InitializeComponent();
        }

        public OnePlayerGamePlay(Player p, Deck ds, menu m) {
            this.ds = ds;
            this.p = p;
            this.m = m;
            ds.GenerateDeck(this, picClick, pbCardsBackground);

            pbCardsBackground.SendToBack();
            preventClick = true;
            animateOpening.Start();
            animateCloseTimer.Start();
            lblPlayer1Name.Text = p.Name;
            lblScore.Text = p.Score.ToString();
            Counter.Interval = 1000;
            Counter.Tick += new EventHandler(timer_Tick);

            //for debug purpose (show answer to console)
            foreach (List<int> ww in ds.Map) {
                foreach (int y in ww) {
                    Console.Write(y + " ");
                }
                Console.WriteLine("");
            }
        }

        //There is no need to check currently whose turn is it on single player mode
        public override async void picClick(Card card) { 
            //if card is flipped or in the middle of animation, stop the function
            if (card.isFlipped || preventClick)
                return;

            Counter.Start();

            //flip card *(for details please see card class)
            card.flipCard();

            //if currentCard is null, which mean its the 'first' flipped card', save to a temp variable
            if (currentCard == null)
                currentCard = card;

            //if two are different cards
            if (currentCard != card) {
                //check if both cards have the same index, if yes = found
                if (currentCard.ID == card.ID) {
                    scoreProcess(p, true, lblScore, -1);
                    foundPair++;
                } else {
                    scoreProcess(p, false, lblScore, -1);
                    preventClick = true;
                    await Task.Delay(1000);
                    preventClick = false;
                    currentCard.flipCloseCard();
                    card.flipCloseCard();
                }
                currentCard = null;

                //check whether all cards are found
                if (foundPair == Math.Pow(ds.Difficulty, 2) / 2) {
                    Counter.Stop();
                    using (w = new dialogWin(p)) {
                        if (w.ShowDialog() == DialogResult.OK) {
                            db.saveScore(p, p.Score, ds.Difficulty, timer);
                            this.Close();
                        }
                    }
                }
            }
        }

        public override void scoreProcess(Player x, bool isFound, Label l, int card_index) {
            if (isFound)
                x.Score += 3000;
            else
                x.Score -= 1000;

            //update the score label
            l.Text = x.Score.ToString();
        }

        private void timer_Tick(object sender, EventArgs e) {
            timer = timer.AddSeconds(1);
        }
    }
}
