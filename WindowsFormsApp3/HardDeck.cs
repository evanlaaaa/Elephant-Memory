using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidGame {
    class HardDeck : Deck {
        public HardDeck(string t) {
            d = 6;
            defaultX = 12;
            defaultY = 12;
            defaultW = 82 - 25;
            defaultH = 115 - 35;
            nsX = sX - 41;
            nsY = sY - 45;
            themeURL = "..\\..\\resource\\" + t + "\\";
        }
    }
}
