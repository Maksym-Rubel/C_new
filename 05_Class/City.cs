using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace _05_Class
{
    internal class City
    {
        private string nameCity = "NoName";
        private string nameCountry = "NoName";
        private uint kilkZhut;
        private uint numberCity;
        private string nameRayon = "NoName";
   




        public string NameCity {
            get => nameCity;
                set
                {
                    if (!String.IsNullOrWhiteSpace(value))
                    {
                    nameCity = value;
                    }
                }
            }
        public string NameCountry 
        {
            get => nameCountry;
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    nameCountry = value;
                }
            }
        }
        public uint KilkZhut 
        {
            get => kilkZhut;
            set { kilkZhut = value; }

        }
        public uint NumberCity
        {
            get => numberCity;
            set { numberCity = value; }
        }
        public string NameRayon
        {
            get => nameRayon;
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    nameRayon = value;
                }
            }
        }
        public City(string nameCity, string nameCountry,  uint kilkZhut, uint numberCity,string nameRayon)
        {
            NameCity = nameCity;
            NameCountry = nameCountry;
            KilkZhut = kilkZhut;
            NumberCity = numberCity;
            NameRayon = nameRayon;




        }
        public void EnterCIty()
        {
            Console.Write("Enter name city : ");
            NameCity = Console.ReadLine();
            Console.Write("Enter NameCountry : ");
            NameCountry = Console.ReadLine();
            Console.Write("Enter KilkZhut : ");
            KilkZhut = uint.Parse(Console.ReadLine());
            Console.Write("Enter NumberCity : ");
            NumberCity = uint.Parse(Console.ReadLine());
            Console.Write("Enter NameRayon : ");
            NameRayon = Console.ReadLine();
    
        }
        public void PrintCity()
        {
            Console.WriteLine($"NameCity        :: {NameCity}");
            Console.WriteLine($"NameCountry     :: {NameCountry}");
            Console.WriteLine($"KilkZhut        :: {KilkZhut}");
            Console.WriteLine($"NumberCity      :: {NumberCity}");
            Console.WriteLine($"NameRayon       :: {NameRayon}");

        }
    }
}
