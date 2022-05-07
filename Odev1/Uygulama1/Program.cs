using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = ReadNumber("Type how many numbers you want to enter: ");
            int[] array = new int[n];
            for(int i = 0; i < n; i++)
            {
                array[i] = ReadNumber("Enter " + (i + 1) + ". number: ");
            }       
            foreach(var i in array)
            {
                if(i % 2 == 0) Console.WriteLine(i);
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