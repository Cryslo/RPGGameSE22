using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPGGameSE22.Classes;

namespace RPGGameSE22
{
    public partial class Form1 : Form
    {
        private World world;
        private string keyPressed = "";
        public Form1()
        {
            InitializeComponent();
            world = new World(this);
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            //world.Update(keyPressed);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                keyPressed = "left";
            }
            else if (e.KeyCode == Keys.D)
            {
                keyPressed = "right";
            }
            else if (e.KeyCode == Keys.W)
            {
                keyPressed = "up";
            }
            else if (e.KeyCode == Keys.S)
            {
                keyPressed = "down";
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.D || e.KeyCode == Keys.W || e.KeyCode == Keys.S)
            {
                keyPressed = "";
            }
        }
    }
}
