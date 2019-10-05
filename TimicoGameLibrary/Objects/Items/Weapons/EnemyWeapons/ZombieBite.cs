using System;
using System.Collections.Generic;
using System.Text;

namespace TimicoGameLibrary.Objects.Items.Weapons.EnemyWeapons
{
    class ZombieBite : IWeapon
    {
        public int GetAmount()
        {
            return 0;
        }

        public int GetAttackRange()
        {
            return 5;
        }

        public string GetName()
        {
            return "Zombie Bite";
        }

        public int GetStrength()
        {
            return 5;
        }

        public int GetValue()
        {
            return 0;
        }
    }
}
