internal class Program
{
    static void TaskConsole()
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.CursorTop = 14;
        Console.CursorLeft = 20;

    }
    static void WtitelineWays()
    {
        int numb = 10;
        double d = 53.6;
        decimal dd = 485.23232m;
        float f = 35.6f;

        System.String line = "Hello ";
        string str = "C# language популярна мова .NET";

        //way 1
        Console.WriteLine("Monet :: " + dd + " \t fvalue :: " + f);

        //way 2
        Console.WriteLine("float value :: {0}; \t {0} \t",f,Math.Sqrt(f));

        //way 2
        Console.WriteLine($"Money :: {dd}; number ^ 2 = {Math.Pow(numb, 2)}");
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine(str);
    }

    static void ReadNumbers()
    {
        //string line = Console.ReadLine();

        string numb = Console.ReadLine();
        int res = Convert.ToInt32(numb);
        res += 10;
        Console.WriteLine($"Result ::  {res}");
        double dd = double.Parse(Console.ReadLine());
        dd++;
        Console.WriteLine($"Result ::  {dd}");

        int result;
        if (int.TryParse(Console.ReadLine(), out result)) 
        {
            Console.WriteLine($"Result :: {result}");

        
        }
        else
        {
            Console.WriteLine("Error");
        }



    }

    private static void Main(string[] args)
    {
        //TaskConsole();
        //ReadChar();
        //WtitelineWays();
        //ReadNumbers();
        //int i = 0;
        //for (; ;)
        //{
        //    i++;

        //    Console.WriteLine(i + ". Hello");
        //    if (i == 5) 
        //        break;
        //}
        //Console.WriteLine("End :: " + i);


        //int day = Convert.ToInt32(Console.ReadLine());
        //if(day == 1)
        //{
        //    Console.WriteLine("Monday");
        //}
        //else if (day == 2)
        //{
        //    Console.WriteLine("Tuesday");
        //}
        //else if (day == 3)
        //{
        //    Console.WriteLine("Wednesday");
        //}
        //else
        //{
        //    Console.WriteLine("Error");
        //}
        //switch(day)
        //{
        //    case 1:
        //    case 4:
        //    case 5:
        //        Console.WriteLine("Monday");
        //        break;
        //    case 2:
        //        Console.WriteLine("Tuesday");
        //        break;
        //    case 3:
        //        Console.WriteLine("WednesDay");
        //        break;
        //    default:
        //        Console.WriteLine("Error");
        //        break;
        //}
        /* ConsoleKey key;
         while((key = Console.ReadKey().Key) != ConsoleKey.Escape)
         {
             switch(key)
             {
                 case ConsoleKey.LeftArrow:
                     Console.WriteLine("LeftArrow");
                     break;
                 case ConsoleKey.RightArrow:
                     Console.WriteLine("RightArrow");
                     break;
                 case ConsoleKey.UpArrow:
                     Console.WriteLine("UpArrow");
                     break;
                 case ConsoleKey.DownArrow:
                     Console.WriteLine("DownArrow");
                     break;
                 default:
                     break;
             }
         }*/
        //int res;
        //do
        //{
        //    Console.Write("2 + 2 = ");
        //    res = int.Parse(Console.ReadLine());

        //} while (res != 4);



        //Task 1
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("\tIt's easy to win forgiveness for being wrong;\n \tbeing right is what gets you into real trouble.\n \tBjarne Stroustrup");

        //Task 2
        int max = 0;
        int sum = 0;
        int min = 0;
        int dob = 1;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Ведіть чмсло --> ");
            int num = Convert.ToInt32(Console.ReadLine());
            sum += num;
            if (i == 0)
            {
                max = num;
                min = num;
            }
            if (num < min)
            {
                min = num;
            }
            if (num > max)
            {
                max = num;
            }
            dob *= num;

        }

        Console.WriteLine($"Sum --> {sum}; Max --> {max}; Min --> {min}; Dod --> {dob}");

        //Task 3
        int num1 = Convert.ToInt32(Console.ReadLine());
        int n = 100000;
        if(num1 / n != 0)
        {
            int num2 = num1 / 100000;
            int num3 = num1 % 100000 / 10000;
            int num4 = num1 % 100000 % 10000 / 1000;
            int num5 = num1 % 100000 % 10000 % 1000 / 100;
            int num6 = num1 % 100000 % 10000 % 1000 % 100 / 10;
            int num7 = num1 % 100000 % 10000 % 1000 % 100 % 10;
            Console.WriteLine($"{num7}{num6}{num5}{num4}{num3}{num2}");

        }
        else
        {
            Console.WriteLine("Number not 6");
        }




       
       




    }
    static void ReadChar()
    {
        Console.Write("Enter symbol :: ");

        char symbol = (char)Console.Read();
        Console.WriteLine("Symbol :: \t" + symbol);
        Console.WriteLine("IsLetter :: \t" + char.IsLetter(symbol));


    }
}