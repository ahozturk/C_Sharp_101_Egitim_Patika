using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentences: ");
            string input = Console.ReadLine();
            char[] vowelChars = new char[] {'e', 'u', 'o', 'a', 'i', 'ü', 'ı', 'ö'};

            List<char> vowels = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if(vowelChars.Contains(Convert.ToChar(input[i].ToString().ToLower())))
                {
                    vowels.Add(input[i]);
                    Console.WriteLine("Added: " + input[i]);

                }
            }
            
            for(int i = 0; i < vowels.Count; i++)
            {
                Console.WriteLine(vowels[i]);
            }
        }
    }
}