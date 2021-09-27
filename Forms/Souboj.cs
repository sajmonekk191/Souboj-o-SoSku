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
            label4.Text = hodnoty.name;
            label3.Text = Convert.ToString("HP: " + hodnoty.HP);
            label2.Text = Convert.ToString("HP: " + hodnoty.HPEnemy);
        }
    }
}
