using _43_homework;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Product> products = new List<Product>()
            {
                new Product(){Name ="Orange",Price = 48.2f, Country = "Spain", Category = Product.CategoryProduct.Category1, Year = 2025 },
                new Product(){Name ="Bread",Price = 15.5f, Country = "Ukraine", Category = Product.CategoryProduct.Category2 ,Year = 2025},
                new Product(){Name ="Plum",Price = 22.2f, Country = "Spain", Category = Product.CategoryProduct.Category1,Year = 2024 },
                new Product(){Name ="Oil",Price = 60.5f, Country = "Ukraine", Category = Product.CategoryProduct.Category2,Year = 2025 },
                new Product(){Name ="Banana",Price = 35.2f, Country = "Spain", Category = Product.CategoryProduct.Category1 ,Year = 2024},
                new Product(){Name ="Tea",Price = 31.2f, Country = "Poland", Category = Product.CategoryProduct.Category3 ,Year = 2023},
                new Product(){Name ="Apple",Price = 15.2f, Country = "Poland", Category = Product.CategoryProduct.Category3 ,Year = 2025},


            };

        Print(products, "Print all products");
        var query = from product in products
                    where product.Year == DateTime.Now.Year
                    orderby product.Price descending
                    select product;
        Print(query, "Print all products current year");
        Console.WriteLine();
        Console.WriteLine();

        string select_county = "Spain";
        var select_1 = products.Where(x => x.Country.CompareTo(select_county) == 0);
        Print(select_1, "Print all products current county");
        Console.WriteLine($"Count :: {select_1.Count()}");
        Console.WriteLine();
        Console.WriteLine();

        var select_2 = products.Where(x => x.Category == Product.CategoryProduct.Category1);
        Print(select_2, "Print producs with category 1");
        Console.WriteLine($"Max price :: {select_2.Max(x => x.Price)}");
        Console.WriteLine($"Min price :: {select_2.Min(x => x.Price)}");
        Console.WriteLine();
        Console.WriteLine();
        var select_3 = products.Where(x => x.Country.CompareTo("Ukraine") != 0);
        Print(select_3, "Print all products not Ukraine");
        Console.WriteLine();
        Console.WriteLine();
        var select_4 = products.Where(x => x.Category == Product.CategoryProduct.Category1);
        var select_5 = products.Where(x => x.Category == Product.CategoryProduct.Category2);
        var select_6 = products.Where(x => x.Category == Product.CategoryProduct.Category3);
        Console.WriteLine($"Category1 Count :: {select_4.Count()}");
        Console.WriteLine($"Category2 Count :: {select_5.Count()}");
        Console.WriteLine($"Category3 Count :: {select_6.Count()}");

        var query2 = from product in products
                     orderby product.Year

                     orderby product.Category
                     select product;
        Print(query2, "Sort by category");

    }
    static void Print(IEnumerable<Product> source, string text = "")
    {
        Console.WriteLine("\n" + text);
        foreach (var item in source)
        {
            Console.WriteLine(item);
        }
    }
}