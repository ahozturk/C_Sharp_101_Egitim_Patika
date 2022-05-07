using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("Enter a number: ");
            // int number = Convert.ToInt32(Console.ReadLine());

            // for(int i = 0; i <= number; i++){
            //     if(i % 2 == 1)
            //         Console.WriteLine(i);
            // }

            // int totalEven = 0;
            // int totalOdd = 0;

            // for(int i = 1; i <= 1000; i++){
            //     totalEven += (i % 2 == 0) ? i : 0;
            //     totalOdd += (i % 2 == 1) ? i : 0;
            // }
            // Console.WriteLine("Total 0 to 1000 even numbers: " + totalEven);
            // Console.WriteLine("Total 0 to 1000 odd numbers: " + totalOdd);


            for(int i = 15; i > 0; i--){
                if(i == 11)
                    continue;
                    // break;
                Console.WriteLine(i);
            }
        }
    }
}