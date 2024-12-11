internal class Program
{
    static void BadSwap(int x, int y)
    {
        var tmp = x;
        x = y;
        y = tmp;
    }
    // ref // out
    static void Swap(ref int x, ref int y)
    {
        var tmp = x;
        x = y;
        y = tmp;
    }
    static void SumTwo(int a, int b, out int res)
    {
        res = a + b;
    }

    
    static void Print<T>(T[] arr, string prompt = "")
    {
        Console.Write(prompt);
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.Write($"{arr[i],-10}");


        //}
        foreach (var item in arr)
        {
            Console.Write($"{item,-10}");
        }
        Console.WriteLine();
    }


    static void Fill(int[] arr, int min = 0 , int max = 50)
    {
        Random rnd = new Random();
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(min, max);
        }
    }
    static void PushBack(ref int[] arr,int value)
    {
        
        int[] tmp = new int[arr.Length + 1];
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    tmp[i] = arr[i];
        //}
        //arr.CopyTo(tmp, 0 );
        //tmp[tmp.Length -1] = value;
        //arr = tmp;
        Array.Resize(ref tmp, tmp.Length);
        arr[arr.Length - 1] = value;

    }
    private static void Main(string[] args)
    {
        //int a = 5, b = 10;
        //Console.WriteLine($"a = {a,-10} b = {b}");
        //Swap(ref a, ref b);
        //int res;

        //SumTwo( a, b, out res);

        //Console.WriteLine($"a = {a,-10} b = {b}");


        int[] arr = new int[5] { 1,2,3,4,5};
        int[] arr2 = { 10, 20, 30, 40, 50 };
        //int[] arr3;
        Print(arr, "Array --> ");
        Print(arr, "Array2 --> ");
        Console.Write("Enter number of elements :: ");
        int size = 10; //int.Parse(Console.ReadLine());
        int[] arr3 = new int[size];
        Fill(arr3,-10,10);


        //Console.WriteLine();
        //Print(arr3, "Array3 --> ");
        //PushBack(ref arr3, 10);
        //Print(arr3, "Array3 --> ");


        //int value = 10;
        //if (arr3.Contains(value))
        //{


        //}
        //else { Console.WriteLine($"Value {value} not found"); }

        //Console.WriteLine($"Number of elements is pisitive ::{arr3.Count(isPosistive)}");

        //int index = Array.IndexOf(arr3, value);
        //if(index != -1)
        //{
        //    Console.WriteLine($"Value {value} = index {index}");
        //    int lasIndex = Array.LastIndexOf(arr3, value);
        //    Console.WriteLine($"Value {value} = index {lasIndex}");

        //}

        //int firstPositive = Array.FindIndex(arr3, isPosistive);
        //if (firstPositive != -1)
        //{
        //    Console.WriteLine($"Value positive = index {firstPositive}");
        //    int lastPositive = Array.FindLastIndex(arr3, isPosistive);
        //    Console.WriteLine($"Value positive = index {lastPositive}");

        //}
        //index = Array.FindIndex(arr3, (int e) => { return e % 3 == 0; });
        //Console.WriteLine($"position first number % 3 --> {index}");

        //int[] events = Array.FindAll(arr3, e => e % 2 == 0);
        //Print(events, "Print even elements :: ");
        //Console.WriteLine(Array.TrueForAll(arr3, isPosistive));
        //Console.WriteLine(Array.Exists(arr3, isPosistive));


        //Print(arr3, "Array3 --> ");
        //Array.Sort(arr3);
        //Print(arr3, "Array3 --> ");

        //Array.Reverse(arr3);
        //Print(arr3, "Array3 --> ");
        //Console.WriteLine(arr3.Sum());
        //Console.WriteLine(arr3.Min());
        //Console.WriteLine(arr3.Max());
        //Console.WriteLine(arr3.Average());

        //string[] colors = { "red", "yellow", "Gold", "purple", "aque" };
        //Array.Sort(colors);
        //Print(colors, "Array colors ");
        //Array.Sort(colors,(s1,s2) => s1.Length.CompareTo(s2.Length));

        Print(arr3, "Array arr3 ");

        Console.WriteLine($"Number of elements is parni ::{arr3.Count(e => e % 2 == 0)}");
        Console.WriteLine($"Number of elements is ne parni ::{arr3.Count(e => e % 2 != 0)}");
        int counter = 0;
        for (int i = 0; i < arr3.Length; i++)
        {
            bool isUn = true;
            for (int j = 0; j < arr3.Length; j++)
            {
                if (i != j && arr3[i] == arr3[j])
                {
                    isUn = false;
                    break; 
                }
            }
            if (isUn)
            {
                counter++;
            }
        }
        Console.WriteLine($"Number of elements is unikal ::{counter}");


        //Count
    }

    static bool isPosistive(int a)
    {
        return a > 0;
    }
 
}
