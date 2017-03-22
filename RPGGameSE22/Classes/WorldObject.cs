using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGGameSE22.Classes
{
    public class WorldObject : IPickupable
    {
        private Point location;
        private PictureBox goalimage;
        private Form1 form;
        private bool _isPickedup;

        public WorldObject(Point location, Form1 form, bool isPickedup)
        {
            this.location = location;
            this.form = form;
            this._isPickedup = isPickedup;
        }

        public bool isPickedup { get { return _isPickedup; } set { _isPickedup = value; } }

        public Point Location
        {
            get { return location; }
        }

        public Form1 Form2
        {
            get { return form; }
        }

        public void pickUpInteraction()
        {
            
        }
    }
}
