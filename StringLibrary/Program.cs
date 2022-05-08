using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "My String Class String";
            string text2 = "mY String Class";

            Console.WriteLine("Text Lenght: " + text.Length);

            Console.WriteLine("Text Upper Case: " + text.ToUpper());
            Console.WriteLine("Text Lower Case: " + text.ToLower());

            Console.WriteLine("Text Concat: " + String.Concat(text, ", Welcome!"));

            Console.WriteLine("Text CompareTo: " + text.CompareTo(text + text2));
            Console.WriteLine("Text Compare (Case Ignored): " + String.Compare(text, text2));
            Console.WriteLine("Text Compare (Case Enabled): " + String.Compare(text, text2, true));

            string msg = "Welcome our new application!";
            string word = "NEW";
            Console.WriteLine("Mesage contains \"" + word + "\" word: " + msg.Contains(word, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Text StartsWith: " + text.StartsWith("Hello"));
            Console.WriteLine("Text EndsWith: " + text.EndsWith("VC"));

            Console.WriteLine("Text IndexOf \"Str\": " + text.IndexOf("Str"));
            Console.WriteLine("Text LastIndexOf \"Str\": " + text.LastIndexOf("Str"));

            Console.WriteLine("Text Insert \"Str\": " + text.Insert(3, "Str"));

            string x = "Hakan";
            string y = "Ugur";

            Console.WriteLine("X + Y PadLeft(6): " + x + y.PadLeft(5));
            Console.WriteLine("X + Y PadRight(8): " + x.PadRight(8, '-') + y);

            Console.WriteLine("Text Remove(4): " + text.Remove(4));
            Console.WriteLine("Text Remove(4, 3 char): " + text.Remove(4, 3));

            Console.WriteLine("Text Replace(Str to SSS): " + text.Replace("Str", "SSS"));

            Console.WriteLine("Text Split(' '): " + text.Split(' ')[0]);
            
            Console.WriteLine("Text Substring(5, 2 char): " + text.Substring(5, 2));
            
        }
    }
}