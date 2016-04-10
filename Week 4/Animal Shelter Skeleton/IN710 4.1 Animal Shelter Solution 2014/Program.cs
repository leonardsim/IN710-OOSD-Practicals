using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
