﻿using _39_Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Book> books = new List<Book>
            {
                new Book{Title = "Web Development", Author = "Aki Iskandar ", Category = Book.CategoryBook.Web, Year = 2019, Price=39.99f },
                new Book{Title = "Bootstrap 4 ", Author = "Jacob Lett", Category = Book.CategoryBook.Web, Year = 2018, Price=31.5f },
                new Book{Title = "Professional C# 7 ", Author = "Christian Nagel ", Category = Book.CategoryBook.NET, Year = 2018, Price=60.0f },
                new Book{Title = "Pro C# 7: With .NET", Author = "Andrew Troelsen", Category = Book.CategoryBook.NET, Year = 2017, Price=39.0f },
                new Book{Title = " C# 7.0 in a Nutshell", Author = "Jozeph Albahari", Category = Book.CategoryBook.NET, Year = 2017, Price=79.99f },
                new Book{Title = "harry Potter", Author = "Rowling", Category = Book.CategoryBook.Children, Year = 2017, Price=19.99f }

            };
        Print(books , "Print Original");

        var res = from b in books
                  where b.Year == 2008
                  orderby b.Author
                  select b;

        Print(res, "Print queart");


        var max = books.Max(x=>x.Price);
        Console.WriteLine($"Max print :: {max}");
        //var res_2 = books.Where(b => b.Category == Book.CategoryBook.NET).OrderBy(x=>x.Price);
        var res_2 = books.Where(b => b.Category == Book.CategoryBook.NET).OrderByDescending(x=>x.Price);

        Print(res_2, "Print queart");

        var res_3 = from b in books group b by b.Category;
        foreach(var item in res_3)
        {
            Console.WriteLine($"_______ {item.Key} _______ Count {item.Count()} _______ Max Price {item.Max(x=>x.Price)}");
            foreach(var e in item)
            {
                Console.WriteLine(e);
            }
        }

    }
    static void Print<T>(IEnumerable<T> query, string text = "")
    {
        Console.WriteLine($"{(text.Length == 0 ? "" : "\n\t")} {text}");
        foreach (T item in query)
        {
            Console.WriteLine($"{item,-7}");
        }
        Console.WriteLine();
    }
}