using System;


namespace Explicit_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double myDouble = 17.58;
            int myInt = (int)myDouble;    // Manual casting: double to int

            Console.WriteLine(myDouble);   // Outputs 17.58
            Console.WriteLine(myInt);      // Outputs 17

            myDouble =(double)myInt;
            Console.WriteLine(myDouble);

            Console.ReadKey();
        }
    }
}
