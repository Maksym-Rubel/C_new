using _34_Dictinary_Homework;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Game game = new Game();
        game.StartGame();
    }
}