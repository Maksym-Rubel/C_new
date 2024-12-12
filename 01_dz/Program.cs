internal class Program
{
    static void Swap(ref int x, ref int y)
    {
        var tmp = x;
        x = y;
        y = tmp;
    }
    private static void Main(string[] args)
    {
        Console.Write("Enter posada --> ");
        string pos = Console.ReadLine();

        Console.Write("Enter hourse ---> ");
        int hrs = int.Parse(Console.ReadLine());
        switch (pos)
        {
            case "Director":
                Console.WriteLine($"per/hrs = 150,  you earn --> {hrs * 150}");
                break;
            case "Manager":
                Console.WriteLine($"per/hrs = 100,  you earn --> {hrs * 100}");
                break;
            case "Designer":
                Console.WriteLine($"per/hrs = 110,  you earn --> {hrs * 110}");
                break;
            case "Programist":
                Console.WriteLine($"per/hrs = 120,  you earn --> {hrs * 120}");
                break;
            default:
                break;
        }

        Console.Write("Enter number a ---> ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter number b ---> ");
        int b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            Swap(ref a, ref b);
        }
        for (int i = a; i <= b; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{i,-2}");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"\n\nYou enter: ");

        int isPropusk = 0;
        int IsDigits = 0;
        int IsLeterr = 0;
        int IsSymbols = 0;

        char str;
        do
        {
           
            
            str = (char)Console.Read();
            if (str == '\n' || str == '\r')
            {
                continue;
            }
            Console.WriteLine($"You enter: {str} ");
            if (char.IsDigit(str))
            {
                IsDigits++;
            }
            else if (char.IsLetter(str))
            {
                IsLeterr++;
            }
            else if (char.IsWhiteSpace(str))
            {
                isPropusk++;
            }
            else if (!char.IsControl(str) && !char.IsWhiteSpace(str) && str != '.')
            {
                IsSymbols++;
            }
           
        }
        while (str != '.');


        Console.WriteLine($"IsDigits: {IsDigits}");
        Console.WriteLine($"IsLeterr: {IsLeterr}");
        Console.WriteLine($"isPropusk: {isPropusk}");
        Console.WriteLine($"IsSymbols: {IsSymbols}");

        Console.WriteLine($"\n\nYou enter: ");

        char str1;
        do
        {


            str1 = (char)Console.Read();
            if (str1 == '\n' || str1 == '\r')
            {
                continue;
            }


            if (char.IsLetter(str1))
            {
                if (char.IsLower(str1))
                {
                    str1 = char.ToUpper(str1); 
                }
                else if (char.IsUpper(str1))
                {
                    str1 = char.ToLower(str1); 
                }
            }
            Console.WriteLine($"You enter: {str1} ");


        }
        while (str1 != '.');





    }

}