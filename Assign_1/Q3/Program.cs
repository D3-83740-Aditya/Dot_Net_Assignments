
using System.ComponentModel.Design;
using System.Linq.Expressions;

namespace Q3
{
    internal class Program
    {
        public static int Menu()
        {
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Sub");
            Console.WriteLine("3. Mul");
            Console.WriteLine("4. Div");

            Console.WriteLine("Enter your choice: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int a, b, res;
            Console.WriteLine("Enter value of a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of b: ");
            b = Convert.ToInt32(Console.ReadLine());
            int choice;

            /*            while ((choice = Menu()) != 0)
                        {
                            switch (choice)
                            {
                                case 0:
                                    return;

                                case 1:
                                    res = a + b;
                                    Console.WriteLine("Addition = " + res);
                                    break;

                                case 2:
                                    res = a - b;
                                    Console.WriteLine("Subtraction = " + res);
                                    break;

                                case 3:
                                    res = a * b;
                                    Console.WriteLine("Multiplication = " + res);
                                    break;

                                case 4:
                                    res = a / b;
                                    Console.WriteLine("Division = " + res);
                                    break;
                            }
                        }
            */


            do
            {
                switch (choice = Menu())
                {
                    case 0:
                        return;

                    case 1:
                        res = a + b;
                        Console.WriteLine("Addition = " + res);
                        break;

                    case 2:
                        res = a - b;
                        Console.WriteLine("Subtraction = " + res);
                        break;

                    case 3:
                        res = a * b;
                        Console.WriteLine("Multiplication = " + res);
                        break;

                    case 4:
                        res = a / b;
                        Console.WriteLine("Division = " + res);
                        break;

                    default:
                        Console.WriteLine("Enter correct choice.");
                        break;
                }
            } while (choice != 0);
        }
    }
}