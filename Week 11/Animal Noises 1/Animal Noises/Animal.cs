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

        public Animal()
        {
            soundPlayer = new SoundPlayer("frog.wav");
        }

        public void speak()
        {
            while (true)
            {
                soundPlayer.Play();
                Thread.Sleep(1000);
            }
        }

    }
}
