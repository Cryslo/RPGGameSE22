using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGGameSE22.Classes
{
    public class WorldObject
    {
        private Point location;
        private PictureBox goalimage;
        private Form1 form;
        public WorldObject(Point location, Form1 form)
        {
            this.location = location;
            this.form = form;
        }

        public Point Location
        {
            get { return location; }
        }

        public Form1 Form2
        {
            get { return form; }
        }
    }
}
