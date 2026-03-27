using System;


namespace Set_Date___Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //assigns default value 01/01/0001 00:00:00
            DateTime d1 = new DateTime();

            //assigns Year ,Month ,Day
            DateTime d2 = new DateTime(2023,12,31);


            //assigns Year ,Month ,Day,Hour ,Min,Seconds
            DateTime d3 = new DateTime(2023, 12, 31,5,10,20);


            //assigns Year ,Month ,Day ,Hour,Min,Seconds,UTC timezone
            DateTime d4 = new DateTime(2023, 12, 31,5,10,20,DateTimeKind.Utc);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
           

            Console.ReadKey();



        }
    }
}
