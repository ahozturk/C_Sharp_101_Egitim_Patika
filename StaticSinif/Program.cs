using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person person1 = new Person();
            person1.name = "Hakan";

            Person person2 = new Person("Işık");

            Console.WriteLine("Person Count: " + Person.PersonCount);

            Person person3 = new Person("Can");
            Person person4 = new Person("Arzu");
            Person person5 = new Person("Deniz");

            Console.WriteLine("Person Count: " + Person.PersonCount);

            Console.WriteLine("Sum 10 + 15 = " + Calculate.Sum(10, 15));
            Console.WriteLine("Substruction 10 - 15 = " + Calculate.Substruction(10, 15));

        }
    }

    static class Calculate
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Substruction(int a, int b)
        {
            return a - b;
        }
    }


    class Person
    {
        private static int personCount;
        public static int PersonCount { get => personCount; set => personCount = value; }
        public string name;


        static Person()
        {
            PersonCount = 0;
        }

        public Person(string _name)
        {
            name = _name;
            PersonCount++;
        }

        public Person()
        {
            PersonCount++;
        }
    }

}