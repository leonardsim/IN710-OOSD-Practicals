using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;

namespace Animal_Noises
{
    public class Animal
    {
        private SoundPlayer soundPlayer;
        private String soundFileName;
        private object lockOb;

        public Animal(String soundFileName, object lockOb)
        {
            soundPlayer = new SoundPlayer(soundFileName);
            this.lockOb = lockOb;
        }

        public void speak()
        {
            while (true)
            {
                lock (lockOb)
                {
                    soundPlayer.Play();
                    Thread.Sleep(500);
                }
            }
        }

    }
}
