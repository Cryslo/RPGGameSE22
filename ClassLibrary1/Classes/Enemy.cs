using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPGGameSE22.Properties;

namespace RPGGameSE22.Classes
{
    public class Enemy : Character
    {
        private string direction = "left";
        private float directionTimer = 0;
        private int rnmbr;
        private Random random;

        public Enemy(Point location, int health, PictureBox sprite, Form1 form, Random random) : base (location, health, sprite, form)
        {
            this.random = random;
            CreateSprite();
        }

        public string Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        public override void CreateSprite()
        {
            Sprite.Image = Resources.Ahriman_398;
            Sprite.Location = Location;
            Sprite.Width = 50;
            Sprite.Height = 50;
            Sprite.SizeMode = PictureBoxSizeMode.StretchImage;
            Sprite.BackColor = Color.Transparent;
            Form2.Controls.Add(Sprite);
            Sprite.BringToFront();
        }

        public void RandomMovement()
        {
            directionTimer++;
            if (directionTimer >= 50)
            {
                rnmbr = random.Next(0, 4);
                directionTimer = 0;
            }
            if (Sprite.Location.X < 10)
            {
                rnmbr = 1;
            }
            if (Sprite.Location.X > Form2.Width)
            {
                rnmbr = 0;
            }
            if (Sprite.Location.Y > Form2.Height)
            {
                rnmbr = 3;
            }
            if (Sprite.Location.Y < 10)
            {
                rnmbr = 2;
            }

            if (rnmbr == 0)
            {
                Sprite.Location = new Point(Sprite.Location.X - 50, Sprite.Location.Y);
                rnmbr = 5;
            }
            else if (rnmbr == 1)
            {
                Sprite.Location = new Point(Sprite.Location.X + 50, Sprite.Location.Y);
                rnmbr = 5;
            }
            else if (rnmbr == 2)
            {
                Sprite.Location = new Point(Sprite.Location.X, Sprite.Location.Y + 50);
                rnmbr = 5;
            }
            else if (rnmbr == 3)
            {
                Sprite.Location = new Point(Sprite.Location.X, Sprite.Location.Y - 50);
                rnmbr = 5;
            }

        }

        private void AttackPlayer(Player player)
        {
            
        }
    }
}
