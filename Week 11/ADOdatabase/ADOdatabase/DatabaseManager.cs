using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOdatabase
{
    public class DatabaseManager
    {
        // Declare SqlConnection
        SqlConnection bitdevConnection;
        
        //Constructor
        public DatabaseManager()
        {
        }

        // Methods
        // Connects to the database
        private void connectToDatabase()
        {
            bitdevConnection = new SqlConnection();

            bitdevConnection.ConnectionString = "Data Source = bitdev.ict.op.ac.nz;" +
                                                "Initial Catalog = IN700001_201601_SIMLE1;" +
                                                "User ID = simle1;" +
                                                "Password = " + UserInfo.PASS + ";";

            bitdevConnection.Open();
        }

        private void outputQuery(DataGridView dv, String selectQuery)
        {
            // Connect to the database 
            connectToDatabase();

            // Load the statement to the command
            SqlCommand selectCommand = new SqlCommand();
            selectCommand.Connection = bitdevConnection; // Connects the command to the database
            selectCommand.CommandText = selectQuery; // Holds the select query

            SqlDataReader selectReader;
            selectReader = selectCommand.ExecuteReader(); // Functions like a stream reader (reads record one at a time)

            // Bind the DataGridView to the BindingSource  and load the data from the reader
            BindingSource bs = new BindingSource();
            bs.DataSource = selectReader;
            dv.DataSource = bs;

            // Close it when done with query
            selectReader.Close();
            bitdevConnection.Close();
        }

        public void ListAllPaperTutorDetails(DataGridView dv)
        {
            string selectQuery = "SELECT tblPapers.paperName, tblTutors.firstName, tblTutors.lastName, tblTutors.email " +
                                 "FROM tblPapers JOIN tblTutors ON tblPapers.tutID = tblTutors.tutID;";

            outputQuery(dv, selectQuery);
        }

        public void ListDueDateAssignments(DataGridView dv)
        {
            // Get today's date time and get the date time for two weeks from now
            DateTime time = DateTime.Now;
            DateTime addTwoWeeks = time.AddDays(14);

            // Format string for DateTime
            string format = "yyyy-MM-dd";

            // Format the date time for today and twoWeeksFromNow
            string today = time.ToString(format);
            string twoWeeksFromNow = addTwoWeeks.ToString(format);


            String selectQuery = "SELECT assignTopic, deadline " +
                                 "FROM tblAssignments WHERE deadline BETWEEN '" + today + "' AND '" + twoWeeksFromNow + "';";

            outputQuery(dv, selectQuery);
        }

        public void ListAverageMarkForCompletedAssignments(DataGridView dv)
        {
            // Had a multi-part identifier issue
            // (The multi-part identifier "tblPapers.paperName" could not be bound)
            // 
            string selectQuery = "SELECT tblPapers.paperName, AVG(tblAssignments.grade) AS averageMark " +
                                 "FROM tblPapers JOIN tblAssignments ON tblPapers.paperID = tblAssignments.paperID " +
                                 "WHERE tblAssignments.completed = 1 GROUP BY paperName;";

            outputQuery(dv, selectQuery);
        }
    }
}
