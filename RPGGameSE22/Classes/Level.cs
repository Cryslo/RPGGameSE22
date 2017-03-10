using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPGGameSE22.Properties;

namespace RPGGameSE22.Classes
{
    class Level
    {
        private int mapWidth;
        private int mapHeight;
        private PictureBox[] floortiles;
        ResourceManager rm = Resources.ResourceManager;
        private Form1 form;
        private Endgoal endgoal;

        public Level(int mapWidth, int mapHeight, Form1 form)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.form = form;

            CreateEndGoal();
            CreatePowerup(new Point(mapHeight, mapHeight));
            floortiles = new PictureBox[mapWidth*mapHeight];
            GenerateMap();
        }

        private void GenerateMap()
        {
            Console.WriteLine("Drawmap");
            for (int i = 0; i < mapHeight; i++)
            {
                for (int j = 0; j < mapWidth; j++)
                {
                    floortiles[j] = new PictureBox();
                    floortiles[j].Image = Resources.floortile;
                    floortiles[j].Visible = true;
                    floortiles[j].Width = 75;
                    floortiles[j].Height = 75;
                    floortiles[j].Location = new Point(75*j, 75*i);
                    floortiles[j].SizeMode = PictureBoxSizeMode.StretchImage;
                    form.Controls.Add(floortiles[j]);
                }
            }
        }

        private void CreateEndGoal()
        {
            Random r = new Random();
            int x = r.Next(0, mapWidth*75);
            int y = r.Next(0, mapHeight*75);

            endgoal = new Endgoal(new Point(x,y), form);
        }

        private void CreatePowerup(Point loc)
        {

            Powerup powerpup = new Powerup(loc);
        }
    }
}
