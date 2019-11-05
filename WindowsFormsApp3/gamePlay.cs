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
using System.Drawing.Text;

namespace StupidGame {
    [TypeDescriptionProvider(typeof(AbstractControlDescriptionProvider<gamePlay, Form>))]
    public abstract partial class gamePlay : Form {
        protected int animateOpenTick = 0;
        protected int animateCloseTick = 0;
        protected int foundPair = 0;
        protected bool preventClick = false;
        protected bool playerTwoTurn = false;
        protected Card currentCard;       
        protected Deck ds;
        protected Player p;
        protected Player p2;
        protected dialogWin w;
        protected PrivateFontCollection pfc = new PrivateFontCollection();
        protected DB db = new DB();

        //different mode will need to handle picClick diffirently
        //if two player, it will need to identify whose turn is it
        //there will be also a different score processing between 1 player and 2 players mode
        public abstract void picClick(Card card);
        public abstract void scoreProcess(Player x, bool isFound, Label l, int card_index);

        public gamePlay() {
            InitializeComponent();
            pfc.AddFontFile("..\\..\\resource\\Chewy.ttf");

            //change controls backcolor to semi transparent
            panelP1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panelBtnBack.BackColor = Color.FromArgb(100, 0, 0, 0);
            lblPlayer1Name.BackColor = Color.FromArgb(100, 0, 0, 0);
            lblTextScore.BackColor = Color.FromArgb(100, 0, 0, 0); 
            lblScore.BackColor = Color.FromArgb(100, 0, 0, 0);

            //add custom font to label
            lblPlayer1Name.Font = new Font(pfc.Families[0], 28, FontStyle.Regular);
            lblTextScore.Font = new Font(pfc.Families[0], 22, FontStyle.Regular);
            lblScore.Font = new Font(pfc.Families[0], 22, FontStyle.Regular);
        }

        //
        //Card flip animation + Opening
        //
        private void animateOpening_Tick(object sender, EventArgs e) {       
            //flip current card for each tick
            ds.Cards[animateOpenTick].flipCard();
            animateOpenTick++;

            //if last card then stop the timer
            if(animateOpenTick == (ds.Difficulty*ds.Difficulty)) {
                animateOpening.Stop();
            }
        }

        private void animateCloseTimer_Tick(object sender, EventArgs e) {
            //after 2 second, start the closing card flip timer
            animateClosing.Start();
            animateCloseTimer.Stop();
        }

        private void animateClosing_Tick(object sender, EventArgs e) {
            //close current card
            ds.Cards[animateCloseTick].flipCloseCard();
            animateCloseTick++;

            //if last card then stop the timer and toggle preventClick to let player start to play
            if (animateCloseTick == (ds.Difficulty * ds.Difficulty)) {
                animateClosing.Stop();
                preventClick = false;
            }
        }

        //
        //Buttons
        //
        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnRule_Click(object sender, EventArgs e) {
            dialogRules dr = new dialogRules();
            dr.Show();
        }

        //
        //Hover buttons
        //
        private void btnRule_MouseEnter(object sender, EventArgs e) {
            btnRule.Top += 1;
            btnRule.Left += 1;
            btnRule.BackgroundImage = Properties.Resources.srule;
        }
        private void btnRule_MouseLeave(object sender, EventArgs e) {
            btnRule.Top -= 1;
            btnRule.Left -= 1;
            btnRule.BackgroundImage = Properties.Resources.rule;
        }

        private void btnMenu_MouseEnter(object sender, EventArgs e) {
            btnMenu.Top += 1;
            btnMenu.Left += 1;
            btnMenu.BackgroundImage = Properties.Resources.smenu;
        }
        private void btnMenu_MouseLeave(object sender, EventArgs e) {
            btnMenu.Top -= 1;
            btnMenu.Left -= 1;
            btnMenu.BackgroundImage = Properties.Resources.menu;
        }
    }
}
