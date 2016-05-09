using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireLightningStrikeExternalDatabase
{
    public partial class Form1 : Form
    {
        // Declare database
        FireLightningStrikeDbDataContext db;

        public Form1()
        {
            InitializeComponent();

            // Instantiate the database
            db = new FireLightningStrikeDbDataContext();
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            //Clear listbox
            lbOutput.Items.Clear();

            // Grab all the strikeIntensity from tblStrikes
            IEnumerable<int> strikeIntensity = from strike in db.tblStrikes
                                               select strike.strikeIntensity;

            double avgIntensity = strikeIntensity.Average();

            lbOutput.Items.Add("The average strike intensity is: " + avgIntensity);
        }
    }
}
