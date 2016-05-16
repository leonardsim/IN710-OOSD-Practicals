using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace metronome
{
    public class MetronomeObserver
    {
        protected Metronome metronome;

        public MetronomeObserver(Metronome metronome)
        {
            this.metronome = metronome;
            metronome.metronomeEvent += new Metronome.metronomeEventHandler(onMetronomeEvent);
        }

        public virtual void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            MessageBox.Show("My metronome clicked");
        }

    }

    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class Beeper : MetronomeObserver
    {
        private String soundFileName;
        private SoundPlayer soundPlayer;

        public Beeper(Metronome metronome, String soundFileName)
            : base(metronome)
        {
            this.soundFileName = soundFileName;
            soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = soundFileName;
        }


        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            soundPlayer.Play();
        }

    } // end TBeeper
    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class Counter : MetronomeObserver
    {
        private NumericUpDown spinBox;
        private delegate void spinDelegate();

        public Counter(Metronome metronome, NumericUpDown spinBox)
            : base(metronome)
        {
            this.spinBox = spinBox;
        }

        // Passed into the delegate
        private void incrementSpinVal()
        {
            spinBox.Value++;  
        }


        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            // InvokeRequired gets a value indicating whether the caller must call an invoke
            // method when making method calls to the control because the caller is on a different
            // thread than the one the control was created on
            // Returns true, if the control's handle was created on a different thread than the 
            // calling thread
            if(spinBox.InvokeRequired)
            {
                spinDelegate sd = new spinDelegate(incrementSpinVal);

                // Invoke method executes the specified delegate on the thread that owns the
                // control's underlying window handle
                spinBox.Invoke(sd);
            }
            else
            {
                incrementSpinVal();
            }
        }
    } // end TCounter

    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class TimeDisplay : MetronomeObserver
    {
        private ListBox listBox;
        private delegate void listboxDelegate(DateTime time);

        public TimeDisplay(Metronome metronome, ListBox listBox)
            : base(metronome)
        {
            this.listBox = listBox;
        }

        private void updateTimeString(DateTime t)
        {
            listBox.Items.Add(t.ToString());
        }


        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            if (listBox.InvokeRequired)
            {
                listboxDelegate ld = new listboxDelegate(updateTimeString);
                listBox.Invoke(ld, e.currentTime);
            }
            else
            {
                updateTimeString(e.currentTime);
            }


            /*DateTime currDateTime = e.currentTime;
            listBox.Items.Add(currDateTime.ToString());*/   
        }
    }






            
}
