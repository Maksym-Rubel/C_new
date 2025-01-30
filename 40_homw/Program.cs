using _40_homw;
using static System.Reflection.Metadata.BlobBuilder;

internal class Program
{
    static void Print<T>(IEnumerable<T> query, string text = "")
    {
        Console.WriteLine($"{(text.Length == 0 ? "" : "\n\t")} {text}");
        foreach (T item in query)
        {
            Console.WriteLine($"{item,-7}");
        }
        Console.WriteLine();
    }
    static void FirstD(Product arr)
    {

    }
    private static void Main(string[] args)
    {
        List<Product> prods = new List<Product>
            {
                new Product{Name = "Pizza", Year = 2025, Category = Product.CategoryFood.Salty, Price = 100 },
                new Product{Name = "Coffee", Year = 2025, Category = Product.CategoryFood.Salty, Price = 100 },
                new Product{Name = "Ice cream", Year = 2025, Category = Product.CategoryFood.Salty, Price = 100 },
                new Product{Name = "Chips", Year = 2025, Category = Product.CategoryFood.Salty, Price = 100 },
                new Product{Name = "Milk", Year = 2025, Category = Product.CategoryFood.Salty, Price = 100 },


            };
        var res = from b in books
                  where b.Year == 2008
                  orderby b.Author
                  select b;

        Print(res, "Print queart");

    }
}