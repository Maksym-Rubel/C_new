using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {


        //string pattern = @"\d";
        //var regex = new Regex(pattern);

        //while (true)
        //{
        //    string line = Console.ReadKey().KeyChar.ToString();
        //    if (line == " ")
        //        break;
        //    Console.WriteLine($" is number --> {regex.IsMatch(line)}");
        //}

        //var arr = new[] { "test", "123", "test123", "123test", "test123test" };
        //string pattern = @"\D{6,}";
        //var regex = new Regex(pattern);
        //foreach (var item in arr)
        //{
        //    Console.WriteLine($"{item} --> {regex.IsMatch(item)}");
        //}

        //Console.WriteLine();

        ////pattern = @"^[A-Za-z0-9/.]*";
        //pattern = @"^\w*$";

        //regex = new Regex(pattern);
        //while (true)
        //{
        //    Console.WriteLine("Enter line :: ");
        //    string line = Console.ReadLine()!;
        //    if (line == "exit")
        //        break;
        //    Console.WriteLine($"{line} --> {regex.IsMatch(line)}");
        //    Console.WriteLine(new string('_',15));
        //}


        //string value = "4 - 5 AND 5 y 789";
        //Match match = Regex.Match(value, @"\d");
        //if(match.Success )
        //{
        //    Console.WriteLine(match.Value);
        //}
        //match = match.NextMatch();
        //if (match.Success)
        //{
        //    Console.WriteLine(match.Value);
        //}

        //while(match.Success)
        //{
        //    Console.WriteLine($"Value{match.Value}, Index {match.Index} Length {match.Length}");
        //    match.NextMatch();
        //}

        //Match match = Regex.Match("123 Axx-1-xxy \n Axy-2xxxy 541", @"A.*y");
        //while (match.Success)
        //{
        //    Console.WriteLine($"Value{match.Value}, Index {match.Index} Length {match.Length}");
        //    match = match.NextMatch();
        //}

        //string value = "sasisiai asiai sasidiaid sadiasidiad fgghfd";
        //var m = Regex.Matches(value, @"s\w+d");
        //foreach(Match match in m)
        //{
        //    Console.WriteLine($"Value {match.Value}, Index {match.Index} Length {match.Length}");

        //}

        //var input = "Dont replace Dot Net replaced Net net dots";
        //var output = Regex.Replace(input, @"N.t", "NET", RegexOptions.IgnoreCase);
        //Console.WriteLine(input);

        //Console.WriteLine(output);


        var text = "bla bla 145323223 arggs jjhdj aalert 484345435 Bye!";
        var output = Regex.Replace(text, @"(\d{2})(\d{2})(\d{2})(\d{3})", "+38(0$1}-$2-$3-$4");
        Console.WriteLine(text);

        Console.WriteLine(output);

    }
}