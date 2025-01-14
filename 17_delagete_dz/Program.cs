
delegate bool Condition<T>(T numb);

internal class Program
{

    public static T[] ArrayFunc<T>(T[] arr, Condition<T> func)
    {
        T[] arr_ = new T[0];
        foreach (var item in arr)
        {
            if (func(item))
            {
                Array.Resize(ref arr_, arr_.Length + 1);
                arr_[arr_.Length - 1] = item;
            }
        }
        return arr_;
    }

    private static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 13, 21, 34, 55, 89 };
        Console.WriteLine("Even Numbers: " + string.Join(", ", ArrayFunc(arr, e => e % 2 == 0)));
        Console.WriteLine("Odd Numbers: " + string.Join(", ", ArrayFunc(arr, e => e % 2 != 0)));
        Console.WriteLine("Prime Numbers: " + string.Join(", ", ArrayFunc(arr, e => isPrime(e))));
        Console.WriteLine("Fubanaci Numbers: " + string.Join(", ", ArrayFunc(arr, e => isFabonacci(e))));


        Action showTime = () => Console.WriteLine("Time : " + DateTime.Now.ToString("t"));
        Action showDate = () => Console.WriteLine("Time : " + DateTime.Now.ToString("d"));
        Action showDay = () => Console.WriteLine("Time : " + DateTime.Now.ToString("dddd"));
        Func<int, int, double> Triangle = (one, two) => 0.5 * one * two;
        Func<int, int, double> Rectangle = (one, two) => one * two;


        showTime();
        showDate();
        showDay();
        Console.WriteLine($"Triangle :: {Triangle(8, 5)}");
        Console.WriteLine($"Rectangle :: {Rectangle(5, 5)}");



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