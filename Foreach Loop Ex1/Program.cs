using System;

namespace Foreach_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] myArray = { 'H', 'e', 'l', 'l', 'o' };

            foreach (char ch in myArray)
            {
                Console.WriteLine(ch);
            }

            Console.ReadKey();

        }
    }
}
