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
    public class Level
    {
        private int mapWidth;
        private int mapHeight;
        private PictureBox[,] floortiles;
        ResourceManager rm = Resources.ResourceManager;
        private Form1 form;
        private Endgoal endgoal;
        public Powerup powerup;

        public Level(int mapWidth, int mapHeight, Form1 form)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.form = form;

            Random r = new Random();
            CreateEndGoal(r.Next(0, mapWidth * 75), r.Next(0, mapHeight * 75));
            CreatePowerup(r.Next(0, mapWidth * 75), r.Next(0, mapHeight * 75));
            GenerateMap();
        }

        public int MapWidth
        {
            get { return mapWidth; }
            set { mapWidth = value; }
        }

        public int MapHeight
        {
            get { return mapHeight; }
            set { mapHeight = value; }
        }

        public PictureBox[,] Floortiles
        {
            get { return floortiles; }
            set { floortiles = value; }
        }

        public Form1 Form2
        {
            get { return form; }
            set { form = value; }
        }

        private void GenerateMap()
        {
            floortiles = new PictureBox[mapWidth, mapHeight];
            Console.WriteLine("Drawmap");
            for (int i = 0; i < mapHeight; i++)
            {
                for (int j = 0; j < mapWidth; j++)
                {
                    floortiles[i,j] = new PictureBox();
                    floortiles[i,j].Image = Resources.floortile;
                    floortiles[i,j].Visible = true;
                    floortiles[i, j].Width = 75;
                    floortiles[i, j].Height = 75;
                    floortiles[i, j].Location = new Point(75*j, 75*i);
                    floortiles[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    form.Controls.Add(floortiles[i, j]);
                }
            }
        }

        private void CreateEndGoal(int x, int y)
        {

            endgoal = new Endgoal(new Point(x,y), form);
        }

        private void CreatePowerup(int x, int y)
        {
            powerup = new Powerup(new Point(x,y), form);
        }
    }
}
