
namespace shakesandfidget
{
    public partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.hospoda1 = new shakesandfidget.Forms.Hospoda();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblHoubicky = new System.Windows.Forms.Label();
            this.arena1 = new shakesandfidget.Forms.Arena();
            this.podzemi1 = new shakesandfidget.Forms.Podzemi();
            this.sperky1 = new shakesandfidget.Forms.sperky();
            this.zbrane1 = new shakesandfidget.Forms.zbrane();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hospoda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Obchod se šperkami";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Arena";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Obchod se Zbraněmi";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 70);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Podzemí";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // hospoda1
            // 
            this.hospoda1.Location = new System.Drawing.Point(208, 80);
            this.hospoda1.Name = "hospoda1";
            this.hospoda1.Size = new System.Drawing.Size(416, 229);
            this.hospoda1.TabIndex = 9;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(584, 9);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(40, 15);
            this.lblLevel.TabIndex = 10;
            this.lblLevel.Text = "Level: ";
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(585, 24);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(52, 15);
            this.lblGold.TabIndex = 12;
            this.lblGold.Text = "Zlaťáky: ";
            // 
            // lblHoubicky
            // 
            this.lblHoubicky.AutoSize = true;
            this.lblHoubicky.Location = new System.Drawing.Point(585, 41);
            this.lblHoubicky.Name = "lblHoubicky";
            this.lblHoubicky.Size = new System.Drawing.Size(64, 15);
            this.lblHoubicky.TabIndex = 13;
            this.lblHoubicky.Text = "Houbičky: ";
            // 
            // arena1
            // 
            this.arena1.Location = new System.Drawing.Point(208, 59);
            this.arena1.Name = "arena1";
            this.arena1.Size = new System.Drawing.Size(359, 277);
            this.arena1.TabIndex = 14;
            // 
            // podzemi1
            // 
            this.podzemi1.Location = new System.Drawing.Point(191, 59);
            this.podzemi1.Name = "podzemi1";
            this.podzemi1.Size = new System.Drawing.Size(412, 240);
            this.podzemi1.TabIndex = 15;
            // 
            // sperky1
            // 
            this.sperky1.Location = new System.Drawing.Point(181, 9);
            this.sperky1.Name = "sperky1";
            this.sperky1.Size = new System.Drawing.Size(398, 358);
            this.sperky1.TabIndex = 16;
            // 
            // zbrane1
            // 
            this.zbrane1.Location = new System.Drawing.Point(180, 12);
            this.zbrane1.Name = "zbrane1";
            this.zbrane1.Size = new System.Drawing.Size(398, 358);
            this.zbrane1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 407);
            this.Controls.Add(this.zbrane1);
            this.Controls.Add(this.sperky1);
            this.Controls.Add(this.hospoda1);
            this.Controls.Add(this.lblHoubicky);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.arena1);
            this.Controls.Add(this.podzemi1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Boj o SOŠKU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        public Forms.Hospoda hospoda1;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblHoubicky;
        public Forms.Arena arena1;
        public Forms.Podzemi podzemi1;
        public System.Windows.Forms.Label lblLevel;
        public Forms.sperky sperky1;
        public Forms.zbrane zbrane1;
    }
}

