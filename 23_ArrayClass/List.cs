using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _23_ArrayClass
{
    internal class EmpList
    {
        private List<Employee> employees = new List<Employee>();

        public void AddEmp()
        {
            Console.Write("Введіть ПІБ: ");
            string fullName = Console.ReadLine();
            Console.Write("Введіть посаду: ");
            string posada = Console.ReadLine();
            Console.Write("Введіть зарплату: ");
            int money = int.Parse(Console.ReadLine());
            Console.Write("Введіть корпоративний email: ");
            string email = Console.ReadLine();

            Employee newEmployee = new Employee(fullName, posada, money, email);
            employees.Add(newEmployee);
        }

        public void PopEmp()
        {
            Console.Write("Введіть ПІБ: ");
            string fullName = Console.ReadLine();
            Employee employeeToRemove = employees.Find(emp => emp.NameSurname.Equals(fullName));

            if (employeeToRemove != null)
            {
                employees.Remove(employeeToRemove);
                
            }
           
        }

        public void Search()
        {
            Console.WriteLine("Виберіть критерій пошуку:");
            Console.WriteLine("1 - ПІБ");
            Console.WriteLine("2 - Email");
            Console.WriteLine("3 - Зарплата");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Введіть ПІБ: ");
                string fullName = Console.ReadLine();
                Employee emplSearch = employees.Find(emp => emp.NameSurname.Equals(fullName));

                if (emplSearch != null)
                    emplSearch.Print();
             
            }
            else if (choice == 2)
            {
                Console.Write("Введіть email: ");
                string email = Console.ReadLine();
                Employee emplSearch = employees.Find(emp => emp.Email.Equals(email));

                if (emplSearch != null)
                    emplSearch.Print();
                else
                    Console.WriteLine("Співробітника не знайдено.");
            }
            else if (choice == 3)
            {
                Console.Write("Введіть зарплату: ");
                int money = int.Parse(Console.ReadLine());
                Employee emplSearch = employees.Find(emp => emp.Money == money);

                if (emplSearch != null)
                    emplSearch.Print();
               
                   
            }
            
        }

        public void PrintAllEmployees()
        {
           
            foreach (var employee in employees)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine($"ПІБ: {employee.NameSurname}");
                Console.WriteLine($"Посада: {employee.Posada}");
                Console.WriteLine($"Зарплата: {employee.Money}");
                Console.WriteLine($"Корпоративний email: {employee.Email}");
            }
           
        }
    }
}
