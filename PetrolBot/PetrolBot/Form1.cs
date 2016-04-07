using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolBot
{
    public partial class Form1 : Form
    {
        //Attributes
        Graphics mainCanvas;
        Brush backgroundBrush;
        Brush petrolBackground;
        List<Ship> shipList;
        List<PetrolBot> petrolList;
        Random rand;
 

        public Form1()
        {
            InitializeComponent();

            //Inititalise them
            mainCanvas = CreateGraphics();
            rand = new Random();
            backgroundBrush = new SolidBrush(Color.Gray);
            petrolBackground = new SolidBrush(Color.Black);
            shipList = new List<Ship>();
            petrolList = new List<PetrolBot>();

            //Inititalise Ships
            Ship s1 = new Ship(mainCanvas, rand);
            Ship s2 = new Ship(mainCanvas, rand);

            //Add to Ship List
            shipList.Add(s1);
            shipList.Add(s2);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Draw the background
            mainCanvas.FillRectangle(backgroundBrush, 0, 0, 600, 600);
            mainCanvas.FillRectangle(petrolBackground, 0, 500, 600, 200);

            // Draws the ship
            foreach (Ship s in shipList)
            {
                s.drawShip();
            }
        }
    }
}
