using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PubsAndClubs
{
    public partial class Form1 : Form
    {
        // Declare DataGridViewRowCollection & XDocument
        DataGridViewRowCollection dgvRows;
        DataGridViewRowCollection dgvRows2;
        XDocument bandDoc;

        public Form1()
        {
            InitializeComponent();

            // Inititalise them
            bandDoc = XDocument.Load("pubsAndClubs.xml");
            dgvRows = dgvGigs.Rows;
            dgvRows2 = dgvBand.Rows;
        }

        //Methods
        private void displayBandInfo()
        {
            //CLear data grid view rows
            dgvRows.Clear();

            // Get the root element
            XElement evGuide = bandDoc.Element("Event_Guide");

            foreach(XElement gig in evGuide.Elements("Gig"))
            {
                string bandName = gig.Element("Band").Element("Name").Value;
                string genre = gig.Element("Band").Element("Genre").Value;
                string venue = gig.Element("Venue").Value;
                string date = gig.Element("Date").Attribute("day").Value + "/"
                    + gig.Element("Date").Attribute("month").Value + "/"
                    + gig.Element("Date").Attribute("year").Value;
                string time = gig.Element("Time").Value;

                String[] newRowValue = { bandName, genre, venue, date, time };

                // Add the string array to the row
                dgvRows.Add(newRowValue);
            }
        }

        private void displayHardRock()
        {
            //CLear data grid view rows
            dgvRows.Clear();

            // Get the root element
            XElement evGuide = bandDoc.Element("Event_Guide");

            foreach(XElement gig in evGuide.Elements("Gig"))
            {
                if(gig.Element("Band").Element("Genre").Value.Trim().Equals("Hard Rock"))
                {
                    string bandName = gig.Element("Band").Element("Name").Value;
                    string genre = gig.Element("Band").Element("Genre").Value;
                    string venue = gig.Element("Venue").Value;
                    string date = gig.Element("Date").Attribute("day").Value + "/"
                        + gig.Element("Date").Attribute("month").Value + "/"
                        + gig.Element("Date").Attribute("year").Value;
                    string time = gig.Element("Time").Value;

                    String[] newRowValue = { bandName, genre, venue, date, time };

                    // Add the string array to the row
                    dgvRows.Add(newRowValue);
                }
            }
        }

        private void displayCurrentMonthGig()
        {
            //CLear data grid view rows
            dgvRows.Clear();

            // Declare and inititalise date
            DateTime d = DateTime.Now;

            // Save current month in a string
            string currentMonth = d.ToString("MM");

            // Get the root element
            XElement evGuide = bandDoc.Element("Event_Guide");

            foreach(XElement gig in evGuide.Elements("Gig"))
            {
                if(gig.Element("Date").Attribute("month").Value.Trim().Equals(currentMonth))
                {
                    string bandName = gig.Element("Band").Element("Name").Value;
                    string genre = gig.Element("Band").Element("Genre").Value;
                    string venue = gig.Element("Venue").Value;
                    string date = gig.Element("Date").Attribute("day").Value + "/"
                        + gig.Element("Date").Attribute("month").Value + "/"
                        + gig.Element("Date").Attribute("year").Value;
                    string time = gig.Element("Time").Value;

                    String[] newRowValue = { bandName, genre, venue, date, time };

                    // Add the string array to the row
                    dgvRows.Add(newRowValue);
                }
            }
        }

        private void displayAlabamaShakes()
        {
            //CLear data grid view rows
            dgvRows2.Clear();

            // Get the root element
            XElement evGuide = bandDoc.Element("Event_Guide");

            foreach (XElement gig in evGuide.Elements("Gig"))
            {
                if (gig.Element("Band").Element("Name").Value.Trim().Equals("Alabama Shakes"))
                {
                    foreach (XElement member in gig.Element("Band").Element("Band_Members").Elements("Member"))
                    {
                        string firstName = member.Element("First_Name").Value;
                        string lastName = member.Element("Last_Name").Value;

                        // Check for members with role
                        string role = "";
                        if (member.Element("Role") != null)
                        {
                            role = member.Element("Role").Value;
                        }
                        else
                        {
                            role = "No Role";
                        }

                        // May have mroe than 1 instrument
                        string instruments = "";
                        foreach (XElement i in member.Element("Instruments").Elements("Instrument"))
                        {
                            instruments += i.Value + ", ";
                        }

                        String[] newRowValue = { firstName, lastName, role, instruments };

                        // Add the string array to the row
                        dgvRows2.Add(newRowValue);
                    }
                }
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            displayBandInfo();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            displayHardRock();
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            displayCurrentMonthGig();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayAlabamaShakes();
        }
    }
}
