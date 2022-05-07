using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Recursive
            Console.Write("Calculate factorial: ");
            int input = int.Parse(Console.ReadLine());
            int result = 1;
            for(int i = input; i > 1; i--)
            {
                result *= i;
            }
            Console.WriteLine("Result: " + result);

            transactions tr = new();
            Console.WriteLine(tr.factorial(input));

            //Extentions
            string a = "Ha kan Özt ürk".DeleteSpace().UpCase();
            Console.WriteLine(a);

            int[] arr = new int[] { 2, 4, 1, 3, 8, 6 };
            foreach(var i in arr.SortArr())
                Console.Write(i + " ");

            "".PrintScreen();
            "Selamlar".PrintScreen();
        }
    }

    public static class Extentions
    {
        public static void PrintScreen(this string p)
        {
            Console.WriteLine(p);
        }
        public static int[] SortArr(this int[] p)
        {
            int[] i = p;
            Array.Sort(i);
            return i;
        }

        public static string DeleteSpace(this string p)
        {
            return p.Replace(" ", "");
        }

        public static string UpCase(this string p)
        {
            return p.ToUpper();
        }
    }

    class transactions
    {
        public int factorial(int i)
        {
            return factorial(i, i - 1);
        }

        int factorial(int org, int j)
        {
            return j <= 1 ? org : factorial(org * j, j - 1);
        }
    }
}