using System;

namespace Escape_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Useful Escape Characters : \n");

            //Newline
            Console.WriteLine("NewLine : ");
            Console.WriteLine("Welcome to\nProgramming Advices\n");

            //Tab
            Console.WriteLine("Tab : ");
            Console.WriteLine("Welcome to\tProgramming Advices\n");

            //Backspace
            Console.WriteLine("Backspace : ");
            Console.WriteLine("Welcome to \bProgramming Advices\n");

            //Single quote
            Console.WriteLine("Single Quote : \n");
            Console.WriteLine("Welcome to \' Programming Advices\n");
                                                
            //Double quote
            Console.WriteLine("Double Quote : \n");
            Console.WriteLine("Welcome to \" Programming Advices\n");

            //Backslash
            Console.WriteLine("Backslash : \n");
            Console.WriteLine("Welcome to \\ Programming Advices\n");

            //Alert
            Console.WriteLine("Alert : \n");
            Console.WriteLine("\a");

            Console.ReadKey();
        }
    }
}
