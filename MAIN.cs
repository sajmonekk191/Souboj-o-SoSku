using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using shakesandfidget.Classes;

namespace shakesandfidget
{
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            button6.Visible = false; ;
            Visibility.AllInvisible(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visibility.HospodaVisible(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Visibility.ArenaVisible(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Visibility.PodzemiVisible(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Visibility.ZbraneVisible(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visibility.SperkyVisible(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hodnoty.name = textBox1.Text;
            textBox1.Visible = false;
            button6.Visible = false;
        }

        private void Updater_Tick(object sender, EventArgs e)
        {
            lblLevel.Text = Convert.ToString("Level: " + hodnoty.level);
            lblGold.Text = Convert.ToString("Zlaťáky: " + hodnoty.Gold);
            lblHoubicky.Text = Convert.ToString("Houbičky: " + hodnoty.Houbicky);
            label1.Text = "Name: " + hodnoty.name;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            button6.Visible = true;
        }
    }
}
