using _24_LIst_dz;

internal class Program
{
    private static void Main(string[] args)
    {
        BookManeger manager = new BookManeger();
        while (true)
        {
            Console.WriteLine("\nEnter choice");
            Console.WriteLine("1.  Add book");
            Console.WriteLine("2.  Delete from index");
            Console.WriteLine("3.  Change iformation");
            Console.WriteLine("4.  Search book");
            Console.WriteLine("5.  Insert book at the beginning");
            Console.WriteLine("6.  Insert the book at the end");
            Console.WriteLine("7.  Insert book by index");
            Console.WriteLine("8.  Remove the book from the beginning");
            Console.WriteLine("9.  Remove the book from the end");
            Console.WriteLine("10. Display a list of books");
            Console.WriteLine("0.  Exit");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    manager.AddBook();
                    break;
                case 2:
                    Console.Write("Enter index : ");
                    int index = int.Parse(Console.ReadLine());
                    manager.RemoveBook(index);
                    break;
                case 3:
                    Console.Write("Enter index : ");
                    index = int.Parse(Console.ReadLine());
                    manager.UpdateBook(index);
                    break;
                case 4:
                    manager.SearchBook();
                    break;
                case 5:
                    manager.InsertBookAtStart();
                    break;
                case 6:
                    manager.InsertBookAtEnd();
                    break;
                case 7:
                    Console.Write("Enter index : ");
                    index = int.Parse(Console.ReadLine());
                    manager.InsertBookAt(index);
                    break;
                case 8:
                    manager.RemoveBookFromStart();
                    break;
                case 9:
                    manager.RemoveBookFromEnd();
                    break;
                case 10:
                    manager.DisplayBooks();
                    break;
                case 0:
                    return;
            }

        }
    }
}