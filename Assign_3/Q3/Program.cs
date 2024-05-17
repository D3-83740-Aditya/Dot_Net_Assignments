namespace Q3
{

    public class Program
    {
        public static void Main()
        {
            Manager manager = new Manager();
            manager.Accept();
            manager.Print();
            Console.WriteLine(manager.ToString());
        }
    }

}
