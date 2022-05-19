using System;

namespace ToDo
{
    static public class Input
    {
        public static string InputString(string msg)
        {
            Console.Write(msg + ": ");
            return Console.ReadLine();
        }

        public static int InputInt(string msg)
        {
            Console.Write(msg + ": ");
            int input;
            try
            {
                input = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ex)
            {
                return -1;
            }
            return input;
        }

        public static int InputInt(string msg, int min, int max)
        {
            Console.Write(msg + ": ");
            int input;
            try
            {
                input = Convert.ToInt32(Console.ReadLine());
                if(!(min <= input && input <= max))
                    return -1;
            }
            catch(Exception ex)
            {
                return -1;
            }
            return input;
        }
    }
}