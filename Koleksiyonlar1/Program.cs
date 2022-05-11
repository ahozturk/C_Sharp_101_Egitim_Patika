using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static List<int> numbers = new List<int>();
        static List<string> colors = new List<string>{"Red", "Green", "Blue", "Orange", "White", "Yellow", "Gray", "Pink", "Purple"};
        static void Main(string[] args)
        {
            numbers.Add(7);
            numbers.Add(2);
            numbers.Add(1);
            numbers.Add(5);
            numbers.Add(3);
            numbers.Add(6);

/*          
            numbers.Remove(7);
            colors.Remove("Blue");
            colors.RemoveAt(colors.Count - 1);
            Print();
*/
            colors.Sort();
            Console.WriteLine(colors.Contains("Blue") ? "There is Blue" : "Nooo, any blue :(");
            foreach (var color in colors)
                Console.WriteLine("Binary search " + color + ": " + colors.BinarySearch(color));


            string[] animals = {"Horse", "Mouse", "Cat", "Dog", "Monkey"};
            List<string> animalsList = animals.ToList();
            animalsList.Clear();

            List<Person> persons = new List<Person>();
            Person per1 = new Person(){Name = "Hakan", Surname = "Öztürk", Age = 17};
            Person per2 = new Person(){Name = "Melisa", Surname = "İşler", Age = 25};
            persons.Add(per1);
            persons.Add(per2);

            persons.ForEach(a => Console.WriteLine("Name: " + a.Name + " " + a.Surname + " | Age: " + a.Age));
        }

        static void Print()
        {
            Console.WriteLine("Numbers Item Count: " + numbers.Count);
            for(int i = 0; i < numbers.Count; i++)
            {
                string print = i < numbers.Count - 1 ? numbers[i] + ", " : numbers[i] + "\n";
                Console.Write(print);
            }

            Console.WriteLine("Colors Item Count: " + colors.Count);
            for(int i = 0; i < colors.Count; i++)
            {
                string print = i < colors.Count - 1 ? colors[i] + ", " : colors[i] + "\n";
                Console.Write(print);
            }


        }
    }

    public class Person
    {
        string name;
        public string Name { get => name; set => name = value; }
        string surname;
        public string Surname { get => surname; set => surname = value; }
        int age;
        public int Age { get => age; set => age = value; }
    }
}