using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenReporter2016
{
    public class GardenManager
    {
        //Attributes
        List<Garden> gardenList;
        public delegate double gardenDelegate();
        gardenDelegate gD;
        String reportString;

        //Constructor
        public GardenManager()
        {
            gardenList = new List<Garden>();
            reportString = "";
        }

        //Method
        // Adds garden to the gardenList
        public void AddGarden(Garden garden)
        {
            gardenList.Add(garden);
        }
        
        // Adds the garden information to the lsit depending on the method delegate
        public void ProcessGardens(gardenDelegate gD, ListBox lb, Button bt)
        {
            // Clear the listbox
            lb.Items.Clear();

            // Itterrate through the list
            foreach(Garden g in gardenList)
            {
                // Depending on the button name, the garden method will be passed into the delegate
                if(bt.Name == "btnArea")
                {
                    gD = new gardenDelegate(g.GetArea);
                    reportString = String.Format("{0,-14}:{1,8:f2}", g.OwnerName, g.GetArea());
                }
                else if (bt.Name == "btnCharges")
                {
                    gD = new gardenDelegate(g.GetAccountBalance);
                    reportString = String.Format("{0,-14}:{1,8:f2}", g.OwnerName, g.GetAccountBalance());
                }

                // Add to the list
                lb.Items.Add(reportString);
            }
        }

        // Getter/Setter
        public gardenDelegate GD
        {
            get { return gD; }
            set { gD = value; }
        }
    }
}
