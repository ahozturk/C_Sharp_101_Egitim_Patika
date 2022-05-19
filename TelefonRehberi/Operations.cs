using System;

namespace Phonebook
{
    static class Operations
    {
        static public void CreateNewPerson()
        {
            string name = InputControl.InputString("Please enter name: ");
            string surname = InputControl.InputString("Please enter surname: ");
            string number = InputControl.InputString("Please enter number: ");
            Persons.Add(new PersonEntity((name, surname, number)));
        }

        static public bool DeletePerson()
        {
            string input = InputControl.InputString("Type person name or surname to be deleted");
            int index = IsPersonExist(input);
            if(index == -1)
                return false;
            PersonEntity person = Persons.personList[index];
            Console.WriteLine($"Person deleted {person.Name} {person.Surname} {person.Number}");
            Persons.Delete(person);
            return true;
        }

        static public bool UpdatePerson()
        {
            string input = InputControl.InputString("Type person name or surname to be updated");
            int index = IsPersonExist(input);
            if(index == -1)
                return false;
            string name = InputControl.InputString("Please enter name: ");
            string surname = InputControl.InputString("Please enter surname: ");
            string number = InputControl.InputString("Please enter number: ");
            Persons.Update(new PersonEntity((name, surname, number)), index);
            return true;
        }

        static public void ListPersons()
        {
            Console.WriteLine("Persons:");
            foreach(var i in Persons.personList)
            {
                Console.WriteLine("Name: " + i.Name + " \t| Surname: " + i.Surname + " \t| Number: " + i.Number);
            }
            Console.WriteLine("List End \n");
        }

        static public bool SearchPerson()
        {
            string inputStr = "";
            while(true)
            {
                int input = InputControl.InputInt("Search with name (1)\nSearch with surname (2)\nQuit (3)");
                if(input == 1)
                {
                    inputStr = InputControl.InputString("Enter name");
                    break;
                }
                else if(input == 2)
                {
                    inputStr = InputControl.InputString("Enter surname");
                    break;
                }
                else if(input == 3)
                {
                    return false;
                }
                Console.WriteLine("Please enter exist answer!");
            }
            //if(input == 3) return false;
            
            PersonEntity person = Persons.personList[IsPersonExist(inputStr)];

            Console.WriteLine();
            Console.WriteLine("Searched Person:");
            Console.WriteLine("Name: {0}\nSurname: {1}\nNumber: {2}", person.Name, person.Surname, person.Number);
            Console.WriteLine();
            return true;
        }

        static private int IsPersonExist(string input)
        {
            foreach(var person in Persons.personList)
            {
                if(person.Name.ToLower() == input.ToLower() || person.Surname.ToLower() == input.ToLower() || (person.Name + person.Surname).ToLower() == input.Replace(" ", "").ToLower())
                {
                    return Persons.personList.IndexOf(person);
                }
            }
            Console.WriteLine($"Person name or surname: {input} couldn't find!\n");
            return -1;
        }
    }
}