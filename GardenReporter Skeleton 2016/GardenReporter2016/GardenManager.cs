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

        //Constructor
        public GardenManager()
        {
            gardenList = new List<Garden>();
        }

        //Method
        // Adds garden to the gardenList
        public void AddGarden(Garden garden)
        {
            gardenList.Add(garden);
        }
        
        // Adds the garden information to the lsit depending on the method delegate
        public void ProcessGardens(Delegate gardenDelegate, ListBox lb)
        {
            // Clear the listbox
            lb.Items.Clear();

            // Itterrate through the list
            foreach(Garden g in gardenList)
            {
                lb.Items.Add();
            }
        }
    }
}
