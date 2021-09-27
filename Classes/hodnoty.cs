using System;
using System.Collections.Generic;
using System.Text;

namespace shakesandfidget.Classes
{
    public static class hodnoty
    {
        public static string name = "Guest";
        public static int MaxHP = 10;
        public static int level = 1;
        public static int XP;
        public static int Gold = 0;
        public static int Houbicky = 0;
        public static bool activequest;
        public static int armor;
        public static int damage = 1;
        public static int HP;
        public static int HPEnemy;
        public static int damageEnemy;
        public static string enemyName;
        public static bool soubojwin = false;
        public static bool soubojlose = false;
        public static void ADDLEVEL(int hodnota)
        {
            level += hodnota;
        }
        public static void ADDXP(int hodnota)
        {
            XP += hodnota;
        }
        public static void ADDGOLD(int hodnota)
        {
            Gold += hodnota;
        }
        public static void ADDLEVEL(bool hodnota)
        {
            activequest = hodnota;
        }
        public static void ADDARMOR(int hodnota)
        {
            armor += hodnota;
        }
        public static void ADDDAMAGE(int hodnota)
        {
            damage += hodnota;
        }
        public static void ADDHP(int hodnota)
        {
            HP += hodnota;
        }
    }
}
