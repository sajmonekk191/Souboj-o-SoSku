using System;
using System.Collections.Generic;
using System.Text;

namespace shakesandfidget.Classes
{
    public static class LevelingSyS
    {
        public static void UpdateLVL()
        {
            hodnoty.level = Convert.ToInt32((Math.Pow(hodnoty.XP, 0.7) / 5) + 1); //exponential growth of xp needed to next level

        }
    }
}
