using System.Text;
using System.Text.RegularExpressions;

internal class Program
{
    static void Moderation(string word, string path1, string path2)
    {
        string value;
        using (StreamReader reader = new StreamReader(path1, Encoding.UTF8))
        {
            value = reader.ReadToEnd();
        }
        string[] subs = word.Split(' ');


        foreach (string words in subs)
        {
            string replace = new string('*', words.Length);
            value = value.Replace(words, replace);

        }
        using (StreamWriter sw1 = new StreamWriter(path2,false, Encoding.UTF8))
        {
            sw1.WriteLine(value);
        }

    }
    private static void Main(string[] args)
    {
        

        string fstr = "../../../string.dat";
        string fstr1 = "../../../string1.dat";



        string line = "test best rest car\nman telephone";
        string mod = "car telephone";



        using (StreamWriter sw = new StreamWriter(fstr))
        {
            sw.WriteLine(line);

        }
        using (StreamWriter sw1 = new StreamWriter(fstr1))
        {
         

        }

        Moderation(mod, fstr, fstr1);
    }
}