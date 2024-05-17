using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Employee : Person
    {
        public enum DepartmentType
        {
            HR, Management, Developer, Sales

        };

        private int id;
        private double salary;
        private string designation;
        private DepartmentType dept;

        public int Id { get => id; set => id = value; }
        public double Salary { get => salary; set => salary = value; }
        public string Designation { get => designation; set => designation = value; }
        internal DepartmentType Dept { get => dept; set => dept = value; }

        public Employee() { }

        public Employee(int id, double salary, string designation, DepartmentType dept)
        {
            this.Id = id;
            this.Salary = salary;
            this.Designation = designation;
            this.Dept = dept;
        }

        public void accept()
        {
            base.accept();
            Console.WriteLine("Enter id: ");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter salary: ");
            Salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter designation: ");
            Designation = Console.ReadLine();

            Console.WriteLine("0. HR");
            Console.WriteLine("1. Management");
            Console.WriteLine("2. Developer");
            Console.WriteLine("3. Sales");

            Console.WriteLine("Enter dept: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    dept = DepartmentType.HR;
                    break;

                case 1:
                    dept = DepartmentType.Management;
                    break;

                case 2:
                    dept = DepartmentType.Developer;
                    break;

                case 3:
                    dept = DepartmentType.Sales;
                    break;
            }
        }

        public void display()
        {
            base.display();
            Console.WriteLine("id: " + Id);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("Designation: " + Designation);
            Console.WriteLine("Dept: " + Dept);
        }
    }
}
