using System.Collections;
using System.Collections.Generic;
using System.Text;

internal class Program
{
    static void AddWord(Dictionary<string, string> dictionary)
    {
        Console.Write("Введіть англійське слово: ");
        string englishWord = Console.ReadLine();
        Console.Write("Введіть варіанти перекладу слова через кому: ");
        string translation = Console.ReadLine();
        if (!dictionary.ContainsKey(englishWord))
        {
            dictionary.Add(englishWord, translation);
        }
    }
    static void DeleteWord(Dictionary<string, string> dictionary)
    {
        Console.Write("Введіть англійське слово: ");
        string word = Console.ReadLine();
        if (dictionary.ContainsKey(word))
        {
            dictionary.Remove(word);
        }
    }
    static void DeleteTranslation(Dictionary<string, string> dictionary)
    {
        Console.Write("Введіть англійське слово: ");
        string word = Console.ReadLine();
        if (dictionary.ContainsKey(word))
        {
            dictionary[word] = string.Empty;
        }
    }
    static void ChangeWord(Dictionary<string, string> dictionary)
    {
        Console.Write("Введіть англійське слово: ");
        string word = Console.ReadLine();
        if (dictionary.ContainsKey(word))
        {
            Console.Write("Введіть нове англійське слово: ");
            string word2 = Console.ReadLine();
            dictionary[word2] = dictionary[word];
            dictionary.Remove(word);
        }
    }
    static void ChangeTranslation(Dictionary<string, string> dictionary)
    {
        Console.Write("Введіть англійське слово: ");
        string word = Console.ReadLine();
        if (dictionary.ContainsKey(word))
        {
            Console.Write("Введіть новий переклад слова: ");
            string translation = Console.ReadLine();
            dictionary[word] = translation;

        }
    }
    static void SearchWord(Dictionary<string, string> dictionary)
    {
        Console.Write("Введіть англійське слово: ");
        string word = Console.ReadLine();
        if (dictionary.ContainsKey(word))
        {
            Console.WriteLine($"{word,-10} {dictionary[word],-10}");
        }
    }
    static void PrintList(Dictionary<string, string> dic, string text = "")
    {
        Console.WriteLine("\n\t" + text);
        foreach (var item in dic)
        {
            Console.WriteLine($"{item.Key,-10} {item.Value}");
        }
    }
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Dictionary<string, string> dic = new Dictionary<string, string>();
        while (true)
        {
            Console.WriteLine("\nАнгло-французький словник:");
            Console.WriteLine("1. Додати слово і варіанти перекладу");
            Console.WriteLine("2. Видалити слово");
            Console.WriteLine("3. Видалити варіант перекладу");
            Console.WriteLine("4. Змінити слово");
            Console.WriteLine("5. Змінити варіант перекладу");
            Console.WriteLine("6. Пошук перекладу слова");
            Console.WriteLine("7. Показати всі слова");

            Console.WriteLine("8. Вийти");
            Console.Write("Виберіть опцію: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddWord(dic);
                    break;
                case "2":
                    DeleteWord(dic);
                    break;
                case "3":
                    DeleteTranslation(dic);
                    break;
                case "4":
                    ChangeWord(dic);
                    break;
                case "5":
                    ChangeTranslation(dic);
                    break;
                case "6":
                    SearchWord(dic);
                    break;
                case "7":
                    PrintList(dic);
                    break;
                case "8":
                    return;
                default:
                    Console.WriteLine("Невірний вибір");
                    break;
            }
        }
    }

}
