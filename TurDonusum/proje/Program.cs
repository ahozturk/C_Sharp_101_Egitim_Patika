using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inplicit
            Console.WriteLine("Hello World!");

            byte b = 150;

            short s = b;

            int i = s + b;

            long l = i;

            //Explicit

            long el = 30000;
            int ei = (int)el;

            short es = (short)ei;

            string yazi = "400";

            short q = Convert.ToInt16(yazi);

            int qu = Convert.ToInt32("604");
        }
    }
}