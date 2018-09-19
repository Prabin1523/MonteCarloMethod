using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MonteCarloMethod
{
    class Program
    {
       

        static void Main(string[] args)
        {

            try
            {

                Console.WriteLine("Enter a number: ");
                int arrayLength = Convert.ToInt32(Console.ReadLine());
                Coordinate[] arrayOfCoordinate = new Coordinate[arrayLength];
                Random random = new Random();
                int counter = 0;
                for (int i = 0; i < arrayLength; i++)
                {
                    arrayOfCoordinate[i] = new Coordinate(random);
                    if (arrayOfCoordinate[i].Hypotenuse() <= 1)
                    {
                        counter++;
                    }
                }

                double avg = (counter / (double)arrayOfCoordinate.Length) * 4;
                Console.WriteLine($"Total # of points overlapping the circle = {counter}");
                Console.WriteLine($"generated pi = {avg}, real pi = {Math.PI}, difference = {Math.Abs(Math.PI - avg) }");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();

            }
        }



    }





}


