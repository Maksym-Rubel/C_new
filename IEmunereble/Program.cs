using IEmunereble;

internal class Program
{
    private static void Main(string[] args)
    {
        //int[] arr = { 4, 44, 5, 8,10, 12, 15 };
        //var enArr = arr.GetEnumerator();
        //while (enArr.MoveNext())
        //{
        //    Console.WriteLine($"{enArr.Current, -7}");
        //};
        //Console.WriteLine();


        Shop shop = new Shop();
        Item apple = new Item() { Name = "Apple", Price = 30 };
        Item orange = new Item() { Name = "Orange", Price = 60 };
        Item blueberry = new Item() { Name = "Blueberry", Price = 40 };
        Item plum = new Item() { Name = "Plum", Price = 70 };
        shop.AddItem(apple);
        shop.AddItem(orange);
        shop.AddItem(blueberry);
        shop.AddItem(plum);

        Console.WriteLine("------------------ IEnumerable -------------");
        foreach (var item in shop)
        {
            Console.WriteLine(item);
        }


    }
}