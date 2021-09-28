using System;
using System.Collections.Generic;
using System.Text;
using shakesandfidget.Forms;

namespace shakesandfidget.Classes
{
    public static class Quests
    {
        public static void PomstaKostlivci(Hospoda f)
        {
            hodnoty.HPEnemy = 0;
            hodnoty.damageEnemy = 0;
            hodnoty.enemylvl = 0;
            Random rnd = new Random();
            f.souboj1.Visible = true;
            hodnoty.HP = hodnoty.MaxHP;
            hodnoty.HPEnemy = hodnoty.level * 2 + rnd.Next(2, 5);
            hodnoty.damageEnemy = hodnoty.level / 2 + rnd.Next(1, 3);
            hodnoty.enemylvl = hodnoty.level + rnd.Next(-2, 3);
            hodnoty.enemyName = "Hnusný Kostlivec";
        }
        public static void Slepyjezdec(Hospoda f)
        {
            hodnoty.HPEnemy = 0;
            hodnoty.damageEnemy = 0;
            hodnoty.enemylvl = 0;
            Random rnd = new Random();
            f.souboj1.Visible = true;
            hodnoty.HP = hodnoty.MaxHP;
            hodnoty.HPEnemy = hodnoty.level * 2 + rnd.Next(2, 8);
            hodnoty.damageEnemy = hodnoty.level / 2 + rnd.Next(1, 3);
            hodnoty.enemylvl = hodnoty.level + rnd.Next(-2, 3);
            hodnoty.enemyName = "Slepý Jezdec";
        }
    }
}
