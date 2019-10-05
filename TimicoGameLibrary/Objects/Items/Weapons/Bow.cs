using System;
using System.Collections.Generic;
using System.Text;

namespace TimicoGameLibrary.Objects.Items.Weapons
{
    class Bow : IWeapon
    {
        public string GetName()
        {
            return "Bow";
        }

        public int GetValue()
        {
            return 1;
        }

        public int GetAmount()
        {
            return 0;
        }

        public int GetStrength()
        {
            return 10;
        }

        public int GetAttackRange()
        {
            return 20;
        }
    }
}
