using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("Hakan");
            list.Add(12.5f);
            list.Add(false);
            list.Add('i');

            string[] Comps = {"Lenovo", "Asus", "AMD", "Intel"};

            list.AddRange(Comps);
            


            list.Clear();
            List<int> listAdd = new List<int>(){5,2,12,6,3,8};
            list.AddRange(listAdd);

            list.Sort();


            Console.WriteLine("Binary Search 3.Index: " + list.BinarySearch(3));

            list.Reverse();
            
            for(int i = 0; i < list.Count; i++)
                Console.WriteLine($"{i}.index: {list[i]}");
        }
    }
}