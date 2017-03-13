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
    class Enemy : Character
    {
        private string direction = "left";
        private PictureBox sprite;
        private Form1 form;
        private float directionTimer = 0;
        private int rnmbr;
        private Random random;

        public Enemy(Point location, int health, PictureBox sprite, Form1 form, Random random) : base (location, health, sprite)
        {
            this.sprite = sprite;
            this.form = form;
            this.random = random;
            CreateSprite();
        }

        public string Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        private void CreateSprite()
        {
            sprite.Image = Resources.Ahriman_398;
            sprite.Location = Location;
            sprite.Width = 50;
            sprite.Height = 50;
            sprite.SizeMode = PictureBoxSizeMode.StretchImage;
            sprite.BackColor = Color.Transparent;
            form.Controls.Add(sprite);
            sprite.BringToFront();
        }

        public void RandomMovement()
        {
            directionTimer++;
            if (directionTimer >= 10)
            {
                rnmbr = random.Next(0, 4);
                directionTimer = 0;
            }
            if (sprite.Location.X < 10)
            {
                rnmbr = 1;
            }
            if (sprite.Location.X > form.Width)
            {
                rnmbr = 0;
            }
            if (sprite.Location.Y > form.Height)
            {
                rnmbr = 3;
            }
            if (sprite.Location.Y < 10)
            {
                rnmbr = 2;
            }

            if (rnmbr == 0)
            {
                sprite.Location = new Point(sprite.Location.X - 5, sprite.Location.Y);
            }
            if (rnmbr == 1)
            {
                sprite.Location = new Point(sprite.Location.X + 5, sprite.Location.Y);
            }
            if (rnmbr == 2)
            {
                sprite.Location = new Point(sprite.Location.X, sprite.Location.Y + 5);
            }
            if (rnmbr == 3)
            {
                sprite.Location = new Point(sprite.Location.X, sprite.Location.Y - 5);
            }
        }

        private void AttackPlayer(Player player)
        {
            
        }
    }
}
