using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Hakan");
            dict.Add(2, "Yavuz");
            dict.Add(5, "Tuana");
            
            foreach (var a in dict)
                Console.WriteLine(a);
            
            Console.WriteLine($"Dictionary item count: {dict.Count}");
            Console.WriteLine($"Is there 3 in key: {dict.ContainsKey(3)}");


        }
    }
}