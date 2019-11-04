using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidGame {
    class EasyDeck : Deck{
        public EasyDeck(string t) {
            d = 4;
            defaultX = 13;
            defaultY = 13;
            defaultW = 82;
            defaultH = 115;
            nsX = sX - 5;
            nsY = sY;
            themeURL = "..\\..\\resource\\" + t + "\\";
        }
    }
}
