using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("---Student---");
            Student st1 = new Student("Hakan", "Öztürk", "426", 12);
            st1.StudentInfos();

            Console.WriteLine();
            Console.WriteLine("---Student---");
            Student st2 = new Student("Jale", "Kadayıfçı", "221", 2);
            st2.StudentInfos();
            st2.Downgrade();
            st2.StudentInfos();
            st2.Downgrade();
            st2.StudentInfos();


        }
    }

    class Student
    {
        private string name;
        private string surname;
        private int grade;
        private string no;

        public string Name {get => name; set => name = value;}
        public string Surname { get => surname; set => surname = value; }
        public int Grade { get => grade;
            set 
            {
                if(value < 1)
                {
                    Console.WriteLine("---");
                    Console.WriteLine("Minimum grade value is 1");
                    Console.WriteLine("---");
                    grade = 1;
                }   
                else 
                    grade = value;
            }
        }
        public string No { get => no; set => no = value; }

        public Student(string name, string surname, string no, int grade)
        {
            this.name = name;
            this.surname = surname;
            this.no = no;
            this.Grade = grade;
        }

        public Student(){}

        public void Downgrade()
        {
            Grade--;
        }

        public void Upgrade()
        {
            Grade++;
        }

        public void StudentInfos()
        {
            Console.WriteLine("Name: {0}\nSurname: {1}\nGrade: {2}\nNo: {3}", Name, Surname, Grade, No);
        }
    }
}