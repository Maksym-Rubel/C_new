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
        Console.WriteLine("Hello, World!");
    }
}