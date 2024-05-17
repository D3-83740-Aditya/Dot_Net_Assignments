using System;

public struct Student
{
    private string name;
    private bool gender;
    private int age;
    private int std;
    private char div;
    private double marks;

    // Default constructor
    public Student(string name, bool gender, int age, int std, char div, double marks)
    {
        this.name = name;
        this.gender = gender;
        this.age = age;
        this.std = std;
        this.div = div;
        this.marks = marks;
    }

    // Get methods
    public string GetName() { return name; }
    public bool GetGender() { return gender; }
    public int GetAge() { return age; }
    public int GetStd() { return std; }
    public char GetDiv() { return div; }
    public double GetMarks() { return marks; }

    // Set methods
    public void SetName(string name) { this.name = name; }
    public void SetGender(bool gender) { this.gender = gender; }
    public void SetAge(int age) { this.age = age; }
    public void SetStd(int std) { this.std = std; }
    public void SetDiv(char div) { this.div = div; }
    public void SetMarks(double marks) { this.marks = marks; }

    // AcceptDetails method
    public void AcceptDetails()
    {
        Console.Write("Enter name: ");
        name = Console.ReadLine();
        Console.Write("Enter gender (true for female, false for male): ");
        gender = Convert.ToBoolean(Console.ReadLine());
        Console.Write("Enter age: ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter standard: ");
        std = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter division: ");
        div = Convert.ToChar(Console.ReadLine());
        Console.Write("Enter marks: ");
        marks = Convert.ToDouble(Console.ReadLine());
    }

    // PrintDetails method
    public void PrintDetails()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Gender: " + (gender ? "Female" : "Male"));
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Standard: " + std);
        Console.WriteLine("Division: " + div);
        Console.WriteLine("Marks: " + marks);
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student();
        s1.AcceptDetails();
        s1.PrintDetails();

        Student s2 = new Student("John Doe", false, 18, 12, 'A', 85.5);
        s2.PrintDetails();
    }
}
