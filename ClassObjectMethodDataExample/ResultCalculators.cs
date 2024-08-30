using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectMethodDataExample
{
    internal  static class ResultCalculators
    { 

        public static double GetAvgScore(double physicsScore,double mathScore,double chemistryScore)
        {
            int noOfSubjects = 3;
            double total = physicsScore + mathScore + chemistryScore;
            return total / noOfSubjects;
        }
    


    }
}
