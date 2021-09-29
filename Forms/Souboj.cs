using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using shakesandfidget.Classes;

namespace shakesandfidget.Forms
{
    public partial class Souboj : UserControl
    {
        public Souboj()
        {
            InitializeComponent();
        }

        private void Souboj_Load(object sender, EventArgs e)
        {
            hodnoty.HP = hodnoty.MaxHP;
            
        }

        private void Updater_Tick(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString("Level: " + hodnoty.level);
            if (hodnoty.enemylvl <= 0) { hodnoty.enemylvl = 1; }             
            label6.Text = Convert.ToString("Level: " + hodnoty.enemylvl);
            label1.Text = hodnoty.enemyName;
            label4.Text = hodnoty.name;
            label3.Text = Convert.ToString("HP: " + hodnoty.HP);
            label2.Text = Convert.ToString("HP: " + hodnoty.HPEnemy);
            pictureBox1.Image = hodnoty.ImgEnemy;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hpenemy = hodnoty.HPEnemy -= hodnoty.damage;
            int hp = hodnoty.HP -= hodnoty.damageEnemy;
            label2.Text = Convert.ToString("HP: " + hpenemy);
            label3.Text = Convert.ToString("HP: " + hp);
            if (hodnoty.HPEnemy <= 0 && hodnoty.HP > 0)
            {
                Random rnd = new Random();
                hodnoty.ADDXP(rnd.Next(5, 10));
                hodnoty.ADDGOLD(rnd.Next(3, 12));
                hodnoty.soubojwin = true;
            }
            if (hodnoty.HP <= 0)
            {
                hodnoty.soubojlose = true;
            }
        }
    }
}
