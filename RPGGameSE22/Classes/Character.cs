using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGameSE22.Classes
{
    class Character
    {
        private Point location;
        private int health;

        public Character(Point location, int health)
        {
            this.location = location;
            this.health = health;
        }

        public Point Location
        {
            get { return location; }
            set { location = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }
    }
}
