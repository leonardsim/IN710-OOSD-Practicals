using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GardenReporter2016
{
    public class Garden
    {
        private double gardenWidth;
        private double gardenHeight;
        private string ownerName;
        List<double> currentCharges;

        //====================================================
        public string OwnerName
        {
            get { return ownerName; }
            set { ownerName = value; }
        }

        //====================================================
        public Garden(double gardenWidth, double gardenHeight, string ownerName)
        {
            this.gardenWidth = gardenWidth;
            this.gardenHeight = gardenHeight;
            this.ownerName = ownerName;

            currentCharges = new List<double>();
        }

        //====================================================
        public void AddCharge(double newCharge)
        {
            currentCharges.Add(newCharge);
        }

        //====================================================
        public double GetAccountBalance()
        {
            double balance = 0;

            foreach (double charge in currentCharges)
                balance += charge;

            return balance;
        }
        //====================================================
        public double GetArea()
        {
            //Rectangular gardens at the moment, but this method allows
            //for expansion to more complex shapes.
            return gardenHeight * gardenWidth;
        }

    }
}
