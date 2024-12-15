internal class Program
{
    static bool isPosistive(int a)
    {
        return a > 0;
    }
    static int[] CreateArr(int size)
    {
        return new int[size];
    }
    static void FillRandArr(int[] arr, int min = -100, int max = 100)
    {
        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(min, max);    
        }
    }
    static void Print<T>(T[] arr, string prompt = "")
    {
        Console.Write(prompt);
        foreach (var item in arr)
        {
            Console.Write($"{item,-10}");
        }
        Console.WriteLine();
    }
    static void Swap(ref int x, ref int y)
    {
        var tmp = x;
        x = y;
        y = tmp;
    }
    static void SwapArray(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i += 2)
        {
            Swap(ref arr[i], ref arr[i + 1]);
        }
    }
 
    static int PrintFirstAdd(int[] arr)
    {
        int firstPositive = Array.FindIndex(arr, isPosistive);
        if (firstPositive != -1)
        {
            return arr[firstPositive];
        }
        else
        {
            return 0;
        }
    }
    static void CountParni(int[] arr)
    {
        Console.WriteLine($"Number of elements is parni ::{arr.Count(e => e % 2 == 0)}");
    }
    static int PrintSevenAdd(int[] arr)
    {
        int SevenDel = Array.FindIndex(arr, (int e) => { return e % 7 == 0; });
        if (SevenDel != -1)
        {
            return SevenDel;
        }
        else
        {
            return 0;
        }
    }
    private static void Main(string[] args)
    {
        int[] arr1 = CreateArr(5);
        FillRandArr(arr1);
        Print(arr1);
        SwapArray(arr1);
        Print(arr1);
        Console.WriteLine($"First add number {PrintFirstAdd(arr1)}");

        CountParni(arr1 );
        Console.WriteLine($"First seven number {PrintSevenAdd(arr1)}");



    }
}