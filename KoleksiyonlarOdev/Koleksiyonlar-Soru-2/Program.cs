using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an array: ");
            int size = 8;

            //int[] inputArr = new int[] {7,2,52,4,1,9,6,4};

            
            int[] inputArr = new int[size];
            
            for(int i = 0; i < size; i++)
            {
                try
                {
                    Console.Write($"Enter {i + 1}.number: ");
                    inputArr[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Just enter positive numbers!");
                    i--;
                    continue;
                }
            }
            
            int[] maxs = new int[] {inputArr[0], inputArr[1], inputArr[2] };
            int[] mins = new int[] {inputArr[0], inputArr[1], inputArr[2] };
            
            List<int> copy;
            copy = inputArr.ToList();

            for(int i = 0; i < maxs.Length; i++)
            {
                maxs[i] = copy.Max();
                copy.Remove(copy.Max());
            }

            copy = inputArr.ToList();

            for(int i = 0; i < mins.Length; i++)
            {
                mins[i] = copy.Min();
                copy.Remove(copy.Min());
            }

            for(int i = 0; i < maxs.Length; i++)
                Console.WriteLine("maxs: " + maxs[i]);
            for(int i = 0; i < mins.Length; i++)
                Console.WriteLine("mins: " + mins[i]);
        }
    }
}