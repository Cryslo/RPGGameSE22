using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPGGameSE22.Classes;
using System.Windows.Forms;

namespace RPGGameSE22
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Player player = new Player(new Point(50,50), 50, new Form1(), new PictureBox());
            Assert.AreEqual(new Point(50,50), player.Location, "location is incorrect");
            Assert.AreEqual(50, player.Health, "Health is incorrect");
            Assert.IsNotNull(player.Sprite, "sprite is incorrect");

            Random r = new Random();
            Enemy enemy = new Enemy(new Point(50, 50), 50, new PictureBox(), new Form1(), r);
            Assert.AreEqual(new Point(50, 50), enemy.Location, "location is incorrect");
            Assert.AreEqual(50, enemy.Health, "Health is incorrect");
            Assert.IsNotNull(enemy.Sprite, "sprite is incorrect");
            

            Level level = new Level(200, 200, new Form1());
            Assert.AreEqual(200, level.MapWidth, "levelwidth is incorrect");
            Assert.AreEqual(200, level.MapHeight, "levelheight is incorrect");
            Assert.IsNotNull(level.Form2, "Form is empty");
            Assert.IsNotNull(level.Floortiles, "levelheight is incorrect");

        }
    }
}
