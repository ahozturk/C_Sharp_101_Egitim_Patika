using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metotlar metot = new Metotlar();
            metot.PrintTerminal("Result: " + metot.Sum(4,5));
            int number = 4;
            metot.PrintTerminal("Number Before Add method: " + number);
            metot.AddRef(ref number, 2);
            metot.PrintTerminal("Number After Add method: " + number);

        }

        
    }

    class Metotlar
    {
        public void PrintTerminal(string a)
        {
            Console.WriteLine(a);
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public void AddRef(ref int a, int add)
        {
            a += add;
        }
    }
}