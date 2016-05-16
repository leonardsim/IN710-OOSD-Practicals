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

        public Animal(String soundFileName)
        {
            soundPlayer = new SoundPlayer(soundFileName);
        }

        public void speak()
        {
            while (true)
            {
                    soundPlayer.Play();
                    Thread.Sleep(500);
            }
        }

    }
}
