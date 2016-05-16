using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace metronome
{
    public class metronomeEventArgs : EventArgs
    {
        public DateTime currentTime;

        public metronomeEventArgs(DateTime currentTime)
        {
            this.currentTime = currentTime;
        }
    }


    public class Metronome
    {
        private Form1 mainForm;

        private int interval;
        public int Interval
        {
            get { return interval; }
            set { interval = value; }
        }
      
        public delegate void metronomeEventHandler(object sender, metronomeEventArgs e); 
        public event metronomeEventHandler metronomeEvent;

        public Metronome(int interval, Form1 mainForm)
        {
            this.mainForm = mainForm;
            this.interval = interval;
        }


        public void onMetronomeEvent()
        {
            DateTime now = DateTime.Now;
            metronomeEventArgs e = new metronomeEventArgs(now);

            if (metronomeEvent != null)
            {
                metronomeEvent(this, e);
            }
        }

        public void start()
        {
           while (true)
            {
                System.Threading.Thread.Sleep(interval);
                mainForm.clearBuffer();
                onMetronomeEvent();
            }
        }
   }
}
