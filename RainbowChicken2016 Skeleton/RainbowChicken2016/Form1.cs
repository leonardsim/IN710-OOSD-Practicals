using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainbowChicken2016
{
    public partial class Form1 : Form
    {
        //==============================================================================
        // Class constants
        //==============================================================================
        const int STEP_SIZE = 10;
        const int PELLET_DIAMETER = 30;

        //==============================================================================
        // Class properties
        //==============================================================================
        Graphics mainCanvas;
        PelletList mainPelletList;
        Brush backgroundBrush;
        Random rGen;

        //==============================================================================
        // Class constructor
        //==============================================================================
        public Form1()
        {
            InitializeComponent();
            mainCanvas = CreateGraphics();
            Rectangle boundsRectangle = new Rectangle(0, 0, Width, Height);
            mainPelletList = new PelletList(boundsRectangle);
            backgroundBrush = new SolidBrush(Color.Black);
            rGen = new Random();

        }

        //==============================================================================
        // KeyDown handler
        // Moves chicken in direction of arrow key
        // Fires a pellet on spacebar
        //==============================================================================
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyData == Keys.Left)
					 pbxChicken.Left -= STEP_SIZE;

				 if (e.KeyData == Keys.Right)
					 pbxChicken.Left += STEP_SIZE;

				 if (e.KeyData == Keys.Space)
				 {
					 //Generate a new Pellet at chicken's location
					 Pellet newPellet = new Pellet(	pbxChicken.Left + (pbxChicken.Width/2),
															pbxChicken.Top - PELLET_DIAMETER,
															mainCanvas,
															rGen);
					 mainPelletList.addPellet(newPellet);
				 }
        }

        //==============================================================================
        // Timer tick handler
        // At each tick, erases background, moves, kills out of bounds, cleans and renders pellet list
        //==============================================================================
        private void tmrAnimation_Tick(object sender, EventArgs e)
        {
            mainCanvas.FillRectangle(backgroundBrush, 0, 0, Width, Height);

            lblCount.Text = mainPelletList.Count().ToString();

            // Move all nodes in the list
            mainPelletList.Move();

            // Set IsAlive of any out of bounds nodes to false 
            mainPelletList.KillOutOfBounds();

            // Walk the list, deleting all for whom !IsAlive
            mainPelletList.DeleteNotAlive();

            // Draw all the nodes in the list.
            mainPelletList.Draw();
        }
    } // end class Form1
}
