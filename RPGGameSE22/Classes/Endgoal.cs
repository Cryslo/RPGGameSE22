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
    class Endgoal
    {
        private Point location;
        private PictureBox goalimage;
        private Form1 form;
        public Endgoal(Point location, Form1 form)
        {
            this.form = form;
            this.location = location;
            CreateGoal();
        }

        private void CreateGoal()
        {
            goalimage = new PictureBox();
            goalimage.Image = Resources.chest;
            goalimage.Width = 50;
            goalimage.Height = 50;
            goalimage.Location = new Point(location.X - goalimage.Width/2, location.Y - goalimage.Height/2);
            goalimage.SizeMode = PictureBoxSizeMode.StretchImage;
            form.Controls.Add(goalimage);
            goalimage.BringToFront();
        }
    }
}
