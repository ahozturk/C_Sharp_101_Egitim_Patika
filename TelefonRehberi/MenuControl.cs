using System;

namespace Phonebook // Note: actual namespace depends on the project name.
{
    static class MenuControl
    {
        static public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Phonebook!");
        }

        static public void ShowMainManu()
        {
            Console.WriteLine("You can select an operation:\n\n(1) Create new person\n(2) Delete exist person\n(3) Update person\n(4) List persons\n(5) Search person\n");
        }
    }
}