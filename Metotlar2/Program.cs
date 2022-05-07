using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //out parameter
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();

            if(int.TryParse(input, out int result))
                Console.WriteLine("Convert Successful!\nYour number: " + result);
            else
                Console.WriteLine("Convert Fail!");

            int r = 4;
            CircleSurface(r, out double res);
            Console.WriteLine("Circles Area (r = 4): " + res);
            
            //Method Overload
            (string, int) prod1 = ("Lenovo 2 - TR", 12000);
            (string, int) prod2 = ("Lenovo 2 - USA", 300);

            Console.WriteLine(Price(prod1.Item1, prod1.Item2, "UGF"));
            Console.WriteLine(Price(prod1.Item1, prod1.Item2, prod2.Item1, prod2.Item2, "EUR"));
        }

        static void CircleSurface(int r, out double s)
        {
            s = Math.Pow(r, 2) * Math.PI; //r2 * pi
        }

        static string Price(string prodName1, int price1)
        {
            return prodName1 + ": " + price1 + " TL";
        }
        static string Price(string prodName1, int price1, string unit)
        {
            return prodName1 + ": " + price1 + " " + unit;
        }
        static string Price(string prodName1, int price1, string prodName2, int price2)
        {
            return prodName1 + ": " + price1 + " TL  | " + prodName2 + ": " + price2 + " TL ";
        }
        static string Price(string prodName1, int price1, string prodName2, int price2, string unit)
        {
            return prodName1 + ": " + price1 + " " + unit + " | " + prodName2 + ": " + price2 + " " + unit;
        }
    }
}