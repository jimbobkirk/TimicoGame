using System;
using System.Collections.Generic;
using System.Text;

namespace TimicoGameLibrary.Objects.Items.Weapons
{
    class Axe : IWeapon
    {
        public string GetName()
        {
            return "Axe";
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
            return 60;
        }

        public int GetAttackRange()
        {
            return 7;
        }
    }
}
