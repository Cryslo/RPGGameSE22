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
        private PictureBox[] floortilesX;
        private PictureBox[] floortilesY;

        public Level(int mapWidth, int mapHeight)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;

            CreateEndGoal(new Point(mapWidth, mapHeight));
            CreatePowerup(new Point(mapHeight, mapHeight));
        }

        private void GenerateMap()
        {
            
        }

        private void CreateEndGoal(Point loc)
        {
            Powerup powerpup = new Powerup(loc);
        }

        private void CreatePowerup(Point loc)
        {
            Endgoal endgoal = new Endgoal(loc);
        }
    }
}
