using System;
using System.Collections.Generic;
using System.Text;

namespace TimicoGameLibrary.Objects.Items.Weapons
{
    class Sword : IWeapon
    {
        public string GetName()
        {
            return "Sword";
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
            return 40;
        }

        public int GetAttackRange()
        {
            return 5;
        }
    }
}
