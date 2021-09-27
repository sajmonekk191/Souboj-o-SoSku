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
    public partial class Hospoda : UserControl
    {
        public Hospoda()
        {
            InitializeComponent();
        }

        private void Hospoda_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int quest = rnd.Next(1, 2);
            switch (quest)
            {
                case 1:
                    Quests.PomstaKostlivci(this);
                    return;
                case 2:
                    Quests.Slepyjezdec(this);
                    return;
            }

        }
    }
}
