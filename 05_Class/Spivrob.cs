using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Class
{
  
    internal class Spivrob
    {
        private string pib;
        private DateTime birth;
        private uint phonenum;
        private string email;
        private string position1;
        private string mustDo;


        public string Pib
        {
            get => pib;
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    pib = value;
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
        public string Position1
        {
            get => position1;
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    position1 = value;
                }
            }
        }
        public string MustDo
        {
            get => mustDo;
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    mustDo = value;
                }
            }
        }
        public uint Phonenum
        {
            get => phonenum;
            set { phonenum = value; }

        }
        public DateTime Birth
        {
            get => birth;
            set
            {
                birth = value;
            }
        }
        public int Age => (int)((DateTime.Today - Birth).TotalDays / 365.25);

    
         public Spivrob(string pib, string email, string position1, string mustDo, uint phonenum,DateTime birth)
         {
            Pib = pib;
            Email = email;
            Position1 = position1;
            MustDo = mustDo;
            Phonenum = phonenum;
            Birth = birth;
         }
        public void EnterSpivrob()
        {
            Console.Write("Enter Pib : ");
            Pib = Console.ReadLine();
            Console.Write("Enter Email : ");
            Email = Console.ReadLine();
            Console.Write("Enter Position1 : ");
            Position1 = Console.ReadLine();
            Console.Write("Enter MustDo : ");
            MustDo = Console.ReadLine();
            Console.Write("Enter Phonenum : ");
            Phonenum = uint.Parse(Console.ReadLine());
            Console.Write("Enter Birth (dd/mm/yyyy/) : ");
            Birth = DateTime.Parse(Console.ReadLine());
          

        }
        public void PrintEmp()
        {
            Console.WriteLine($"Pib        :: {Pib}");
            Console.WriteLine($"Email      :: {Email}");
            Console.WriteLine($"Position1  :: {Position1}");
            Console.WriteLine($"MustDo     :: {MustDo}");
            Console.WriteLine($"Phonenum   :: {Phonenum}");
            Console.WriteLine($"Birth      :: {Birth.ToShortDateString()}");
            Console.WriteLine($"Age        :: {Age}");



        }

    }
}
