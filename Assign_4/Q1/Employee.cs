namespace Q1
{
    using System;

    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Designation { get; protected set; }

        public Employee()
        {
            Designation = "Employee";
        }

        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void Accept()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();
            Console.Write("Enter Age: ");
            Age = Convert.ToInt32(Console.ReadLine());
        }

        public virtual void Print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Designation: {Designation}");
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Designation: {Designation}";
        }
    }

}