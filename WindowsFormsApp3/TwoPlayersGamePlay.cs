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
    public partial class TwoPlayersGamePlay : StupidGame.gamePlay {
        SortedSet<int> seen = new SortedSet<int>();
        public TwoPlayersGamePlay() {
            InitializeComponent();
        }

        public TwoPlayersGamePlay(Player p, Player p2, Deck ds, menu m) {
            InitializeComponent();
            this.ds = ds;
            this.p = p;
            this.m = m;
            this.p2 = p2;
            ds.GenerateDeck(this, picClick, pbCardsBackground);

            preventClick = true;
            animateOpening.Start();
            animateCloseTimer.Start();
            lblPlayer1Name.Text = p.Name;
            lblScore.Text = p.Score.ToString();
            lblPlayer2Name.Text = p2.Name;
            lblScore2.Text = p2.Score.ToString();

            lblPlayer2Name.Font = new Font(pfc.Families[0], 28, FontStyle.Regular);
            lbls.Font = new Font(pfc.Families[0], 22, FontStyle.Regular);
            lblScore2.Font = new Font(pfc.Families[0], 22, FontStyle.Regular);
            panelP2.BackColor = Color.FromArgb(100, 0, 0, 0);
            lblPlayer2Name.BackColor = Color.FromArgb(100, 0, 0, 0);
            lbls.BackColor = Color.FromArgb(100, 0, 0, 0);
            lblScore2.BackColor = Color.FromArgb(100, 0, 0, 0);


            //for debug purpose (show answer to console)
            foreach (List<int> ww in ds.Map) {
                foreach (int y in ww) {
                    Console.Write(y + " ");
                }
                Console.WriteLine("");
            }
        }

        //There will be a bool variable to identify whose turn
        public override async void picClick(Card card) {
            //if card is flipped or in the middle of animation, stop the function
            if (card.isFlipped || preventClick)
                return;

            //flip card *(for details please see card class)
            card.flipCard();

            //if currentCard is null, which mean its the 'first' flipped card', save to a temp variable
            if (currentCard == null)
                currentCard = card;

            //if two are different cards
            if (currentCard != card) {
                //check if both cards have the same index, if yes = found
                if (currentCard.ID == card.ID) {
                    //check currently whose turn, then pass player object to scoreProcess
                    if (!playerTwoTurn)
                        scoreProcess(p, true, lblScore, -1);
                    else
                        scoreProcess(p2, true, lblScore2, -1);

                    foundPair++;
                } else {
                    //if both cards are not pair, pass current picturebox index to scoreProcess
                    if (!playerTwoTurn)
                        scoreProcess(p, false, lblScore, int.Parse(card.PB.Tag.ToString()));
                    else
                        scoreProcess(p2, false, lblScore2, int.Parse(card.PB.Tag.ToString()));

                    //save both picturebox index to a set
                    seen.Add(int.Parse(card.PB.Tag.ToString()));
                    seen.Add(int.Parse(currentCard.PB.Tag.ToString()));

                    //toggle player's turn
                    playerTwoTurn ^= true;

                    preventClick = true;
                    await Task.Delay(1000);
                    preventClick = false;
                    currentCard.flipCloseCard();
                    card.flipCloseCard();
                }
                currentCard = null;

                //check whether all cards are found
                if (foundPair == Math.Pow(ds.Difficulty, 2) / 2) {
                    using (w = new dialogWin(p, p2)) {
                        if (w.ShowDialog() == DialogResult.OK) {
                            db.saveScore(p, p2, p.Score, p2.Score);
                            this.Close();
                        }
                    }
                }
            }
        }

        public override void scoreProcess(Player x, bool isFound, Label l, int card_index) {
            if (isFound) {
                x.Score += 3000;
            } else {
                //score will be deduct 3000 instead of 1000 if any of the flipped card is flipped before. It is a penalty for player who keep flipping the same card for advantage
                if (seen.Contains(card_index) || seen.Contains(int.Parse(currentCard.PB.Tag.ToString())))
                    x.Score -= 3000;
                else
                    x.Score -= 1000;
            }

            //update the score label
            l.Text = x.Score.ToString();
        }
    }
}
