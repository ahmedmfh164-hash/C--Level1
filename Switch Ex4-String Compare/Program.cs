using System;

namespace Switch_Ex4_String_Compare
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Name = "Ahmed";

            //You can compare string as well using switch
            switch (Name.ToLower())
            {
                case "ahmed":

                    Console.WriteLine("Yes Ahmed");
                    break;

                case "ali":

                    Console.WriteLine("Yes ALi");
                    break;

                default:
                    Console.WriteLine("No Name Matched!");
                    break;

            }

            Console.ReadKey();

        }
    }
}
