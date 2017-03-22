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
    public class Powerup : WorldObject
    {
        private PictureBox goalimage;
        private Rectangle intersectangle;

        public Powerup(Point location, Form1 form) : base (location, form)
        {
            SpawnPowerup(location, form);
        }

        public PictureBox Goalimage
        {
            get { return goalimage; }
        }

        public Rectangle Intersectangle
        {
            get { return intersectangle; }
        }

        private void SpawnPowerup(Point location, Form1 form)
        {
            goalimage = new PictureBox();
            goalimage.Image = Resources.chest;
            goalimage.Width = 50;
            goalimage.Height = 50;
            goalimage.Location = new Point(location.X - goalimage.Width / 2, location.Y - goalimage.Height / 2);
            goalimage.SizeMode = PictureBoxSizeMode.StretchImage;
            intersectangle.Size = goalimage.Size;
            intersectangle.Location = goalimage.Location;
            form.Controls.Add(goalimage);
            goalimage.BringToFront();
        }

        private void GiveBonusPlayer()
        {
            
        }
    }
}
