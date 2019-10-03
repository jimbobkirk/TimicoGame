using System;
using System.Collections.Generic;
using System.Text;
using TimicoGame.Objects.Items;

namespace TimicoGame.Objects.Store
{
    public interface IStore
    {
        List<IItem> GetStock();
        String GetName();
    }
}
