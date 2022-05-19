using System;

namespace Phonebook // Note: actual namespace depends on the project name.
{
    static class InputControl
    {

        static public int InputInt(string message)
        {
            Console.Write(message + ": ");
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("You can only enter valid answers!\n");
                return -1;
            }
        }

        static public string  InputString(string message)
        {
            Console.Write(message + ": ");
            return Console.ReadLine();
        }

        static public bool MainManuInput()
        {
            int input = InputInt("Select operation");
            CallOperation(input);
            return true;
        }

        static private void CallOperation(int i)
        {
            switch (i)
            {
                case 1:
                    Operations.CreateNewPerson();
                    break;
                case 2:
                    Operations.DeletePerson();
                    break;
                case 3:
                    Operations.UpdatePerson();
                    break;
                case 4:
                    Operations.ListPersons();
                    break;
                case 5:
                    Operations.SearchPerson();
                    break;
                default:
                    Console.WriteLine("You can only enter valid answers!");
                    break;
            }
        }
    }
}