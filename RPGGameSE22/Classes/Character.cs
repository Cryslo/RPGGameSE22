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
    public abstract class Character
    {
        private Point location;
        private int health;
        private PictureBox sprite;
        private Form1 form;

        public Character(Point location, int health, PictureBox sprite, Form1 form)
        {
            this.location = location;
            this.health = health;
            this.sprite = sprite;
            this.form = form;
        }

        public abstract void CreateSprite();

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

        public PictureBox Sprite
        {
            get { return sprite; }
            set { sprite = value; }
        }

        public Form1 Form2
        {
            get { return form; }
            set { form = value; }
        }
    }
}
