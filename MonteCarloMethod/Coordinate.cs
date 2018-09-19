using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MonteCarloMethod.Program;

namespace MonteCarloMethod
{


    public struct Coordinate
    {

        private double x, y;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        //public double X { get; set; }
        // public double Y { get; set; }

        public Coordinate(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Coordinate(Random random)
        {
            this.x = random.NextDouble();
            this.y = random.NextDouble();

        }
        public double Hypotenuse()
        {
            return Math.Sqrt(Math.Pow(this.X, 2) + Math.Pow(this.Y, 2));
        }
    }
}

    //square root of x^2 + y^2


