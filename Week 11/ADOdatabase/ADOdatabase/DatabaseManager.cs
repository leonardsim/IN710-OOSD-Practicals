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
        // Runs a command, or a stored procedure, that affects the state of the specified table
        private void executeNonQuery(string query)
        {
            SqlCommand nonQuery = new SqlCommand(query, bitdevConnection);

            // Returns the number of rows affected by the statement
            nonQuery.ExecuteNonQuery();
        }

        // Will drop an existing table in the database
        private void dropExistingTables(string table)
        {
            String dropTable = "IF OBJECT_ID('" + table + "') IS NOT NULL DROP TABLE " + table + ";";
            executeNonQuery(dropTable);
        }

        // Creates a tutor table
        private void createTutorTable()
        {
            string createTable = "CREATE TABLE tblTutors (" +
                                 "tutID INT IDENTITY, " +
                                 "firstName VARCHAR(30), " +
                                 "lastName VARCHAR(30), " +
                                 "email VARCHAR(100), " +
                                 "CONSTRAINT PK_tblTutors PRIMARY KEY(tutID))";

            executeNonQuery(createTable);
        }
    }
}
