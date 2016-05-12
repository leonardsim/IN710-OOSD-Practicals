using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOdatabase
{
    public partial class Form1 : Form
    {
        // Declare DatabaseManager
        DatabaseManager dm;

        public Form1()
        {
            InitializeComponent();

            dm = new DatabaseManager();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            dm.ListAllPaperTutorDetails(dataGridView1);
        }

        private void btnDue_Click(object sender, EventArgs e)
        {
            dm.ListDueDateAssignments(dataGridView1);
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            dm.ListAverageMarkForCompletedAssignments(dataGridView1);
        }

    }
}
