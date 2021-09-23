using System;
using System.Collections.Generic;
using System.Text;
using shakesandfidget.Forms;
using shakesandfidget.Classes;

namespace shakesandfidget.Classes
{
    public static class Visibility
    {
        public static void HospodaVisible(Form1 f)
        {
            f.hospoda1.Visible = true;
            f.arena1.Visible = false;
            f.podzemi1.Visible = false;
            f.sperky1.Visible = false;
            f.zbrane1.Visible = false;
        }
        public static void ArenaVisible(Form1 f)
        {
            f.hospoda1.Visible = false;
            f.arena1.Visible = true;
            f.podzemi1.Visible = false;
            f.sperky1.Visible = false;
            f.zbrane1.Visible = false;
        }
        public static void PodzemiVisible(Form1 f)
        {
            f.hospoda1.Visible = false;
            f.arena1.Visible = false;
            f.podzemi1.Visible = true;
            f.sperky1.Visible = false;
            f.zbrane1.Visible = false;
        }
        public static void SperkyVisible(Form1 f)
        {
            f.hospoda1.Visible = false;
            f.arena1.Visible = false;
            f.podzemi1.Visible = false;
            f.sperky1.Visible = true;
            f.zbrane1.Visible = false;
        }
        public static void ZbraneVisible(Form1 f)
        {
            f.hospoda1.Visible = false;
            f.arena1.Visible = false;
            f.podzemi1.Visible = false;
            f.sperky1.Visible = false;
            f.zbrane1.Visible = true;
        }
        public static void AllInvisible(Form1 f)
        {
            f.hospoda1.Visible = false;
            f.arena1.Visible = false;
            f.podzemi1.Visible = false;
            f.sperky1.Visible = false;
            f.zbrane1.Visible = false;
        }
    }
}
