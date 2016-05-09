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

        private void btnLargest_Click(object sender, EventArgs e)
        {
            //Clear listbox
            lbOutput.Items.Clear();

            // Order the fireArea in descending order
            var fireArea =  from fire in db.tblFires
                            orderby fire.fireArea descending
                            select fire;

            // Take the first 3 element
            var topThreeFire = fireArea.Take(3);

            // Output it
            foreach (var fire in topThreeFire)
            {
                lbOutput.Items.Add(fire.fireID + "\t" + fire.fireDate + "\t" + fire.fireLatitude + "\t" + fire.fireLongitude + "\t" + fire.fireArea);
            }
        }

        private void btnLatLongPic_Click(object sender, EventArgs e)
        {
            //Clear listbox
            lbOutput.Items.Clear();

            // Join the strike and picture table
            var strikePic = from strike in db.tblStrikes
                            join pic in db.tblPictures
                            on strike.strikeID equals pic.strikeID
                            select new { strike.strikeLatitude, strike.strikeLongitude, pic.pictureFileName };

            // Output it
            foreach (var record in strikePic)
            {
                lbOutput.Items.Add(record.strikeLatitude + "\t" + record.strikeLongitude + "\t" + record.pictureFileName);
            }

        }

        private void btnStrikeFire_Click(object sender, EventArgs e)
        {

        }
    }
}
