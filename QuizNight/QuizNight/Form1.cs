using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizNight
{
    public partial class Form1 : Form
    {
        // Declare delegate type 
        public delegate int ScoreDelegate(int correct, int incorrect);
        ScoreDelegate scoreComputer;

        public Form1()
        {
            InitializeComponent();
        }

        // Instantiate the delegate and pass the Scorer methods. 
        // Set the score to the score label
        private void DelegateScore()
        {
            scoreComputer = null;

            if (rdoAdult.Checked)
            {
                scoreComputer = new ScoreDelegate(Scorer.AdultScore);
            }
            else if (rdoChild.Checked)
            {
                scoreComputer = new ScoreDelegate(Scorer.ChildScore);
            }
            else
            {
                MessageBox.Show("Please pick a team!");
            }

            // Parse text to int
            int correctAns = Int32.Parse(txtCorrect.Text.ToString());
            int incorrectAns = Int32.Parse(txtIncorrect.Text.ToString());

            // Pass correct and incorrect answer as arguement to the delegate and 
            // save it as result value
            int result = scoreComputer(correctAns, incorrectAns);

            // Set the result to the score label
            lblScore.Text = "Score: " + result;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            DelegateScore();
        }
    }
}
