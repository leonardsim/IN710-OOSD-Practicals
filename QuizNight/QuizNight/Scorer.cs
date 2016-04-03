using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizNight
{
    public static class Scorer
    {
        //Methods
        // Returns the adult score
        public static int AdultScore(int correct, int incorrect)
        {
            // declare and inititalise score
            int score = 0;

            // For every correct answer multiply score by 10 and for incorrect, multiply by 1 
            // then deduct both of them
            score = ((correct * 10) - (incorrect * 1));

            return score;
        }
    }
}
