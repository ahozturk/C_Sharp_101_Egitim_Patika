using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Second day on week: " + Days.Tuesday);
            
            float heat = -5.3f;

            if(heat < (int)Weather.TooCold)
                Console.WriteLine("Don't go out else you can be an ice!");
            else if (heat < (int)Weather.Cold)
                Console.WriteLine("It's cold!");
            else if (heat < (int)Weather.Normal)
                Console.WriteLine("It's cool, but don't worry.");
            else if (heat < (int)Weather.Hot)
                Console.WriteLine("It's soo good for go out!");
            else
                Console.WriteLine("Maybe little bit warm.");
        }
    }
    enum Days
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum Weather
    {
        TooCold = 0,
        Cold = 10,
        Normal = 20,
        Hot = 28
    }

}