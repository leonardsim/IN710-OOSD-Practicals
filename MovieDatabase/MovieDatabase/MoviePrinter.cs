using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDatabase
{
    public class MoviePrinter
    {   
        //Constructor
        public MoviePrinter()
        {

        }
        
        //Methods
        // Prints all the movies from the movieTable Dictionary to the ListBox
        public void printMovie(ListBox displayAll, MDatabase mD)
        {
            // foreach loop pulls KeyValuePair objects which have Key and Value properties
            // Data types must be specified for the key (int in this one) and value (Movie in this one)
            // Will output the year of the movie and the remaining values of the movie (Year, Title, Director) in the sorted list

            // mD.sortMovie(mD.MovieTable) is a method that will return a sorted List of type KeyValuePair<int,Movie>
            foreach (KeyValuePair<int, Movie> currentMovie in mD.sortMovie(mD.MovieTable))
            {
                displayAll.Items.Add("******************************");
                displayAll.Items.Add(currentMovie.Key.ToString());
                displayAll.Items.Add(currentMovie.Value.ToString());
            }

        }

        // Add the user input from the text fields into the movie database
        public void addToTable(TextBox addYear, TextBox addTitle, TextBox addDirector, MDatabase mD)
        {
            // Checks whether the field has been filled and whether the year text field was filled with an int type value
            // If not then, a messagebox will appear telling user to fill all text fields with correct value type

            // Int32.TryParse converts the string representation to its 32-bit signed interger equivalent 
            // If string entered can be converted (result = true) then the process continues if not, it will return the same messagebox from earlier
            int num;
            if (addYear.Text != "" && addTitle.Text != "" && addDirector.Text != "" && Int32.TryParse(addYear.Text, out num))
            {
                // Convert the year string into int so it can be used as the key value
                int key = int.Parse(addYear.Text);

                // If the year entered doesn't already exist in the Dictionary, then it will be added into it
                // Else a messagebox will appear telling user the year entered already exists in the database
                if (!mD.MovieTable.ContainsKey(key))
                {
                    Movie temp = new Movie(int.Parse(addYear.Text), addTitle.Text, addDirector.Text);

                    mD.addMovies(temp);
                }
                else
                {
                    MessageBox.Show("The year entered already exists in the database");
                }
            }
            else
            {
                MessageBox.Show("Please fill out all of the year, title and director with the CORRECT value type to add movie");
            }
        }

        // Will delete the movie from database based on the year entered
        public void deleteFromTable(TextBox delYear, MDatabase mD)
        {
            int num;
            bool intCheck = Int32.TryParse(delYear.Text, out num);

            // Checks if input isn't empty or if input was of numeric type
            // Else a messagebox will appear telling user field entered was empty
            if (delYear.Text != "" && intCheck == true)
            {
                // Convert the year string into int so it can be used as the key value
                int key = int.Parse(delYear.Text);

                // If the year exists in the Dictionary then it will remove the movie from it
                // Else a messagebox will appear informing user that year entered does not exist
                if (mD.MovieTable.ContainsKey(key))
                {
                    Movie movieToDel = mD.MovieTable[key];
                    mD.MovieTable.Remove(key);
                }
                else
                {
                    MessageBox.Show("The year " + delYear.Text + " does not exist in the database");
                    delYear.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter a year into the field");
            }
        }

        // Will search and display movie based on year entered
        public void searchFromTable(TextBox searchYear, MDatabase mD, ListBox displaySearch)
        {
            int num;
            bool intCheck = Int32.TryParse(searchYear.Text, out num);

            // Checks if input isn't empty or if input was of numeric type
            // Else a messagebox will appear telling user field entered was empty
            if (searchYear.Text != "" && intCheck == true)
            {
                // Convert the year string into int so it can be used as the key value
                int key = int.Parse(searchYear.Text);

                // If the year exists in the Dictionary then it will display the movie from it
                // Else a messagebox will appear informing user that year entered does not exist
                if (mD.MovieTable.ContainsKey(key))
                {
                    Movie movieSearched = mD.MovieTable[key];

                    displaySearch.Items.Add("******************************");
                    displaySearch.Items.Add(movieSearched.Year);
                    displaySearch.Items.Add(movieSearched.ToString());
                }
                else
                {
                    MessageBox.Show("Unable to search movie because year " + searchYear.Text + " does not exist in database");
                }
            }
            else
            {
                MessageBox.Show("Please enter a year into the field");
            }
        }
    }
}
