using System.Text;

internal class Program
{

    static void SearchWord(string word,string path)
    {
        string value;
        using (StreamReader reader = new StreamReader(path, Encoding.UTF8))
        {
            value = reader.ReadToEnd();
        }
   
        int index = value.IndexOf(word);

      
        Console.WriteLine($"Index :: {index}");
    }
    static void SearchWordS(string word, string path)
    {
        string value;
        using (StreamReader reader = new StreamReader(path, Encoding.UTF8))
        {
            value = reader.ReadToEnd();
        }
        int countWord = 0;
        int index = value.IndexOf(word);
        while (index != -1)
        {
            countWord++;
            index = value.IndexOf(word,index + word.Length);
        }

        Console.WriteLine($"Count :: {countWord}");
    }
    static void SearchWordEs(string word, string path)
    {
        string value;
        string word2 = new string(word.Reverse().ToArray());
        using (StreamReader reader = new StreamReader(path, Encoding.UTF8))
        {
            value = reader.ReadToEnd();
        }
        int countWord = 0;
        int index = value.IndexOf(word);
        while (index != -1)
        {
            countWord++;
            index = value.IndexOf(word, index + word.Length);
        }
        int index2 = value.IndexOf(word2);

        while (index2 != -1)
        {
            countWord++;
            index2 = value.IndexOf(word2, index2 + word2.Length);
        }

        Console.WriteLine($"Count :: {countWord}");
    }
    private static void Main(string[] args)
    {
        string fstr = "../../../string.dat";

    
        string line = "Hello World Hello olleH";
        

        using (StreamWriter sw = new StreamWriter(fstr))
        {
            sw.WriteLine(line);
         
        }
 

        int choice = -1;
        while (choice != 0)
        {

            Console.WriteLine("Enter func");
            Console.WriteLine("1. Search index");
            Console.WriteLine("2. Search count");
            Console.WriteLine("3. Search count reverse");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.Write("Enter word --> ");
                string choice1 = Console.ReadLine();
                SearchWord(choice1, fstr);
            }
            else if (choice == 2)
            {
                Console.Write("Enter word --> ");
                string choice1 = Console.ReadLine();
                SearchWordS(choice1, fstr);
            }
            else if (choice == 3)
            {
                Console.Write("Enter word --> ");
                string choice1 = Console.ReadLine();
                SearchWordEs(choice1, fstr);
            }
            else if (choice == 0)
            {
                break;
            }
        }
       

    }
}