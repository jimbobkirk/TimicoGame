using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using TimicoGameLibrary.Objects.Items.Weapons;
using TimicoGameLibrary.Objects.Locations;

namespace TimicoGameLibrary.Objects.Characters
{
    public class Character : ICharacter
    {
        private Location location;
        private IWeapon weapon;
        int health = 100;
        int movementSpeed = 1;
        int maxHealth = 100;
        Color color;

        public void SetStats(int maxHealth, IWeapon weapon)
        {
            SetHealth(maxHealth);
            SetMaxHealth(maxHealth);
            SetWeapon(weapon);
        }

        public void SetWeapon(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public Location GetLocation()
        {
            return location;
        }

        public void SetLocation(int x, int y)
        {
            SetLocation(new Location(x, y));
        }

        public void SetLocation(Location location)
        {
            this.location = location;
        }

        public int GetHealth()
        {
            return health;
        }

        public void SetHealth(int health)
        {
            this.health = health;
        }

        public void SetMaxHealth(int health)
        {
            this.maxHealth = health;
        }

        public void ChangeHealth(int amountToChange)
        {
            this.health += amountToChange;
        }

        public void Move(int x, int y)
        {
            location.X += x * movementSpeed;
            location.Y += y * movementSpeed;
        }

        public int GetDamageToDeal()
        {
            return weapon.GetStrength();
        }

        public void SetColour(Color color)
        {
            this.color = color;
        }

        public Color GetColour()
        {
            return color;
        }
    }
}
