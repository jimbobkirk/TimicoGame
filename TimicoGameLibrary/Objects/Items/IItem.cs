using System;

namespace TimicoGame.Objects.Items
{
    public interface IItem
    {
        // Item Name
        String GetName();

        //Item Value
        Int32 GetValue();

        Int32 GetAmount();
    }
}
