using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGGameSE22.Classes
{
    class Character
    {
        private Point location;
        private int health;
        private PictureBox sprite;

        public Character(Point location, int health, PictureBox sprite)
        {
            this.location = location;
            this.health = health;
            this.sprite = sprite;
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
