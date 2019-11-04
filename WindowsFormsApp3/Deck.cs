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
    public class Deck {     
        private List<Card> inDeck;
        private List<PictureBox> inDeckPB;
        private List<List<int>> mapped;
        protected int d;
        protected string t;
        protected string backURL;
        protected string themeURL;
        protected int defaultX;
        protected int defaultY;
        protected int defaultW;
        protected int defaultH;
        protected int nsX;
        protected int nsY;
        protected const int sX = 108;
        protected const int sY = 133;

        public delegate void CardClick(Card card);
        
        public Deck() {
            backURL = "..\\..\\resource\\";
        }

        public void GenerateDeck(gamePlay x, CardClick onCardClick, PictureBox parent) {
            inDeck = new List<Card>(d*d);
            inDeckPB = new List<PictureBox>(d * d);
            
            //Create cards. The number of cards depend on the difficulty
            //Loop half of the total number of cards, because it create two same card_index cards at the same time
            //Also assign image to card
            for (int i = 0; i < d*d/2; i++) {
                Card card = new Card(i, Image.FromFile(themeURL + (i + 1) + ".png"));
                Card card2 = new Card(i, Image.FromFile(themeURL + "w" + (i + 1) + ".png"));
                inDeck.Add(card);
                inDeck.Add(card2);
            }

            //Create picturebox. The size of picturebox and location is depends on the Deck Mode(hard and easy)
            //Hard: Card size will be smaller, and padding of each cards also smaller
            //Easy: Card size will be larger, and padding of each cards also larger
            int stackY = defaultY;
            for (int i = 0; i < d; i++) {
                int stackX = defaultX;
                for (int j = 0; j < d; j++) {
                    PictureBox pb;
                    pb = createPictureBox(i, j, stackX, stackY, parent);                         
                    inDeckPB.Add(pb);
                    stackX += nsX;
                }
                stackY += nsY;
            }

            //Call function to suffle the order of list of cards
            ShuffleDeck();

            //After done creating pictureboxes and cards, Assign picturebox to card
            //Also assign a event listener to picturebox
            for (int i = 0; i < inDeck.Count; i++) {
                Card currentCard = inDeck[i];
                currentCard.PB = inDeckPB[i];
                currentCard.PB.Click += (sender, args) => onCardClick(currentCard);        
                
                //render to the game play form
                x.Controls.Add(inDeckPB[i]);

                //make it blend to background
                currentCard.PB.Parent = parent;
            }
        }

        public PictureBox createPictureBox(int i, int j, int x, int y, PictureBox parent) {          
            return new PictureBox {
                Name = "pbImg" + (d * i + j),
                Size = new Size(defaultW, defaultH),
                Location = new Point(x, y),
                Image = Image.FromFile(backURL + "\\back1.png"),
                Tag = d * i + j,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent
            };
        }

        public void ShuffleDeck() {
            //randomize the order in inDeck
            var rand = new Random();
            inDeck = inDeck.OrderBy(x => rand.Next()).ToList();

            //debug method, ignore this (creating answer and ready to display on console)
            cardMapping();
        }
        
        public List<Card> Cards {
            get {
                return inDeck;
            }
        }

        public int Difficulty {
            get {
                return d;
            }
        }

        public List<List<int>> Map {
            get {
                return mapped;
            }
        }

        //Debug method (sorting the answer to 4x4 or 6x6);
        public void cardMapping() {
            mapped = new List<List<int>>(d);
            for (int i = 0; i < d; i++) {
                mapped.Add(new List<int>(d));
                for (int j = 0; j < d; j++) {
                    mapped[i].Add(inDeck[d * i + j].ID);
                }
            }
        }
    }
}
