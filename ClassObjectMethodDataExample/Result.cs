using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectMethodDataExample
{
    internal class Result
    {

        public double MathScore { get; set; }
        public double PhysicsScore { get; set; }
        public double ChemistryScore {  get; set; }
        public Double GetAvgScore()
        {
            return ResultCalculators.GetAvgScore(MathScore, PhysicsScore,ChemistryScore);
        }

    }
}
