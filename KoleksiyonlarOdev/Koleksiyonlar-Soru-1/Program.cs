using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList listPrime = new ArrayList();
            ArrayList list = new ArrayList();
            int input;
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Please enter {i + 1}. Item");
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                    if(IsPrime(input))
                        listPrime.Add(input);
                    else
                        list.Add(input);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Please just enter positive number");
                    i--;
                    continue;
                }
            }

            list.Sort();
            list.Reverse();
            int sumList = 0;
            Console.WriteLine("*** Non-Prime ***");
            foreach(var i in list)
            {
                Console.WriteLine(i);
                sumList += (int)i;
            }

            listPrime.Sort();
            listPrime.Reverse();
            int sumListPrime = 0;
            
            Console.WriteLine("*** Prime ***");
            foreach(var i in listPrime)
            {
                Console.WriteLine(i);
                sumListPrime += (int)i;
            }

            Console.WriteLine("Non-Prime count: " + list.Count + " Non-Prime Average: " + (float)sumList / list.Count);
            Console.WriteLine("Prime count: " + listPrime.Count + " Prime Average: " + (float)sumListPrime / listPrime.Count);

        }

        static bool IsPrime(int a)
        {
            for (int i = 2; i < a; i++)
                if(a % i == 0)
                    return false;
            return true;
        }
    }
}