using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherStation
{
    public partial class Form1 : Form
    {
        //Declare subject and observers
        WeatherSubject sub;
        CurrentObserver cO;
        AverageObserver aO;
        ForecastObserver fO;

        public Form1()
        {
            InitializeComponent();

            // Inititalise them
            sub = new WeatherSubject();
            cO = new CurrentObserver(lbCurrent, sub);
            aO = new AverageObserver(lbAverage, sub);
            fO = new ForecastObserver(lbForecast, sub);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cTemp = Int32.Parse(tbTemp.Text.ToString());
            int cHum = Int32.Parse(tbHumidity.Text.ToString());
            int cPres = Int32.Parse(tbPressure.Text.ToString());

            sub.CurrentTemp = cTemp;
            sub.CurrentHumidity = cHum;
            sub.CurrentPressure = cPres;

            sub.NotifyObservers();
        }
    }
}
