using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDatabase
{
    public class City
    {
        //Accessors
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public int Population { get; set; }

        //Constructor
        public City(string cityName, string countryName, int population)
        {
            CityName = cityName;
            CountryName = countryName;
            Population = population;
        }

        //Method
        public override string ToString()
        {
            return CityName + ": \t" + Population;
        }
    }
}
