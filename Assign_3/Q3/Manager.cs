/*namespace Q3
{
    internal class Manager : Employee
    {
        private double bonus;

        public Manager() { }

        public Manager(double bonus)
        {
            this.Bonus = bonus;
        }

        public double Bonus { get => bonus; set => bonus = value; }

        public void accept()
        {
            base.accept();
            Console.WriteLine("Enter bonus: ");
            Bonus = Convert.ToDouble(Console.ReadLine());
        }

        public void display()
        {
            base.display();
            Console.WriteLine("Bonus: " + Bonus);
        }

    }
}
*/

namespace Q3
{
    using System;

    public class Manager : Employee
    {
        public double Bonus { get; set; }

        // Default constructor
        public Manager()
        {
            Designation = "Manager";
        }

        // Parameterized constructor
        public Manager(string name, int age, double bonus) : base(name, age)
        {
            Bonus = bonus;
            Designation = "Manager";
        }

        // Override Accept method to accept Manager specific data
        public override void Accept()
        {
            base.Accept();
            Console.Write("Enter Bonus: ");
            Bonus = Convert.ToDouble(Console.ReadLine());
        }

        // Override Print method to print Manager specific data
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Bonus: {Bonus}");
        }

        // Override ToString method to return Manager specific data
        public override string ToString()
        {
            return base.ToString() + $", Bonus: {Bonus}";
        }
    }

}