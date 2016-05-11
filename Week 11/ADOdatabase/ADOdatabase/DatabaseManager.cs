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
                                 "firstName VARCHAR(30) NOT NULL, " +
                                 "lastName VARCHAR(30) NOT NULL, " +
                                 "email VARCHAR(100) NOT NULL, " +
                                 "PRIMARY KEY(tutID));";

            executeNonQuery(createTable);
        }

        // Creates a paper table
        private void createPapersTable()
        {
            string createTable = "CREATE TABLE tblPapers (" +
                                 "paperID INT IDENTITY, " +
                                 "tutID INT NOT NULL, " +
                                 "paperName VARCHAR(50) NOT NULL, " +
                                 "PRIMARY KEY(tutID)," + 
                                 "FOREIGN KEY(lecID) REFERENCES tblTutors(tutID));";

            executeNonQuery(createTable);
        }

        // Creates an assignment table
        private void createAssignmentsTable()
        {
            string createTable = "CREATE TABLE tblAssignments (" +
                                 "assignID INT IDENTITY, " +
                                 "paperID INT NOT NULL, " +
                                 "assignTopic VARCHAR(100) NOT NULL, " +
                                 "deadline date NOT NULL, " +
                                 "grade INT NOT NULL," +
                                 "PRIMARY KEY(assignID)," +
                                 "FOREIGN KEY(paperID) REFERENCES tblPapers(paperID));";

            executeNonQuery(createTable);
        }

        // Creates all the tables
        private void createAllTables()
        {
            // Drop any existing tables first
            dropExistingTables("tblTutors");
            dropExistingTables("tblPapers");
            dropExistingTables("tblAssignments");

            // Create the necessary tables for the database
            createTutorTable();
            createPapersTable();
            createAssignmentsTable();
        }

        // Insert values for Tutor
        private void insertTutorValue(string firstName, string lastName, string email)
        {
            string insertQuery = "INSERT INTO tblTutors VALUES('" + firstName + "','" + lastName + "','" + email + "');";
            executeNonQuery(insertQuery);
        }

        // Insert values for Paper
        private void insertPaperValue(int tutID, string paperName)
        {
            string insertQuery = "INSERT INTO tblPapers VALUES('" + tutID + "','" + paperName + "');";
            executeNonQuery(insertQuery);
        }

        // Insert values for Assignment
        private void insertAssignmentValue(int paperID, string assignTopic, string date, int grade)
        {
            string insertQuery = "INSERT INTO tblAssignments VALUES('" + paperID + "','" + assignTopic + "','" + date + "','" + grade + "');";
            executeNonQuery(insertQuery);
        }
    }
}
