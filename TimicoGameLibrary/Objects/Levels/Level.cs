using System;
using System.Collections.Generic;
using System.Text;
using TimicoGameLibrary.Objects.Characters;
using TimicoGameLibrary.Objects.Locations;
using TimicoGameLibrary.Objects.Players;

namespace TimicoGameLibrary.Objects.Levels
{
    public class Level : ILevel
    {
        int scaleX = 10;
        int scaleY = 10;
        List<Character> enemies;
        Location playerStartLocation;

        public List<Character> GetEnemies()
        {
            return enemies;
        }

        public void SetEnemies(List<Character> enemies)
        {
            this.enemies = enemies;
        }

        public Vector2D GetScale()
        {
            return new Vector2D( scaleX, scaleY );
        }

        public Location GetPlayerStartLocation()
        {
            return playerStartLocation;
        }

        public void SetScale(int x, int y)
        {
            scaleX = x;
            scaleY = y;
        }

        public void SetPlayerStartLocation(Location location)
        {
            this.playerStartLocation = location;
        }
    }
}