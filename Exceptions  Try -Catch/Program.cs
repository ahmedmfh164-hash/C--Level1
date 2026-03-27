using System;
using System.Collections.Generic;

namespace Exceptions__Try__Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> myNumbers =new List<int> {1,2};
                Console.WriteLine(myNumbers[1]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

        }
    }
}
