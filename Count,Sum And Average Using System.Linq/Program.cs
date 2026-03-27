using System;
using System.Linq;

namespace Count_Sum_And_Average_Using_System.Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Note that we used System.Linq above.

            int[] numbers = { 20, 22, 19, 18, 1 };

            // compute Count
            Console.WriteLine("Count : " + numbers.Count());

            // compute Sum
            Console.WriteLine("Sum : " + numbers.Sum());

            // compute the average
            Console.WriteLine("Average: " + numbers.Average());

            Console.ReadKey();

        }
    }
}
