using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGameSE22.Classes
{
    class World
    {
        private bool isPaused = false;
        List<Enemy> enemyList = new List<Enemy>();
        List<Level> levelList = new List<Level>();


        public World()
        {
            CreateLevel(50,50);
        }

        public void Update()
        {
            
        }

        private void CreateLevel(int width, int height)
        {
            Level level = new Level(width, height);
            levelList.Add(level);
        }

        private void AddPlayer(int x, int y)
        {
            Player player = new Player(new Point(x,y), 50);
        }

        private void AddEnemy(int x, int y)
        {
            Enemy enemy = new Enemy(new Point(x, y), 50);
            enemyList.Add(enemy);
        }
    }
}
