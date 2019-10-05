using System;
using System.Collections.Generic;
using System.Text;
using TimicoGameLibrary.Objects.Characters;
using TimicoGameLibrary.Objects.Locations;
using TimicoGameLibrary.Objects.Players;

namespace TimicoGameLibrary.Objects.Levels
{
    interface ILevel
    {
        Vector2D GetScale();
        void SetScale(int x, int y);
        Location GetPlayerStartLocation();
        void SetPlayerStartLocation(Location location);
        List<Character> GetEnemies();
    }
}
