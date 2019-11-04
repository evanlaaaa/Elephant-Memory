using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidGame
{
    public class Player
    {
        private string name;
        private int score;

        public Player() {
            this.name = "";
            this.score = 0;
        }

        public Player(string name)
        {
            this.name = name;
            this.score = 0;
        }

        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        public int Score {
            get {
                return score;
            }
            set {
                score = value;
            }
        }

        public gamePlay gamePlay {
            get => default;
            set {
            }
        }
    }
}
