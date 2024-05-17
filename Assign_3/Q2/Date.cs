using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Date
    {
        private int day;
        private int month;
        private int year;

        public Date() { }

        public Date(int day, int month, int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }

        public int Day { get => day; set => day = value; }
        public int Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }

        public void accept()
        {
            Console.WriteLine("Enter day: ");
            day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter month: ");
            month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter year: ");
            year = Convert.ToInt32(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine();
            Console.WriteLine(day + "/" + month + "/" + year);
        }

        public bool isValid(Date d)
        {
            try
            {
                DateTime date = new DateTime(year, month, day);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public override string ToString()
        {
            return day + "/" + month + "/" + year;
        }

        /* public int getDay() { return day; }
         public int getMonth() { return month; }
         public int getYear() { return year; }*/

        //public int yearDifference(Date d1, Date d2)
        //{
        //    return d1.Year - d2.Year;
        //}


        //public static Date operator -(Date d1, Date d2)
        //{
        //    Date date = new Date();
        //    date.year = d1.Year - d2.Year;

        //    return date;
        //}

    }

}
