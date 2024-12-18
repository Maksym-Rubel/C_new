using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_dz_class
{
    internal class Zhurnal
    {
        private string name;
        private int year;
        private string about;
        private int connumber;
        private string email;
       
       

        public string Name
        {
            get => name;
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
            }
        }
        public string Email
        {
            get => email;
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    email = value;
                }
            }
        }
        public string About
        {
            get => about;
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    about = value;
                }
            }
        }
        public int Connumber { get => connumber; set => connumber = value; }
        public int Year { get => year; set => year = value; }

        public Zhurnal(string name, int year, string about, int connumber, string email)
        {
            Name = name;
            Year = year;
            About = about;
            Connumber = connumber;
            Email = email;

        }

        public void Enterg()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();
            Console.Write("Enter year : ");
            Year = int.Parse(Console.ReadLine());
            Console.Write("Enter about : ");
            About = Console.ReadLine();
            Console.Write("Enter contact number : ");
            Connumber = int.Parse(Console.ReadLine());
            Console.Write("Enter email : ");
            Email = Console.ReadLine();

            Console.WriteLine();

        }
        public void Print()
        {
            Console.WriteLine($"Name           :: {Name}");
            Console.WriteLine($"Year           :: {Year}");
            Console.WriteLine($"About          :: {About}");
            Console.WriteLine($"Contact number :: {Connumber}");
            Console.WriteLine($"Email          :: {Email}");



        }



    }
}

