using System;


namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Ahmed Mohamed";
                      Console.WriteLine(MyName);

            int x = 10; int y=20;
            Console.WriteLine("x = "+x);
            Console.WriteLine("y = "+y);

            //this line will give wrong answer :-)
            Console.WriteLine("x + y = "+x+y);

            //this line will give right answer :-)
            Console.WriteLine("x + y = "+(x+y));

            //other common data types
            double MyDouble = 25.890;
            Console.WriteLine("Double : "+MyDouble);

            char MyLetter = 'M';
            Console.WriteLine("Letter : "+MyLetter);

            bool MyBool = true;
            Console.WriteLine("Bool : "+MyBool); 

            Console.ReadKey();


        }
    }
}
