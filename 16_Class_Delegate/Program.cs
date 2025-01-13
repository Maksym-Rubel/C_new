
using static System.Runtime.InteropServices.JavaScript.JSType;

delegate void ShowMessage(string message);

class OneShow
{

    public static void Print(string message) 
    {
        Console.WriteLine(message);
    }
}
delegate double CalcDelegate(double one, double two);
class Calculate
{
    public static double Add(double a, double b) => a + b;
    public static double Sub(double a, double b) => a - b;
    public static double Mult(double a, double b) => a * b;

}
internal class Program
{
    private static void Main(string[] args)
    {
        ShowMessage sms =  new ShowMessage(OneShow.Print);
        sms("Hello World!!");

        CalcDelegate calc = Calculate.Add;
        Console.WriteLine($"Result :: {calc(2, 3)}");
        calc += Calculate.Sub;
        Console.WriteLine($"Result :: {calc(2, 3)}");
        calc += Calculate.Mult;
        Console.WriteLine($"Result :: {calc(2, 3)}");


        Predicate<int> IsEven = number => number % 2 == 0;
        Predicate<int> IsOdd = number => number % 2 != 0;
        Predicate<int> IsPrime = number => isPrime(number);
        Predicate<int> IsFibonaci = number => isFabonacci(number);


        Console.WriteLine($"IsEven: {IsEven(22)}");
        Console.WriteLine($"IsOdd: {IsOdd(23)}");
        Console.WriteLine($"IsPrime: {IsPrime(97)}");
        Console.WriteLine($"IsFibonaci: {IsFibonaci(5)}");


    }

    static bool isPrime(int number)
    {
        if(number<= 1) return false;
        for(int i = 2; i <= number - 1; i++)
        {
            if(number % i == 0)
                return false;
        }
        return true;
    }
    static bool isFabonacci(int number)
    {
        int a = 0;
        int b = 1;
        int c = 0;
      
        while (c < number)
        {
            c = a + b;
            a = b;
            b = c;

        }
        return c == number;
    }
}