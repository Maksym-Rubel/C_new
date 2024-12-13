using System.Text;

internal class Program
{
    //static int sum(int a , int b)
    //{
    //    return a + b;
    //}
    static int sum(params int[] arr)
    {
        return arr.Sum();
    }
    static void Print<T>(T[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j],-20}");
            }
            Console.WriteLine();
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
    static void MathRows(double[,] arr,ref double max,ref double min, ref double sum,ref double dob)
    {
        max = arr[0, 0];
        min = arr[0, 0];
        sum = 0;
        dob = 1;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
           

            for (int j = 0; j < arr.GetLength(1); j++)
            {
               if(max < arr[i, j])
                    max = arr[i, j];
               if(min > arr[i, j])
                    min = arr[i, j];
               sum += arr[i, j];
               dob *= arr[i, j];
            }
           
        }
    }
    private static void Main(string[] args)
    {


        //StringBuilder text = new StringBuilder("hello world");
        //Console.WriteLine(text);
        //text[0] = char.ToUpper(text[0]);
        //Console.WriteLine(text);
        //text.Append(" !!! C# C# ")

        //string text = "C# world C# !!!!!";
        //char[] chars = text.ToCharArray();
        //chars[0] = char.ToUpper(chars[0]);
        //Console.WriteLine(text);
        //Console.WriteLine(chars);

        //text = new string(chars);
        //Console.WriteLine(text);

        //Console.WriteLine(text.Contains("C#"));
        //Console.WriteLine(text.StartsWith("C#"));
        //Console.WriteLine(text.EndsWith("C#"));


        //var index = text.IndexOf("C#");
        //Console.WriteLine($"IndexOf :: {index}");
        //index = text.IndexOfAny("abcd".ToCharArray());
        //Console.WriteLine($"IndexOfAny :: {index}");

        //string one = "Apple", two = "Apirol";
        //Console.WriteLine($"CompareTo ::  {one.CompareTo(two)}");
        //two = "apple";
        //Console.WriteLine($"CompareTo ::  {String.CompareOrdinal(one,two)}");

        //Console.WriteLine($"CompareTo ::  {String.Compare(one,two,true)}");


        //string numb = "1,2,3,4,5,6,7,8,9,10";
        //string[] numbers = numb.Split(',');

        //string[] colors = { "red", "yellow", "blue" };
        //Console.WriteLine(String.Join(",",colors));


        int[] A = new int[5];
        double[,] B = new double[3,4];
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write("Enter number --> ");
            int num = int.Parse(Console.ReadLine());
            A[i] = num;
        }
        Random rnd = new Random();
        Print(A);
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                double min = 1.0;
                double max = 10.0;

                B[i, j] = min + rnd.NextDouble() * (max - min) ;
            }
            Console.WriteLine();
        }
        Print(B);

        double maxElementB = 0;
        double MinElementB = 0;
        double SumElementB = 0;
        double DobElementB = 0;
        

        int maxElementA = A.Max();
        int MinElementA = A.Min();
        int SumElementA = A.Sum();
        int DobElementA = 1;
        int Sumparnuh = 0;
        double Sumbeparnuh = 0;


        for (int i = 0; i < A.Length; i++)
        {
            DobElementA += A[i];
            if(A[i] % 2 == 0)
            {
                Sumparnuh += A[i];
            }
        }

        MathRows(B, ref maxElementB, ref MinElementB, ref SumElementB, ref DobElementB);


        double globalMax = Math.Max(maxElementA, maxElementB);
        double globalMin = Math.Min(MinElementA, MinElementB);
        double globalSum = SumElementA + SumElementB;
        double globalDob = DobElementA * DobElementB;


        for(int i = 0; i < B.GetLength(0); i++)
        {
            if (i % 2 != 0) 
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Sumbeparnuh += B[i, j];
                }
            }
        }



        Console.WriteLine($"Max Element: {globalMax}");
        Console.WriteLine($"Min Element: {globalMin}");
        Console.WriteLine($"Sum Element: {globalSum}");
        Console.WriteLine($"Dob Element: {globalDob}");

        Console.WriteLine($"Sumparnuh A Element: {Sumparnuh}");
        Console.WriteLine($"Sumbeparnuh  B Element: {Sumbeparnuh}");


        

        //int[,] C = new int[5, 5];
        //for (int i = 0; i < C.GetLength(0); i++)
        //{
        //    for (int j = 0; j < C.GetLength(1); j++)
        //    {
        //        C[i, j] = rnd.Next(-100,100);
        //    }
        //}
        //int maxc = C[0, 0];
        //int minc = C[0, 0];
        //int maxI;
        //int maxJ;
        //int minI;
        //int minJ;



        //for (int i = 0; i < C.GetLength(0); i++)
        //{
        //    for (int j = 0; j < C.GetLength(1); j++)
        //    {
        //        if (maxc < C[i, j])
        //        {
        //            maxc = C[i, j];
        //            maxI = i;
        //            maxJ = j;
        //        }
        //        if (minc > C[i, j])
        //        {
        //            minc = C[i, j];
        //            minI = i;
        //            minJ = j;
        //        }
        //    }
        //}
       
    }
}