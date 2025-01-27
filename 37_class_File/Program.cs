using System.IO;
using System.Threading.Tasks.Dataflow;

internal class Program
{
    static public void CreateDIrectory(string folderName)
    {
        if (!Directory.Exists(folderName))
        {
            Directory.CreateDirectory(folderName);
            Console.WriteLine($"Folder '{folderName}' created");
        }
        else
        {
            Console.WriteLine($"Folder '{folderName}' uhe ye");
        }
    }
    static public void DeleteDIrectory(string folderName)
    {
        if (!Directory.Exists(folderName))
        {
            Directory.Delete(folderName,true);
            Console.WriteLine($"Folder '{folderName}' deleted");
        }
        else
        {
            Console.WriteLine($"Folder '{folderName}' not created");
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
    static public void ShowDir(string folderName)
    {
        Console.Write("Enter pattern --> ");
        string pattern = Console.ReadLine()!;
        if (Directory.Exists(folderName))
        {
            var entries = Directory.GetFileSystemEntries(folderName, pattern);
            foreach (var e in entries)
            {
                FileInfo fi = new FileInfo(e);
                string info = "<DIR>";
                if (!fi.Attributes.HasFlag(FileAttributes.Directory))
                    info = fi.Length.ToString();
                Console.WriteLine($"{fi.CreationTime,-22} {fi.Name,-30}");
            }

        }
        else
        {
            Console.WriteLine($"Folder '{folderName}' not created");
        }
    }
    static public void Conmand(string commandline)
    {
        var parts = commandline.Split(' ');
        string command = parts[0].ToLower();
        string argument = parts[1];

        switch (command)
        {
            case "md":
                CreateDIrectory(argument);
                break;
            case "rd":
                DeleteDIrectory(argument);
                break;
            case "cd":
                ChangeDirectory(argument);
                break;
            case "dir":
                ShowDir(argument);
                break;
        }
    }
    private static void Main(string[] args)
    {
        string ch = " ";
        while (ch != "exit")
        {
            Console.Write(" > ");
            ch = Console.ReadLine()!;
            Conmand(ch);
        }
      
    }
}