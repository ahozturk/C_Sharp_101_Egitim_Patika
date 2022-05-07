using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int n = ReadNumber("Please enter how many you want to enter: ");
                if (n < 1)
                {
                    Console.WriteLine("You selected min value (1)");
                    n = 1;
                }
                
                int m = ReadNumber("Please enter your referance number: ");
                int[] array = new int[n];

                for(int i = 0; i < n; i++)
                {
                    array[i] = ReadNumber("Enter" + (i + 1) + ". number: ");
                }

                foreach(var i in array)
                {
                    if(i % m == 0)
                    {
                        Console.WriteLine(i);
                    }
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
    }

    
}