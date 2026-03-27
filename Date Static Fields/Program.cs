using System;


namespace Date_Static_Fields
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime= DateTime.Now;//returns current date and time
            DateTime todaysDate = DateTime.Today;  //returns today's date
            DateTime currentDateTimeUTC= DateTime.UtcNow;//returns current UTC date and time
            DateTime maxDateTimeValue= DateTime.MaxValue;//returns max value of DateTime
            DateTime minDateTimeValue= DateTime.MinValue;//returns min value of DateTime

            Console.WriteLine("Current DateTime : "+currentDateTime);
            Console.WriteLine("Today DateTime : "+todaysDate);
            Console.WriteLine("Current DateTime UTC : "+currentDateTimeUTC);
            Console.WriteLine("Min DateTime Value : "+minDateTimeValue);
            Console.WriteLine("Max DateTime Value : "+maxDateTimeValue);

            Console.ReadKey();
        }
    }
}
