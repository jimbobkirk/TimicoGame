using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimicoGame.Objects;
using TimicoGameLibrary.Objects.Levels;

namespace TimicoGameForm
{
    public partial class Form1 : Form
    {
        World world = new World();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Level1 level1 = new Level1();
            gameArea1.InitialiseLevel(world.levels.GetCurrentLevel(), world.player);
        }
    }
}
