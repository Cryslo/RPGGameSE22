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
        Random random = new Random();


        public World(Form1 form)
        {
            this.form = form;
            form.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            form.AutoSize = true;
            CreateLevel(10, 10);
        }

        public void Update()
        {
            foreach (Enemy enemy in enemyList)
            {
                enemy.RandomMovement();
            }
        }

        private void CreateLevel(int width, int height)
        {
            Level level = new Level(width, height, form);
            levelList.Add(level);
            AddPlayer(50,50);
            AddEnemy(250,250);
            AddEnemy(100, 250);
        }

        private void AddPlayer(int x, int y)
        {
            Player player = new Player(new Point(x,y), 50, form, new PictureBox());
        }

        private void AddEnemy(int x, int y)
        {
            Enemy enemy = new Enemy(new Point(x, y), 50, new PictureBox(), form, random);
            enemyList.Add(enemy);
        }
    }
}
