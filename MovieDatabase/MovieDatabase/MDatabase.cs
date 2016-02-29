using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    public class MDatabase
    {
        //Variables
        Dictionary<int, Movie> movieTable = new Dictionary<int, Movie>();

        //Constructor
        public MDatabase()
        {
            //Dummy datas
            Movie movie1 = new Movie(1961, "West SideStory", "Jerome Robbins");
            Movie movie2 = new Movie(1972, "The Godfather", "Francis Ford Coppola");
            Movie movie3 = new Movie(1984, "Amadeus", "Milos Foreman");
            Movie movie4 = new Movie(2007, "No Country for Old Men", "Ethan & Joel Coen");

            movieTable.Add(movie1.Year, movie1);
            movieTable.Add(movie2.Year, movie2);
            movieTable.Add(movie3.Year, movie3);
            movieTable.Add(movie4.Year, movie4);
        }

        //Methods
        // Add movie key value (Year) and movie value into the movieTable Dictionary
        public void addMovies(Movie movie)
        {
            movieTable.Add(movie.Year, movie);
        }

        // Sort movies based on key value and returns a list of type KeyValuePair<int,Movie>
        public List<KeyValuePair<int, Movie>> sortMovie(Dictionary<int, Movie> movieTable)
        {
            // Similair to MySQL, using LINQ query, entry is a value in the movieTable Dictionary so for each entry in movieTable
            // order the key values in ascending order
            List<KeyValuePair<int, Movie>> sortKey = (from entry in movieTable orderby entry.Key ascending select entry).ToList();

            return sortKey;
        }

        // Get/Set method 
        public Dictionary<int, Movie> MovieTable
        {
            get { return movieTable; }
            set { movieTable = value; }
        }
    }
}
