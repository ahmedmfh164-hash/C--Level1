using System;

namespace Named_Arguments
{
    internal class Program
    {
        static void MyMethod(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }

        static void Main(string[] args)
        {

            //see the order of sending parameters is not important.

            MyMethod(child1: "Omar", child3: "Samer", child2: "Hamza");

            Console.ReadKey();

        }
    }
}
