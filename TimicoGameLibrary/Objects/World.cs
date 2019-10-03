using System;
using System.Collections.Generic;
using System.Text;
using TimicoGame.Objects.Store;
using TimicoGame.Objects.Store.ExampleStore;

namespace TimicoGame.Objects
{
    public class World
    {
        public static String WorldName { get; set; } = "World Name";
        public static List<IStore> GetWorldStores()
        {
            return new List<IStore>()
            {
                new ExampleStore()
            };
        }
    }
}
