using System;
using System.Collections.Generic;
using System.Text;
using TimicoGameLibrary.Objects.Characters;
using TimicoGameLibrary.Objects.Locations;
using TimicoGameLibrary.Objects.Items.Weapons.EnemyWeapons;
using System.Drawing;

namespace TimicoGameLibrary.Objects.Enemies
{
    class Zombie : Character
    {
        public Zombie()
        {
            this.SetStats(100, new ZombieBite());
            this.SetColour(Color.Green);
        }
    }
}
