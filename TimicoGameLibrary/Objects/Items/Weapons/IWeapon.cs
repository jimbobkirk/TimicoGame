using System;
using System.Collections.Generic;
using System.Text;
using TimicoGame.Objects.Items;

namespace TimicoGameLibrary.Objects.Items.Weapons
{
    public interface IWeapon : IItem
    {
        int GetStrength();
        int GetAttackRange();
    }
}
