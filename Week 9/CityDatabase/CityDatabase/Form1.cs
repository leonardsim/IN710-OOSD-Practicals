using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityDatabase
{
    public partial class Form1 : Form
    {
        // Declare city & country list
        List<City> cityList;
        List<String> countryList;

        public Form1()
        {
            InitializeComponent();

            // Instantiate them
            cityList = new List<City>();
            countryList = new List<String>();

            // Call populateLists()
            populateLists();

            // Add the countries to the combobox
            foreach(String c in countryList)
            {
                cbCountry.Items.Add(c);
            }

            // Set the default item to be the first one in the combo box
            cbCountry.SelectedIndex = 0;
        }

        //Method
        public void populateLists()
        {
            // Instantiate cities
            // Malaysian cities
            City cKK = new City("Kota Kinabalu", "Malaysia", 2000000);
            City cKuc = new City("Kuching", "Malaysia", 2000000);

            // UK cities
            City cLon = new City("London", "United Kingdom", 2000000);
            City cMan = new City("Machester", "United Kingdom", 2000000);

            // NZ cities
            City cDun = new City("Dunedin", "New Zealand", 2000000);
            City CAuc = new City("Auckland", "New Zealand", 2000000);

            // Add them to the city list
            cityList.Add(cKK);
            cityList.Add(cKuc);
            cityList.Add(cLon);
            cityList.Add(cMan);
            cityList.Add(cDun);
            cityList.Add(CAuc);

            // Add the city's country propertie to the country list
            countryList.Add(cKK.CountryName);
            countryList.Add(cLon.CountryName);
            countryList.Add(CAuc.CountryName);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // Clear the listbox
            lbCities.Items.Clear();

            // Func will accept 2 strings and return a bool
            // The 2 strings will be comapred to check if they are the same
           /* Func<string, string, bool> displayCity = (a, b) => a.Equals(b);

            // Adds the city name to the listbox if country name of city and country name from combobox matches
            foreach (City c in cityList)
            {
                if(displayCity(c.CountryName, cbCountry.SelectedItem.ToString()))
                {
                    lbCities.Items.Add(c.CityName);
                }
            }*/

            Func<List<City>, string, List<City>> searchedByCountry = (cities, country) => cities.FindAll(c => c.CountryName.Equals(country));
            
            List<City> searchedCities = searchedByCountry(cityList, cbCountry.SelectedItem.ToString());

            foreach (City c in searchedCities)
            {
                lbCities.Items.Add(c.CityName);
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            // Clear the listbox
            lbPop.Items.Clear();

            cityList.ForEach(c => c.Population *= 3);
            cityList.ForEach(c => lbPop.Items.Add(c.ToString()));
        }
    }
}
