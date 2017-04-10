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
        private Level level;
        private Form1 form;
        Random random = new Random();

        private Player player;
        private string keyPressed = "";
        private int keyPressedTimer = 0;


        public World(Form1 form)
        {
            this.form = form;
            form.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            form.AutoSize = true;
            CreateLevel(10, 10);
        }

        public void Update(string keypressed)
        {
            this.keyPressed = keypressed;
            foreach (Enemy enemy in enemyList)
            {
                enemy.RandomMovement();
            }
            if (levelList[0].powerup != null)
            {
                if (levelList[0].powerup.Intersectangle.IntersectsWith(player.Sprite.Bounds))
                {
                    levelList[0].powerup.RemovePowerup(form);
                    levelList[0].powerup = null;
                    this.keyPressed = "";
                    MessageBox.Show(FileAccess.GetLineFromText());
                }
            }
            //Move the player with the given key input
            if (keyPressedTimer == 0)
            {
                player.MovePlayer(keypressed);
                keyPressedTimer = 1;
            }
            if (keyPressedTimer > 0)
            {
                keyPressedTimer += 1;
                if (keyPressedTimer > 5)
                {
                    keyPressedTimer = 0;
                }
            }

        }

        private void CreateLevel(int width, int height)
        {
            level = new Level(width, height, form);
            levelList.Add(level);
            AddItem(50,50,"player");
            AddItem(250,250,"enemy");
            AddItem(100,250,"enemy");
        }

        private void AddItem(int x, int y, string type)
        {
            if (type == "enemy")
            {
                Enemy enemy = new Enemy(new Point(x, y), 50, new PictureBox(), form, random);
                enemyList.Add(enemy);
            }
            else if (type == "player")
            {
                player = new Player(new Point(x, y), 50, form, new PictureBox(), level);
            }
        }
    }
}
