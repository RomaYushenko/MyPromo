﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fMain
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();

            Timer t = new Timer();
            t.Interval = 6000;
            t.Start();
            t.Tick += new EventHandler(t_Tick);

            timer1.Start();
            Opacity = 0;
            Timer timer = new Timer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.005d) == 1) timer.Stop();
            });
            timer.Interval = 1;
            timer.Start();
        }
        void t_Tick(object sender, EventArgs e)
        {
            //диспоз картинки для гифки
            Close();

        }
    }
}
