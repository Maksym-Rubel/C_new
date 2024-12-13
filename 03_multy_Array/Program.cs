internal class Program
{
    //static void Swap(ref int x, ref int y)
    //{
    //    var tmp = x;
    //    x = y;
    //    y = tmp;
    //}
    //static void Print<T>(T[] arr, string prompt = "")
    //{
    //    Console.Write(prompt);
    //    foreach (var item in arr)
    //    {
    //        Console.Write($"{item,-10}");
    //    }
    //    Console.WriteLine();
    //}


    //static void Fill(int[] arr, int min = 0, int max = 50)
    //{
    //    Random rnd = new Random();
    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        arr[i] = rnd.Next(min, max);
    //    }
    //}

    //static void SwapArray(int[] arr)
    //{
    //    for (int i = 0; i <= arr.Length; i+=2)
    //    {
    //        Swap(ref arr[i],ref arr[i+1]);
    //    }
    //}


    static void Print(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i,j], -10}");
            }
            Console.WriteLine();
        }
    }

    static void Print(int[][] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.Write($"{arr[i][j],-10}");
            }
            Console.WriteLine();
        }
    }
    static void MathRows(int[][] arr)
    {
        foreach (int[] row in arr)
        {
            Console.WriteLine($"Sum :: {row.Sum()}");
            Console.WriteLine($"Min :: {row.Min()}");
            Console.WriteLine($"Max :: {row.Max()}");
            Console.WriteLine($"Average :: {row.Average()}");
            Console.WriteLine();
        }
    }
    static void ChangeRows(int[][] arr,int row1,int row2)
    {
        if(row1 > 0 &&  row2 > 0 && row1 < arr.Length && row2 < arr.Length)
        {
            int[] tmp = arr[row1];
            arr[row1] = arr[row2];
            arr[row2] = tmp;
            
        }
       
    }

    private static void Main(string[] args)
    {
        //int[] arr = new int[10];
        //Fill(arr);
        //Print(arr, "Print Array");
        //SwapArray(arr);
        //Print(arr, "Print Array");

        //int[,] arr = new int[3, 4] {
        //    {1,2,3,4}, 
        //    {12,23,34,45 },
        //    {111,222,333,444 }
        //};
        //Print(arr);

        int[][] arr = new int[4][];
        arr[0] = new int[] { 1,2,3};
        arr[1] = new int[] { 1, 2, 3,4,5 };
        arr[2] = new int[] { 1,2 };
        arr[3] = new int[] { 1, 2 ,3,4};
        Print(arr);
        MathRows(arr);
        for(int i = 0; i < arr.Length/2; i++) 
            {
            ChangeRows(arr, i, arr.Length - 1 - i);
            
            }
        Print(arr);

    }
}