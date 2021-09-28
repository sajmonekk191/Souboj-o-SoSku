using System;
using System.Collections.Generic;
using System.Text;

namespace shakesandfidget.Classes
{
    public static class LevelingSyS
    {
        public static void UpdateLVL()
        {
            if (hodnoty.XP >= 5 && hodnoty.XP < 10)
            {
                hodnoty.level = 2;
            }

        }
    }
}
