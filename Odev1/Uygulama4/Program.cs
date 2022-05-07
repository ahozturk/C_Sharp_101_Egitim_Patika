using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a sentence: ");
            string input = Console.ReadLine();
            int letterCount = 0, wordCount = 1;
            bool isLastLetter = true;
            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] != ' ')
                {
                    isLastLetter = true;
                    letterCount++;
                }
                if(isLastLetter && input[i] == ' ')
                {
                    isLastLetter = false;
                    wordCount++;
                }
            }

            Console.WriteLine("Letter count: " + letterCount);
            Console.WriteLine("Word count: " + wordCount);
        }
    }
}