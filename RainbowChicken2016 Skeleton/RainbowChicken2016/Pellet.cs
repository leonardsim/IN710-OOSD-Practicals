using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace RainbowChicken2016
{
    public class Pellet
    {
        const int MIN_SPEED = 5;
        const int MAX_SPEED = 20;   // allows speed range of 5..15
        const int PELLET_DIAMETER = 15; 
        const int COLOUR_CHOICES = 4;

	    int xPos;
	    int yPos;
	    int xVel;
	    int yVel;
	    Graphics canvas;
	    Brush brush;
	    Random rGen;

        public bool IsAlive {get; set;}
        public Pellet Next {get; set;}


        public Pellet(int xPos, int yPos, Graphics canvas, Random rGen)
        {
            // Grab input args
            this.xPos = xPos;
            this.yPos = yPos;
            this.canvas = canvas;
            this.rGen = rGen;

            // Set default values
            xVel = 0;                               // Change this if you want diagonal motion
            yVel = rGen.Next(MAX_SPEED) + MIN_SPEED;
            yVel *= -1;                             // Moving up the screen
            IsAlive = true;                         // Start live so not culled from list

            brush = genRandomColourBrush();

            Next = null;                            // ESSENTIAL for being a list node
        }

        //==========================================================================
        private Brush genRandomColourBrush()
        {
            int colourChoice = rGen.Next(COLOUR_CHOICES);
            switch (colourChoice)
            {
                case 0:
                    brush = new SolidBrush(Color.Red);
                    break;
                case 1:
                    brush = new SolidBrush(Color.Green);
                    break;
                case 2:
                    brush = new SolidBrush(Color.Blue);
                    break;
                case 3:
                    brush = new SolidBrush(Color.Yellow);
                    break;
                default:
                    brush = new SolidBrush(Color.White);    // A useful default colour
                    break;
            } // end switch
            return brush;
        } // end genRandomColourBrush

        //==========================================================================
        public void Draw()
        {
            canvas.FillEllipse(brush, xPos, yPos, PELLET_DIAMETER, PELLET_DIAMETER);
        }

        //==========================================================================
        public void Move()
        {
            xPos += xVel;
            yPos += yVel;
        }

        //==========================================================================
        public bool TestOutOfBounds(Rectangle boundsRectangle)
        {
            if ((xPos < boundsRectangle.Left) ||
                (xPos > boundsRectangle.Right) ||
                (yPos < boundsRectangle.Top) ||
                (yPos > boundsRectangle.Bottom))

            return true;
            else
            return false;
        }
    }
}
