using System;

namespace Return_Values
{
    internal class Program
    {
        static string GetMyName()
        {
            return "Ahmed Mohammed";
        }
        static void Main(string[] args)
        {

            Console.WriteLine("My Name is {0}", GetMyName());


            Console.ReadKey();

        }
    }
}
