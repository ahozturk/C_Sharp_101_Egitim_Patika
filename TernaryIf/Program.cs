using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true){
                string answer;
                Console.Write("Do you want to continue? (Y/N)");
                string input = Console.ReadLine();
                answer = (input.ToLower() == "y") ? "Loading..." : (input.ToLower() == "n") ? "Proccess canceled." : (input.ToLower() == "q") ? "quit" : "Not accepted answer!";
                
                if (answer != "quit")
                    Console.WriteLine("Answer = " + answer);
                else{
                    Console.WriteLine("Quit");
                    break;
                }
            }
        }
    }
}