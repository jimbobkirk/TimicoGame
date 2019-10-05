using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using TimicoGameLibrary.Objects.Items.Weapons;
using TimicoGameLibrary.Objects.Locations;

namespace TimicoGameLibrary.Objects.Characters
{
    interface ICharacter
    {
        Location GetLocation();
        int GetHealth();
        int GetDamageToDeal();
        void SetHealth(int health);
        void ChangeHealth(int amountToChange);
        void SetWeapon(IWeapon weapon);
        void SetColour(Color color);
        Color GetColour();
        void Move(int x, int y);
    }
}
