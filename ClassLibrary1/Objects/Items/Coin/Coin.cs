using System;
using System.Collections.Generic;
using System.Text;

namespace TimicoGame.Objects.Items.Coin
{
    class Coin : IItem
    {
        public string GetName()
        {
            return "Coin";
        }

        public int GetValue()
        {
            return 1;
        }

        public int GetAmount()
        {
            return 0;
        }

        
    }
}
