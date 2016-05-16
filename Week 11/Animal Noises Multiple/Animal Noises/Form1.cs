using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Animal_Noises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Animal> animalList;
        private List<Thread> threadList;

        // Something to be shared across all thread 
        // and will be used to lock
        // lock can only take in objects
        private object lockOb;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            animalList = new List<Animal>();
            threadList = new List<Thread>();

            // Instantiate the lock
            lockOb = new object();

            animalList.Add(new Animal("frog.wav", lockOb));
            animalList.Add(new Animal("duck.wav", lockOb));
            animalList.Add(new Animal("meow.wav", lockOb));

            for (int i = 0; i < animalList.Count; i++)
                threadList.Add(new Thread(animalList[i].speak)); 
            
            for (int i = 0; i < animalList.Count; i++)
                threadList[i].Start();

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < animalList.Count; i++)
                threadList[i].Abort();
        }


    }
}
