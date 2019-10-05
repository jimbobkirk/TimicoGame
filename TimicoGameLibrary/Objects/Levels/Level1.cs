using System;
using System.Collections.Generic;
using System.Text;
using TimicoGameLibrary.Objects.Characters;
using TimicoGameLibrary.Objects.Enemies;
using TimicoGameLibrary.Objects.Locations;

namespace TimicoGameLibrary.Objects.Levels
{
    //for a future version, add some kind of level creation, even if just stored in a file.
    public class Level1 : Level
    {
        public Level1()
        {
            this.SetScale(10, 10);
            SetPlayerStartLocation(new Location(5, 5));
            List<Character> characters = new List<Character>();
            Zombie zombie1 = new Zombie();
            Zombie zombie2 = new Zombie();
            Zombie zombie3 = new Zombie();
            Zombie zombie4 = new Zombie();
            zombie1.SetLocation(new Location(0, 0));
            zombie2.SetLocation(new Location(9, 0));
            zombie3.SetLocation(new Location(0, 9));
            zombie4.SetLocation(new Location(9, 9));
            characters.Add(zombie1);
            characters.Add(zombie2);
            characters.Add(zombie3);
            characters.Add(zombie4);
            this.SetEnemies(characters);
        }
    }
}
