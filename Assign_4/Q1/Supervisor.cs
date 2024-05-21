namespace Q1
{
    internal class Supervisor : Employee
    {
        private int subbordinates;
        public Supervisor()
        {
            Designation = "Supervisor";
        }

        public Supervisor(int subbordinates)
        {
            this.Subbordinates = subbordinates;
        }

        public int Subbordinates { get => subbordinates; set => subbordinates = value; }

        public void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter no of subbordinates: ");
            subbordinates = Convert.ToInt32(Console.ReadLine());
        }

        public void Print()
        {
            //base.Print();
            Console.WriteLine("Name: " + Name);
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine("Designation: " + Designation);
            Console.WriteLine("no of subbordinates: " + subbordinates);
        }



    }
}
