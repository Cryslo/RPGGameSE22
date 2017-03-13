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
    class Player : Character
    {
        private string direction = "right";
        private PictureBox playerSprite;
        private Form1 form;

        public Player(Point location, int health, Form1 form, PictureBox sprite) : base (location, health, sprite)
        {
            this.form = form;
            playerSprite = sprite;
            CreateSprite();
        }

        private void CreateSprite()
        {
            playerSprite.Image = Resources.character;
            playerSprite.Location = Location;
            playerSprite.Width = 50;
            playerSprite.Height = 50;
            playerSprite.SizeMode = PictureBoxSizeMode.StretchImage;
            playerSprite.BackColor = Color.Transparent;
            form.Controls.Add(playerSprite);
            playerSprite.BringToFront();
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
                playerSprite.Location = new Point(playerSprite.Location.X + 5, playerSprite.Location.Y);
            }
            if (direction == "right")
            {
                playerSprite.Location = new Point(playerSprite.Location.X - 5, playerSprite.Location.Y);
            }
            if (direction == "up")
            {
                playerSprite.Location = new Point(playerSprite.Location.X, playerSprite.Location.Y + 5);
            }
            if (direction == "down")
            {
                playerSprite.Location = new Point(playerSprite.Location.X, playerSprite.Location.Y - 5);
            }
        }
    }
}
