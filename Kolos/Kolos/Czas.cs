using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolos
{
    public class Czas
    {
        private Timer timer;

        public int CurrentTime { get; set; }

        


        private int countdown()
        {
            return CurrentTime;
        }

        public void Stopp(Object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            CurrentTime--;
            if (CurrentTime == 0)
                timer.Stop();
            countdown();
        }

        public void odliczanie(int czas)
        {
            CurrentTime = czas;
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000; // 1 second
            timer.Start();
           // czas.Text = counter.ToString();
        }
    }
}
