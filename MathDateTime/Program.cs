using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Now: " + DateTime.Now);
            Console.WriteLine("Now Date: " + DateTime.Now.Date);

            Console.WriteLine("Now Day: " + DateTime.Now.Day);
            Console.WriteLine("Now Month: " + DateTime.Now.Month);
            Console.WriteLine("Now Year: " + DateTime.Now.Year);

            Console.WriteLine("Now Time: " + DateTime.Now.Hour + "." + DateTime.Now.Minute + "." + DateTime.Now.Second);

            Console.WriteLine("Now Day of Week: " + DateTime.Now.DayOfWeek);
            Console.WriteLine("Now Day of Year: " + DateTime.Now.DayOfYear);

            Console.WriteLine("Now Long Date: " + DateTime.Now.ToLongDateString());
            Console.WriteLine("Now Short Date: " + DateTime.Now.ToShortDateString());

            Console.WriteLine("Now Long Time: " + DateTime.Now.ToLongTimeString());
            Console.WriteLine("Now Short Time: " + DateTime.Now.ToShortTimeString());

            Console.WriteLine("Future 10 Days 7 Hours: " + DateTime.Now.AddDays(10).AddHours(7));
            
            //Format
            
            Console.WriteLine("dd: " + DateTime.Now.ToString("dd"));
            Console.WriteLine("ddd: " + DateTime.Now.ToString("ddd"));
            Console.WriteLine("dddd: " + DateTime.Now.ToString("dddd"));

            Console.WriteLine("MM: " + DateTime.Now.ToString("MM"));
            Console.WriteLine("MMM: " + DateTime.Now.AddMonths(4).ToString("MMM"));
            Console.WriteLine("MMMM: " + DateTime.Now.AddMonths(4).ToString("MMMM"));

            Console.WriteLine("yy: " + DateTime.Now.ToString("yy"));
            Console.WriteLine("yyyy: " + DateTime.Now.ToString("yyyy"));

            //Math

            Console.WriteLine("Abs -23: " + Math.Abs(-23));

            Console.WriteLine("Ceiling 2.3 : " + Math.Ceiling(2.3));
            Console.WriteLine("Round 2.9 : " + Math.Round(2.9));
            Console.WriteLine("Round 2.3 : " + Math.Round(2.3));
            Console.WriteLine("Floor 2.9 : " + Math.Floor(2.9));

            Console.WriteLine("Min 4, 7 : " + Math.Min(4, 7));
            Console.WriteLine("Max 4, 7 : " + Math.Max(4, 7));
            Console.WriteLine("Pow 2, 6 : " + Math.Pow(2, 6));
            Console.WriteLine("Sqrt 25 : " + Math.Sqrt(25));

            Console.WriteLine("Log 12 : " + Math.Log(9));
            Console.WriteLine("Exp 4 : " + Math.Exp(4));
            Console.WriteLine("Log10 100 : " + Math.Log10(100));





        }
    }
}