using System;
using System.Collections.Generic;
using System.Text;
using shakesandfidget.Forms;
using shakesandfidget.Classes;

namespace shakesandfidget.Classes
{
    public static class Visibility
    {
        public static void HospodaVisible(MAIN f)
        {
            f.hospoda1.Visible = true;
            f.arena1.Visible = false;
            f.podzemi1.Visible = false;
            f.sperky1.Visible = false;
            f.zbrane1.Visible = false;
        }
        public static void ArenaVisible(MAIN f)
        {
            f.hospoda1.Visible = false;
            f.arena1.Visible = true;
            f.podzemi1.Visible = false;
            f.sperky1.Visible = false;
            f.zbrane1.Visible = false;
        }
        public static void PodzemiVisible(MAIN f)
        {
            f.hospoda1.Visible = false;
            f.arena1.Visible = false;
            f.podzemi1.Visible = true;
            f.sperky1.Visible = false;
            f.zbrane1.Visible = false;
        }
        public static void SperkyVisible(MAIN f)
        {
            f.hospoda1.Visible = false;
            f.arena1.Visible = false;
            f.podzemi1.Visible = false;
            f.sperky1.Visible = true;
            f.zbrane1.Visible = false;
        }
        public static void ZbraneVisible(MAIN f)
        {
            f.hospoda1.Visible = false;
            f.arena1.Visible = false;
            f.podzemi1.Visible = false;
            f.sperky1.Visible = false;
            f.zbrane1.Visible = true;
        }
        public static void AllInvisible(MAIN f)
        {
            f.hospoda1.Visible = false;
            f.arena1.Visible = false;
            f.podzemi1.Visible = false;
            f.sperky1.Visible = false;
            f.zbrane1.Visible = false;
        }
    }
}
