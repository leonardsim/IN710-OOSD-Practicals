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
    }
}
