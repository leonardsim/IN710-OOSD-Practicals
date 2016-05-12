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

            BindingSource bs = new BindingSource();
            bs.DataSource = selectReader;
            dv.DataSource = bs;

            // Close it when done with query
            selectReader.Close();
            bitdevConnection.Close();
        }

    }
}
