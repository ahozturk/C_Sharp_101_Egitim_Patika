using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Name = "Hakan";
            emp1.Surname = "Öztürk";
            emp1.EmpNo = "54016542";
            emp1.Department = "I.T.";
            emp1.EmployeeInfos();

            Console.WriteLine("---");

            Employee emp2 = new Employee();
            emp2.Name = "Tarık";
            emp2.Surname = "Tüfekçi";
            emp2.EmpNo = "7541234";
            emp2.Department = "H.R.";
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
            Console.WriteLine("Name: {0}\nSurname: {1}\nEmpNo: {2}\nDepartment: {3}", Name, Surname, EmpNo, Department);
        }
    }
}