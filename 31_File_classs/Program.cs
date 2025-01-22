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
        SearchWord("World", fstr);
        SearchWordS("Hello", fstr);
        SearchWordEs("olleH",fstr);
    }
}