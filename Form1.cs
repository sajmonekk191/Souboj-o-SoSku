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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
    }
}
