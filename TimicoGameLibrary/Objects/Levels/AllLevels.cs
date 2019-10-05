using System;
using System.Collections.Generic;
using System.Text;

namespace TimicoGameLibrary.Objects.Levels
{
    public class AllLevels
    {
        public List<Level> levels = new List<Level>();
        int currentLevel = 0;
        public AllLevels()
        {
            levels.Add(new Level1());
        }

        public Level GetCurrentLevel()
        {
            return levels[currentLevel];
        }
    }
}
