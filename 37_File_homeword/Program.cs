using System.Text;

internal class Program
{
    static void CreateDirectory(string name)
    {
        Directory.CreateDirectory(name);
        Console.WriteLine($"Каталог '{name}' створено");
    }
    static void DeleteDirectory(string name)
    {
        Directory.Delete(name, true);
        Console.WriteLine($"Каталог '{name}' видалено");
    }
    static void DeleteFile(string name)
    {
        File.Delete(name);
        Console.WriteLine($"Файл '{name}' видалено");

    }
    static void FileInfo(string name)
    {
        FileInfo fileInfo = new FileInfo(name);
        if (fileInfo.Exists)
        {
            Console.WriteLine($"Розмір: {fileInfo.GetType()} байт\nДата змінення: {fileInfo.LastWriteTime}");
        }
        else
        {
            Console.WriteLine("Файл не знайдено.");
        }
    }
    static void MoveFile(string name, string destination)
    {
        File.Move(name, Path.Combine(destination, Path.GetFileName(name)));
        Console.WriteLine($"Файл '{name}' переміщено до '{destination}'.");
    }
    static void ListContents()
    {
        string[] items = Directory.GetFileSystemEntries(Directory.GetCurrentDirectory());
        foreach (var e in items)
        {
            FileInfo fi = new FileInfo(e);
            string info = "<DIR>";
            if (!fi.Attributes.HasFlag(FileAttributes.Directory))
                info = fi.Length.ToString();
            Console.WriteLine($"{fi.CreationTime,-22} {fi.Name,-30}");
        }
    }
    static void LisDirectories()
    {
        string[] items = Directory.GetDirectories(Directory.GetCurrentDirectory());
        foreach (var e in items)
        {
            FileInfo fi = new FileInfo(e);
            string info = "<DIR>";
            if (!fi.Attributes.HasFlag(FileAttributes.Directory))
                info = fi.Length.ToString();
            Console.WriteLine($"{fi.CreationTime,-22} {fi.Name,-30}");
        }
    }
    static public void ChangeDirectory(string folderName)
    {

        if (Directory.Exists(folderName))
        {
            Directory.SetCurrentDirectory(folderName);
            Console.WriteLine($"Folder '{folderName}' changed");
            Console.WriteLine($"Current path \n {Directory.GetCurrentDirectory()}");
        }
        else
        {
            Console.WriteLine($"Folder '{folderName}' not created");
        }
    }

    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        while (true)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1. Перегляд вмісту каталогу");
            Console.WriteLine("2. Перегляд лише каталогів");
            Console.WriteLine("3. Створити каталог");
            Console.WriteLine("4. Видалити каталог");
            Console.WriteLine("5. Видалити файл");
            Console.WriteLine("6. Перемістити файл");
            Console.WriteLine("7. Переглянути інформацію про файл");
            Console.WriteLine("8. Змінити каталог");
            Console.WriteLine("9. Вихід");

            Console.Write("Оберіть дію: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ListContents();
                    break;
                case "2":
                    LisDirectories();
                    break;
                case "3":
                    Console.Write("Введіть ім'я каталогу: ");
                    CreateDirectory(Console.ReadLine());
                    break;
                case "4":
                    Console.Write("Введіть ім'я каталогу: ");
                    DeleteDirectory(Console.ReadLine());
                    break;
                case "5":
                    Console.Write("Введіть ім'я файлу: ");
                    DeleteFile(Console.ReadLine());
                    break;
                case "6":
                    Console.Write("Введіть ім'я файлу: ");
                    string file = Console.ReadLine();
                    Console.Write("Введіть місце призначення: ");
                    MoveFile(file, Console.ReadLine());
                    break;
                case "7":
                    Console.Write("Введіть ім'я файлу: ");
                    FileInfo(Console.ReadLine());
                    break;
                case "8":
                    Console.Write("Введіть шлях до каталогу: ");
                    ChangeDirectory(Console.ReadLine());
                    break;
                case "9":
                    return;
                default:
                    Console.WriteLine("Невірний вибір, спробуйте ще раз.");
                    break;
            }
        }
    }
}