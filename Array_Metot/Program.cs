using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Unsorted Array");
            int[] arr = new int[] { 9, 4, 16, 3, 19 };
            Write(arr);
            Console.WriteLine();

            Console.WriteLine("Sorted Array");
            Array.Sort(arr);
            Write(arr);
            Console.WriteLine();

            Console.WriteLine("Clear Array");
            Array.Clear(arr, 2, 3);
            Write(arr);
            Console.WriteLine();

            Console.WriteLine("Reverse Array");
            Array.Reverse(arr);
            Write(arr);
            Console.WriteLine();

            Console.WriteLine("IndexOf Array");
            Console.WriteLine(Array.IndexOf(arr, 4));
            Console.WriteLine();

            Console.WriteLine("Resize Array");
            Console.WriteLine("Array Size: " + arr.Length);
            Array.Resize<int>(ref arr, 7);
            Console.WriteLine("Array New Size: " + arr.Length);
            Console.WriteLine();
        }

        static void Write(int[] arr)
        {
            foreach (var number in arr)
            {
                Console.Write(number + ", ");
            }
        }
    }
}