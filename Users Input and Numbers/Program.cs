using System;


namespace Users_Input_and_Numbers
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter your age?");
            //if you dont convert you will get error, and if you enter string you will get error
            int age = int.Parse(Console.ReadLine());
            //or int age = Console.Int32(Console.ReadLine());

            Console.WriteLine("Your age is: " + age);


            Console.ReadKey();

        }
    }
}
