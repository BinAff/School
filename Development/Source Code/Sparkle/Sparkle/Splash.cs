using System;
using System.Threading;
using System.Windows.Forms;

namespace Sparkle
{

    public partial class Splash : Form
    {

        public Splash()
        {
            InitializeComponent();
            this.timer.Interval = 10;
            this.timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard();
            new Thread(() =>
            {
                try
                {
                    Sparkle.Cache.Server.Cache();
                }
                catch
                {
                    throw;
                }
            }).Start();
            new Thread(() =>
            {
                try
                {
                    Application.Run(frm);
                    frm.BringToFront();
                }
                catch
                {
                    throw;
                }
            }).Start();
            this.timer.Stop();
            this.Close();
        }

    }

}