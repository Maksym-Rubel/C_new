using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_ArrayClass
{
    internal class Employee
    {
        public string NameSurname { get; set; }
       

        public string Posada { get; set; }

        public int Money { get; set; }

        public string Email { get; set; }
        public Employee(string namesurname, string posada, int money, string email) 
        {
            NameSurname = namesurname;
            Posada = posada;
            Money = money;
            Email = email;

        }

        public void Print()
        {
            Console.WriteLine($"Name Surname -> {NameSurname}");
            Console.WriteLine($"Posada -> {Posada}");
            Console.WriteLine($"Money -> {Money}");
            Console.WriteLine($"Email -> {Email}");

        }

    }
}
