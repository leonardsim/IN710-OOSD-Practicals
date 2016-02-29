using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDatabase
{
    public partial class Form1 : Form
    {
        // Create and Initialise new MDatabase and MoviePrinter
        MDatabase mD = new MDatabase();
        MoviePrinter mP = new MoviePrinter();

        public Form1()
        {
            InitializeComponent();
        }

        // Displays all the movies in the ListBox
        private void btnPrint_Click(object sender, EventArgs e)
        {
            listBoxPrintAll.Items.Clear();
            
            mP.printMovie(listBoxPrintAll, mD);
        }

        // Adds the movie in the database 
        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            mP.addToTable(txtAddYear, txtAddTitle, txtAddDir, mD);

            txtAddYear.Clear();
            txtAddTitle.Clear();
            txtAddDir.Clear();

            listBoxPrintAll.Items.Clear();
        }

        // Deletes the movie from the database
        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            mP.deleteFromTable(txtDelYear, mD);
            txtDelYear.Clear();

            listBoxPrintAll.Items.Clear();
        }

        // Search for the movie in the database and displays it in the List Box
        private void btnSearch_Click(object sender, EventArgs e)
        {
            listBoxPrintAll.Items.Clear();
            
            mP.searchFromTable(txtSearchYear, mD, listBoxPrintAll);

            txtSearchYear.Clear();
        }
    }
}
