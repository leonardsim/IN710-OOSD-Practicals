using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                                                "Initital Catalog = IN700001_201601_SIMLE1;" +
                                                "User ID = simle1;" +
                                                "Password = " + UserInfo.PASS + ";";

            bitdevConnection.Open();
        }

        // Used to execute non-query (Normally used for INSERT, UPDATE, DELETE, CREATE, and SET statement)
        private void executeNonQuery(string query)
        {
            SqlCommand nonQuery = new SqlCommand(query, bitdevConnection);

            // Returns the number of rows affected by the statement
            nonQuery.ExecuteNonQuery();
        }


    }
}
