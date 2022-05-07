using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = ReadNumber("Type how many character do you want enter: ");

            if(n < 1)
            {
                Console.WriteLine("You selected min value (1)");
                n = 1;
            }

            char[] array = new char[n];

            for(int i = n - 1; i >= 0; i--)
            {
                array[i] = ReadChar("Enter " + (n - i) + ". character: ");
            }

            foreach(var i in array)
            {
                Console.WriteLine(i);
            }

        }

        static int ReadNumber(string msg)
        {
            while(true)
            {
                Console.Write(msg);
                int n;
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    return n;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Please just enter a number!");
                }
            }
        }

        static char ReadChar(string msg)
        {
            while(true)
            {
                Console.Write(msg);
                char n;
                try
                {
                    n = Convert.ToChar(Console.ReadLine());
                    return n;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Please just enter a character!");
                }
            }
        }
    }
}