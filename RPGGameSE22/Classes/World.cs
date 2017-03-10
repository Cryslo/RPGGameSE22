using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGGameSE22.Classes
{
    class World
    {
        private bool isPaused = false;
        List<Enemy> enemyList = new List<Enemy>();
        List<Level> levelList = new List<Level>();
        private Form1 form;


        public World(Form1 form)
        {
            this.form = form;
            CreateLevel(10,10);
        }

        public void Update()
        {

        }

        private void CreateLevel(int width, int height)
        {
            Level level = new Level(width, height, form);
            levelList.Add(level);
            AddPlayer(50,50);
        }

        private void AddPlayer(int x, int y)
        {
            Player player = new Player(new Point(x,y), 50, form);
        }

        private void AddEnemy(int x, int y)
        {
            Enemy enemy = new Enemy(new Point(x, y), 50);
            enemyList.Add(enemy);
        }
    }
}
