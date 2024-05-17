namespace Q2
{
    using System;

    struct Student
    {
        public int RollNo;
        public string Name;
        public double Marks;
    }

    class main
    {
        private static Student[] studentsArray;
        private static int size;

        public static void CreateArray(int n)
        {
            size = n;
            studentsArray = new Student[size];
        }

        public static void AcceptInfo()
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter details for Student {i + 1}:");
                Console.Write("Roll No: ");
                studentsArray[i].RollNo = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                studentsArray[i].Name = Console.ReadLine();
                Console.Write("Marks: ");
                studentsArray[i].Marks = double.Parse(Console.ReadLine());
            }
        }

        public static void PrintInfo()
        {
            Console.WriteLine("Student Information:");
            foreach (var student in studentsArray)
            {
                Console.WriteLine($"Roll No: {student.RollNo}");
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine($"Marks: {student.Marks}");
            }
        }

        public static void ReverseArray()
        {
            Array.Reverse(studentsArray);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of students: ");
            int n = int.Parse(Console.ReadLine());

            main.CreateArray(n);
            main.AcceptInfo();

            Console.WriteLine("\nOriginal Array:");
            main.PrintInfo();

            main.ReverseArray();

            Console.WriteLine("\nReversed Array:");
            main.PrintInfo();
        }
    }

}
