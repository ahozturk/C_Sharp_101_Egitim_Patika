using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] colors = new string[]{"Red", "Blue", "Green", "Purple", "Pink", "Gray"};
            for(int i = 1; i <= colors.Length; i++){
                Console.WriteLine(i + ": " + colors[i - 1]);
            }
            Console.Write("Please select a color: ");
            int selecedColor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Color selected: " + colors[selecedColor - 1]);
            Console.WriteLine();

            */
            Console.Write("Please enter how much you will enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[n];
            for(int i  = 0; i < n; i++){
                Console.Write("Number " + i + ": ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            foreach(var number in numbers){
                sum += number;
            }
            float average = float.Parse(sum.ToString()) / numbers.Length; //average can contains fractions for this I converted int to float
            Console.WriteLine(average);
        }
    }
}