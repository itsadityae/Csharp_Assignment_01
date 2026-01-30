using System;
using System.Collections.Generic;
using System.Text;

namespace Eslavath_Aditya_assignment_Csharp
{
    abstract class Employee
    {
        public int EmployeeId;
        public string EmployeeName;
        public string Address;
        public string City;
        public string Department;
        public double Salary;

        public Employee(int id, string name, string address, string city, string dept, double salary)
        {
            EmployeeId = id;
            EmployeeName = name;
            Address = address;
            City = city;
            Department = dept;
            Salary = salary;
        }

        public abstract double GetSalary();
    }

    class ContractEmployee : Employee
    {
        public double Perks;

        public ContractEmployee(int id, string name, string address, string city, string dept, double salary, double perks)
            : base(id, name, address, city, dept, salary)
        {
            Perks = perks;
        }

        public override double GetSalary()
        {
            return Salary + Perks;
        }
    }

    class PermanentEmployee : Employee
    {
        public int NoOfLeaves;
        public double ProvidentFund;

        public PermanentEmployee(int id, string name, string address, string city, string dept, double salary, int leaves, double pf)
            : base(id, name, address, city, dept, salary)
        {
            NoOfLeaves = leaves;
            ProvidentFund = pf;
        }

        public override double GetSalary()
        {
            return Salary - ProvidentFund;
        }
    }

    internal class q9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Contract Employee");
            Console.WriteLine("2. Permanent Employee");
            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Employee Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("City: ");
            string city = Console.ReadLine();

            Console.Write("Department: ");
            string dept = Console.ReadLine();

            Console.Write("Salary: ");
            double salary = double.Parse(Console.ReadLine());

            Employee emp = null;

            if (choice == 1)
            {
                Console.Write("Perks: ");
                double perks = double.Parse(Console.ReadLine());

                emp = new ContractEmployee(id, name, address, city, dept, salary, perks);
            }
            else if (choice == 2)
            {
                Console.Write("No of Leaves: ");
                int leaves = int.Parse(Console.ReadLine());

                Console.Write("Provident Fund: ");
                double pf = double.Parse(Console.ReadLine());

                emp = new PermanentEmployee(id, name, address, city, dept, salary, leaves, pf);
            }

            if (emp != null)
            {
                Console.WriteLine("Final Salary: " + emp.GetSalary());
            }
        }
    }
}
