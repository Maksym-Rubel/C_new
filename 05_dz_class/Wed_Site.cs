using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_dz_class
{
    internal class Wed_Site
    {
        private string name;
        private string url;
        private string about;
        private int ip;

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
        public string Url
        {
            get => url;
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    url = value;
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
        public int Ip { get => ip;  set => ip = value; }

        public Wed_Site(string name,string url, string about, int ip)
        {
            Name = name;
            Url = url;
            About = about;
            Ip = ip;

        }

        public void Entersite()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();
            Console.Write("Enter Url : ");
            Url = Console.ReadLine();
            Console.Write("Enter About : ");
            About = Console.ReadLine();
            Console.Write("Enter Ip : ");
            Ip = int.Parse(Console.ReadLine());
            Console.WriteLine();

        }
        public void Print()
        {
            Console.WriteLine($"Name   :: {Name}");
            Console.WriteLine($"Url    :: {Url}");
            Console.WriteLine($"About  :: {About}");
            Console.WriteLine($"Ip     :: {Ip}");
        

        }



    }
}
