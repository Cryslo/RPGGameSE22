using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
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

        public PictureBox[,] FloorTiles { get; }

        public Level(int mapWidth, int mapHeight, Form1 form)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.form = form;

            Random r = new Random();
            CreateEndGoal(r.Next(0, mapWidth * 50), r.Next(0, mapHeight * 50));
            CreatePowerup(r.Next(0, mapWidth * 50), r.Next(0, mapHeight * 50));
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

        private PictureBox makeFloor()
        {
            PictureBox floor = new PictureBox();
            floor.Image = Resources.floortile;
            floor.Image.Tag = "floor";
            floor.Visible = true;
            floor.Width = 50;
            floor.Height = 50;
            floor.SizeMode = PictureBoxSizeMode.StretchImage;
            return floor;
        }
        private PictureBox makeWall()
        {
            PictureBox wall = new PictureBox();
            wall.Image = Resources.floortile;
            wall.Image.Tag = "floor";
            wall.Visible = true;
            wall.Width = 50;
            wall.Height = 50;
            wall.SizeMode = PictureBoxSizeMode.StretchImage;
            return wall;
        }
        private void GenerateMap()
        {
            List<string> mapList = new List<string>();
            mapList = FileAccess.GetMap();
            floortiles = new PictureBox[7, 7];
            Console.WriteLine("Drawmap");
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    PictureBox pb = new PictureBox();
                    if (mapList[i] == "wall" || mapList[j] == "wall")
                    {
                        pb.Image = Resources.walltile;
                    }
                    else if (mapList[i] == "floor" || mapList[j] == "floor")
                    {
                        pb.Image = Resources.floortile;
                    }
                    pb.Image.Tag = "floor";
                    pb.Visible = true;
                    pb.Width = 50;
                    pb.Height = 50;
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Location = new Point(50 * j, 50 * i);
                    floortiles[i, j] = pb;
                    form.Controls.Add(pb);
                }
            }
            MessageBox.Show(mapList[0]);
        }
        /*
                    floortiles[i,j] = new PictureBox();
                    floortiles[i,j].Image = Resources.floortile;
                    floortiles[i,j].Visible = true;
                    floortiles[i, j].Width = 75;
                    floortiles[i, j].Height = 75;
                    floortiles[i, j].Location = new Point(75*j, 75*i);
                    floortiles[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    form.Controls.Add(floortiles[i, j]);
                    */
        private void CreateEndGoal(int x, int y)
        {

            endgoal = new Endgoal(new Point(x,y), form, false);
        }

        private void CreatePowerup(int x, int y)
        {
            powerup = new Powerup(new Point(x,y), form, false);
        }
    }
}
