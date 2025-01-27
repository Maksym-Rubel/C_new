internal class Program
{
    private static void Main(string[] args)
    {
        string[] lines = { "Line 1", "Line 2" };
        string fname = "../../../my.txt";
        //File.SetAttributes(fname, FileAttributes.Archive);
        if(File.Exists(fname))
        {
            File.Delete(fname);
            Console.WriteLine($"File '{fname}' was deleted");
        }
        File.AppendAllLines(fname, lines);
        File.AppendAllText(fname, "Line 3\nLine 4 ");

        Console.WriteLine($"Content of file '{fname}' \n{String.Join<string>("\n", File.ReadAllLines(fname))}");

        string fname2 = "../../../copy_my.txt";
        //File.Copy(fname, fname2); //exception

        File.Copy(fname, fname2,true);

        Console.WriteLine($"Content of file '{fname2}' \n{String.Join<string>("\n", File.ReadAllLines(fname))}");




        //FileStream fs = File.Create(fname2);
        StreamWriter sw = File.CreateText(fname);
        sw.WriteLine("Write someting .... ");
        sw.Close();


        File.AppendAllText(fname, "New line");
        Console.WriteLine($"Content of file '{fname}' \n{String.Join<string>("\n", File.ReadAllLines(fname))}");

        Console.WriteLine($"Creation time {File.GetCreationTime(fname)}");
        Console.WriteLine($"Last write time {File.GetLastWriteTime(fname)}");


        string fname3 = "../../../third.txt";
        FileInfo file = new FileInfo(fname3);
        Console.WriteLine($"\n\n Is Exists file '{fname3}'  ::  {file.Exists}");

        if(!file.Exists)
        {
            using(var tw = file.CreateText())
            {
                tw.WriteLine("It is third file");
            }
        }

        Console.WriteLine($"FullName :: {file.FullName}");
        Console.WriteLine($"Name :: {file.Name}");
        Console.WriteLine($"Directrort :: {file.Directory}");

        Console.WriteLine($"Content of file '{fname3}' \n{String.Join<string>("\n", File.ReadAllLines(fname))}");


        //file.MoveTo("./third.txt");
        //file.MoveTo("./third.txt");
        //file.MoveTo("./" + file.Name,true);

        //file.MoveTo(Path.Combine(".",file.Name),true);

        Console.WriteLine($"Length     :: {file.Length}");
        Console.WriteLine($"Extension  :: {file.Extension}");
        Console.WriteLine($"Attributes :: {File.GetAttributes(fname)}");


        File.SetAttributes(fname, FileAttributes.Hidden);
        Console.WriteLine($"Attributes :: {File.GetAttributes(fname)}");


    }
}