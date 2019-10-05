using System;
using System.Collections.Generic;
using System.Text;
using TimicoGame.Objects.Store;
using TimicoGame.Objects.Store.ExampleStore;
using TimicoGameLibrary.Objects.Levels;
using TimicoGameLibrary.Objects.Players;

namespace TimicoGame.Objects
{
    public class World
    {
        public static String WorldName { get; set; } = "World Name";
        public AllLevels levels = new AllLevels();
        public Player player = new Player();
        public static List<IStore> GetWorldStores()
        {
            return new List<IStore>()
            {
                new ExampleStore()
            };
        }
    }
}
