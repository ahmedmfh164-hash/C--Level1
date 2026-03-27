using System;

namespace Default_Parameter_Value
{
    internal class Program
    {
        static void PrintMyInfo(string Name, byte Age, string Address = "No Address")
        {
            Console.WriteLine("Name= {0} , Age= {1}, Address= {2}", Name, Age, Address);
        }
        static void Main(string[] args)
        {

            //First we did not provide the address it's optional
            PrintMyInfo("Ahmed Mohammed", 45);

            //second we provided the address
            PrintMyInfo("Ahmed Mohammed", 45, "Eygpt");

            Console.ReadKey();

        }
    }
}
