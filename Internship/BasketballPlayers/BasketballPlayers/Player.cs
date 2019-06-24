using System;
using System.Collections.Generic;
using System.Text;

namespace BasketballPlayers
{
    class Player
    {
       private string name;
       private short playingSince;
       private string position;
       private short rating;

        public String Name {
            get { return this.name; }
            set { this.name = value; }

        }

        public short PlayingSince {
            get { return this.playingSince; }
            set { this.playingSince = value; }
        }

        public String Position {
            get { return this.position; }
            set { this.position = value; }
        }
        

        public short Rating {
            get { return this.rating; }
            set { this.rating = value; }
        }
        public  Player(string name,short playingSince, string position,short rating) {
            this.name = name;
            this.playingSince = playingSince;
            this.position = position;
            this.rating = rating;
        }

        public Player() { }

    }
}
