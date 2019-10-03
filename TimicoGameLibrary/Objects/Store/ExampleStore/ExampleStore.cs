using System;
using System.Collections.Generic;
using System.Text;
using TimicoGame.Objects.Items;
using TimicoGame.Objects.Items.Coin;

namespace TimicoGame.Objects.Store.ExampleStore
{
    class ExampleStore : IStore
    {
        private List<IItem> Stock = new List<IItem>()
        {
            new Coin()
        };

        public List<IItem> GetStock()
        {
            return Stock;
        }

        public String GetName()
        {
            return "Example Store";
        }
    }
}
