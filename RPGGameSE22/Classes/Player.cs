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
    public class Player : Character
    {
        private string direction = "right";
        

        public Player(Point location, int health, Form1 form, PictureBox sprite) : base (location, health, sprite, form)
        {
            CreateSprite();
        }

        public override void CreateSprite()
        {
            Sprite.Image = Resources.character;
            Sprite.Location = Location;
            Sprite.Width = 50;
            Sprite.Height = 50;
            Sprite.SizeMode = PictureBoxSizeMode.StretchImage;
            Sprite.BackColor = Color.Transparent;
            Form2.Controls.Add(Sprite);
            Sprite.BringToFront();
        }

        public string Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        public void MovePlayer(string direction)
        {
            if (direction == "left")
            {
                Sprite.Location = new Point(Sprite.Location.X - 5, Sprite.Location.Y);
            }
            if (direction == "right")
            {
                Sprite.Location = new Point(Sprite.Location.X + 5, Sprite.Location.Y);
            }
            if (direction == "up")
            {
                Sprite.Location = new Point(Sprite.Location.X, Sprite.Location.Y - 5);
            }
            if (direction == "down")
            {
                Sprite.Location = new Point(Sprite.Location.X, Sprite.Location.Y + 5);
            }
        }
    }
}
