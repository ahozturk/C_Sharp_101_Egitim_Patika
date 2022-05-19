using System;

namespace Phonebook // Note: actual namespace depends on the project name.
{
    class PersonEntity
    {
        public PersonEntity((string, string, string) p)
        {
            Name = p.Item1;
            Surname = p.Item2;
            Number = p.Item3;
        }

        private string name;
        public string Name { get => name; set => name = value; }
        private string surname;
        public string Surname { get => surname; set => surname = value; }
        private string number;
        public string Number { get => number; set => number = value; }
    }
}