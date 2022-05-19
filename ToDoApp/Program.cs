using System;

namespace ToDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operation operation = new Operation();
            Console.WriteLine("App Started!\n**************");

            while(true)
            {
                Console.WriteLine("(1) List Board\n(2) Add Chart\n(3) Delete Chart\n(4) Move Chart");
                int input = Input.InputInt("Select Operation");

                switch(input)
                {
                    case 1:
                        operation.List();
                        break;
                    case 2:
                        operation.Add();
                        break;
                    case 3:
                        operation.Remove();
                        break;
                    case 4:
                        operation.Move();
                        break;
                    default:
                        Console.WriteLine("Please enter valid answer.");
                        break;
                }
            }
        }
    }
}