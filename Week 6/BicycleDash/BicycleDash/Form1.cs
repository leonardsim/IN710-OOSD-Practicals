using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleDash
{
    public partial class Form1 : Form
    {
        SpeedMonitorSubject subject;
        BicycleObserver rpm;
        BicycleObserver calories;
        BicycleObserver kilometeres;
        int userInput; 


        public Form1()
        {
            InitializeComponent();

            subject = new SpeedMonitorSubject();

            rpm = new RPMObserver(lblRPM, subject);
            calories = new CaloriesObserver(lblCalories, subject);
            kilometeres = new KilometerObserver(lblKms, subject);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            userInput = Int32.Parse(TextBox1.Text);

            subject.CurrentRPM = userInput;

            subject.NotifyObservers();
        }


    }
}
