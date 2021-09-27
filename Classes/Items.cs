using System;
using System.Collections.Generic;
using System.Text;

namespace shakesandfidget.Classes
{
    public static class Items
    {
        public static void KozenyArmor()
        {
            hodnoty.ADDHP(20);
            hodnoty.ADDARMOR(3);
        }
        public static void DrevenyArmor()
        {
            hodnoty.ADDHP(30);
            hodnoty.ADDARMOR(5);
        }
        public static void DrevenyMec()
        {
            hodnoty.ADDDAMAGE(5);
        }
        public static void KamenyMec()
        {
            hodnoty.ADDDAMAGE(9);
        }
    }
}
