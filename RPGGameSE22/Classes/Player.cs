using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGameSE22.Classes
{
    class Player : Character
    {
        private string direction = "right";

        public Player(Point location, int health) : base (location, health)
        {
        }

        public string Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        public void MovePlayer()
        {
            
        }
    }
}
