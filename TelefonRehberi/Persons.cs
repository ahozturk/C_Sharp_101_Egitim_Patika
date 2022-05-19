using System;

namespace Phonebook // Note: actual namespace depends on the project name.
{
    static class Persons
    {
        public static List<PersonEntity> personList;
        static Persons()
        {
            personList = new List<PersonEntity>();

            PersonEntity per1 = new PersonEntity(("Hakan",  "Öztürk", "156450"));
            PersonEntity per2 = new PersonEntity(("Hülya",  "Işık", "2312308"));
            PersonEntity per3 = new PersonEntity(("Tuana",  "Oğuz", "8456210"));
            PersonEntity per4 = new PersonEntity(("Emin",  "Karaahmet", "3250450"));
            PersonEntity per5 = new PersonEntity(("Münir",  "Karaca", "7241020"));

            Persons.Add(per1);
            Persons.Add(per2);
            Persons.Add(per3);
            Persons.Add(per4);
            Persons.Add(per5);
        }

        static public bool Init()
        {
            return personList.Count > 0;
        }

        static public void Add(PersonEntity p)
        {
            personList.Add(p);
        }

        static public void Update(PersonEntity p, int index)
        {
            personList[index] = p;
        }

        static public void Delete(PersonEntity p)
        {
            if(InputControl.InputString($"{p.Name} deleting are you sure y/n").ToLower() == "y")
                personList.Remove(p);
        }
    }
}