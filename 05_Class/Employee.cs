using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Class
{
    enum Position
    {
        None,Manager = 1,QA,Developer,Economist,Director
    }
    internal class Employee
    {
        private static int lastid;
        public readonly int ID = ++lastid;

        public string Namel { get; set; } = "NoName";
        public DateTime Birth {  get; set; }
        public Position Position { get; set; }

        public static int LastId { get => lastid; }
        public static bool SamePosition(Employee em1, Employee em2) => em1.Position == em2.Position;


        static Employee()
        {
            Console.WriteLine("\t\t Static ctor done!");
            lastid = new Random().Next(1,10) * 1000;
        }
        public override string ToString() => $"ID :: {ID,-5} Name :: {Namel,-10} Birth :: {Birth.ToShortDateString(),-15} Position :: {Position}";



       public int Age => (int)((DateTime.Today - Birth).TotalDays/365.25);

    }
}
