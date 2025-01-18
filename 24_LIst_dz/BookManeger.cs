using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_LIst_dz
{
    internal class BookManeger
    {
        private List<Book> books = new List<Book>();

        public void AddBook()
        {
            Console.Write("Enter title  : ");
            string title = Console.ReadLine();
            Console.Write("Enter author :");
            string author = Console.ReadLine();
            Console.Write("Enter genre  : ");
            string genre = Console.ReadLine();
            Console.Write("Enter year   : ");
            int year = int.Parse(Console.ReadLine());

            Book NewBook = new Book(title, author, genre, year);
            books.Add(NewBook);
        }
        public void RemoveBook(int index)
        {
            if (index < 0)
            {
                return;
            }
            else
            {
                books.RemoveAt(index);
            }
        }
        public void UpdateBook(int index)
        {
            Console.Write("Enter title  : ");
            string title = Console.ReadLine();
            Console.Write("Enter author :");
            string author = Console.ReadLine();
            Console.Write("Enter genre  : ");
            string genre = Console.ReadLine();
            Console.Write("Enter year   : ");
            int year = int.Parse(Console.ReadLine());
            Book updatedBook = new Book(title, author, genre, year);
            books[index] = updatedBook;
        }
        public void DisplayBooks()
        {
            if (books.Count > 0)
            {
                foreach (var book in books)
                {
                    Console.WriteLine(book);
                }
            }
        }
        public void InsertBookAtStart()
        {
            Console.Write("Enter title  : ");
            string title = Console.ReadLine();
            Console.Write("Enter author :");
            string author = Console.ReadLine();
            Console.Write("Enter genre  : ");
            string genre = Console.ReadLine();
            Console.Write("Enter year   : ");
            int year = int.Parse(Console.ReadLine());
            Book updatedBook = new Book(title, author, genre, year);
            books.Insert(0, updatedBook);
        }
        public void InsertBookAtEnd()
        {
            Console.Write("Enter title  : ");
            string title = Console.ReadLine();
            Console.Write("Enter author :");
            string author = Console.ReadLine();
            Console.Write("Enter genre  : ");
            string genre = Console.ReadLine();
            Console.Write("Enter year   : ");
            int year = int.Parse(Console.ReadLine());
            Book updatedBook = new Book(title, author, genre, year);
            books.Add(updatedBook);
        }
        public void InsertBookAt(int index)
        {
            if (index >= 0 && index <= books.Count)
            {
                Console.Write("Enter title  : ");
                string title = Console.ReadLine();
                Console.Write("Enter author :");
                string author = Console.ReadLine();
                Console.Write("Enter genre  : ");
                string genre = Console.ReadLine();
                Console.Write("Enter year   : ");
                int year = int.Parse(Console.ReadLine());
                Book book = new Book(title, author, genre, year);
                books.Insert(index, book);
            }
           
        }
        public void RemoveBookFromStart()
        {
            if (books.Count > 0)
            {
                books.RemoveAt(0);
            }
        }
        public void RemoveBookFromEnd()
        {
            if (books.Count > 0)
            {
                books.RemoveAt(books.Count - 1);
            }
        }
        public void SearchBook()
        {
            Console.WriteLine("Enter choice:");
            Console.WriteLine("1 - Title");
            Console.WriteLine("2 - Year");
            Console.WriteLine("3 - Author");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter title: ");
                string title = Console.ReadLine();
                Book emplSearch = books.Find(emp => emp.Title.Equals(title));

                if (emplSearch != null)
                    Console.WriteLine(emplSearch);

            }
            else if (choice == 2)
            {
                Console.Write("Enter year: ");
                int year = int.Parse(Console.ReadLine());
                Book emplSearch = books.Find(emp => emp.Year == year);

                if (emplSearch != null)
                    Console.WriteLine(emplSearch);
            }
            else if (choice == 3)
            {
                Console.Write("Enter author: ");
                string author = Console.ReadLine();
                Book emplSearch = books.Find(emp => emp.Title.Equals(author));

                if (emplSearch != null)
                    Console.WriteLine(emplSearch);
 


            }

        }




    }
}
