using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGameSE22.Classes
{
    class Enemy : Character
    {
        private string direction = "left";

        public Enemy(Point location, int health) : base (location, health)
        {

        }

        public string Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        private void RandomMovement()
        {
            
        }

        private void AttackPlayer(Player player)
        {
            
        }
    }
}
