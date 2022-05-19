using System;

namespace Phonebook // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuControl.WelcomeMessage();
            Persons.Init();
            Console.WriteLine("App Started");


            while(true)
            {
                MenuControl.ShowMainManu();

                InputControl.MainManuInput();
            }
            
        }
    }
}