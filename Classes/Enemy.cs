using System;
using System.Collections.Generic;
using System.Text;

namespace shakesandfidget.Classes
{
    public static class Enemy
    {
        public static void kostlivec()
        {
            Random rnd = new Random();
            hodnoty.HPEnemy = 2 + rnd.Next(1, 4);
            hodnoty.damageEnemy = 1 + rnd.Next(1, 2);
        }

    }
}
