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
        public Form1()
        {
            InitializeComponent();
            world = new World(this);
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            world.Update();
            Console.WriteLine("tick");
        }
    }
}
