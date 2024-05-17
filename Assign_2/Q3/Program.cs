namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date d = new Date();
            Date d1 = new Date();
            Date d2 = new Date();
            d.accept();
            d1.accept();
            //d.display();
            // bool b = d.isValid(d);
            Console.WriteLine("Date is valid: " + d.isValid(d));
            Console.WriteLine("Date: " + d.ToString());

            int diff = d.yearDifference(d, d1);
            Console.WriteLine("Difference between years is " + diff);

            d2 = d - d1;
            Console.WriteLine("Difference is : " + d2);
        }
    }
}
