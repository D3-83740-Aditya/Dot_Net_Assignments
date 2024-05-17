using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Person
    {
        private string name;
        private bool gender;
        private Date birth;
        private string address;


        public Person()
        {
            birth = new Date();
        }
        public Person(string name, bool gender, Date birth, string address)
        {
            this.name = name;
            this.gender = gender;
            this.birth = birth;
            this.address = address;
        }

        public string Name { get { return name; } set { name = value; } }
        public string Address { get { return address; } set { address = value; } }
        public bool Gender { get { return gender; } set { gender = value; } }
        public Date Birth { get { return birth; } set { birth = value; } }

        public void accept()
        {
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter address: ");
            address = Console.ReadLine();

            Console.WriteLine("Enter gender: ");
            gender = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Enter birth: ");
            birth.accept();


        }

        public void display()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Gender: " + Gender);
            Console.WriteLine("Date of birth: " + Birth);
        }


    }
}
