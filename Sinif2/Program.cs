using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Employee-1");
            Employee emp1 = new Employee();
            emp1.Name = "Lale";
            emp1.Surname = "Erikli";
            emp1.EmployeeInfos();

            Console.WriteLine();
            Console.WriteLine("Employee-2");
            Employee emp2 = new Employee();
            emp2.Name = "Uğur";
            emp2.Surname = "Saltık";
            emp2.EmpNo = "231654";
            emp2.Department = "Human Resources";
            emp2.EmployeeInfos();

            Console.WriteLine();
            Console.WriteLine("Employee-3");
            Employee emp3 = new Employee("Yavuz", "Karabahçe", "845215", "Administration");
            emp2.EmployeeInfos();
        }
    }

    class Employee
    {
        public string Name;
        public string Surname;
        public string EmpNo;
        public string Department;

        public void EmployeeInfos()
        {
            Console.WriteLine("Employee {0}\nName: {1}\nSurname: {2}\nDepartment: {3}", EmpNo, Name, Surname, Department);
        }

        public Employee()
        {
            Name = "non-name";
            Surname = "non-surname";
            EmpNo = "non-employee-no";
            Department = "non-department";
        }

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public Employee(string name, string surname, string empNo, string department)
        {
            this.Name = name;
            this.Surname = surname;
            this.EmpNo = empNo;
            this.Department = department;
        }

    }
}