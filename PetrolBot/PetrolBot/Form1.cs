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
        Rectangle boundsRectangle;
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
            boundsRectangle = new Rectangle(0, 0, Width, 500);
            shipList = new List<Ship>();
            petrolList = new List<PetrolBot>();

            //Inititalise Ships
            Ship s1 = new Ship(mainCanvas, rand);
            Ship s2 = new Ship(mainCanvas, rand);

            //Inititalise PetrolBot
            PetrolBot b1 = new PetrolBot(mainCanvas, Color.Blue, new Point(50, 525));
            PetrolBot b2 = new PetrolBot(mainCanvas, Color.Pink, new Point(100, 525));
            PetrolBot b3 = new PetrolBot(mainCanvas, Color.Green, new Point(150, 525));
            PetrolBot b4 = new PetrolBot(mainCanvas, Color.Yellow, new Point(200, 525));
            PetrolBot b5 = new PetrolBot(mainCanvas, Color.Brown, new Point(250, 525));

            //Add to Ship List
            shipList.Add(s1);
            shipList.Add(s2);

            //Add to PetrolBot List
            petrolList.Add(b1);
            petrolList.Add(b2);
            petrolList.Add(b3);
            petrolList.Add(b4);
            petrolList.Add(b5);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Draw the background
            mainCanvas.FillRectangle(backgroundBrush, 0, 0, 600, 500);
            mainCanvas.FillRectangle(petrolBackground, 0, 500, 600, 200);

            // Draws the ship
            foreach (Ship s in shipList)
            {
                s.ShipCycle(boundsRectangle);
            }

            // Draws the petrol
            foreach (PetrolBot p in petrolList)
            {
                p.drawBot();
            }
        }
    }
}
