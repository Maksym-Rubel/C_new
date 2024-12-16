using System;

internal class Program
{
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
    static void Fill(int[,] arr)
    {
        Random rnd = new Random();
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = rnd.Next(0, 100);
            }
            Console.WriteLine();
        }
    }
    static void Mnoz(int[,] arr, int num)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] *= num;
            }
            Console.WriteLine();
        }
    }
    static void Dod(int[,] arr1, int[,] arr2,ref int[,] arr3)
    {
        if (arr1.GetLength(0) == arr2.GetLength(0))
        {
            if (arr1.GetLength(1) == arr2.GetLength(1))
            {
                for (int i = 0; i < arr1.GetLength(0); i++)
                {
                    for (int j = 0; j < arr1.GetLength(1); j++)
                    {
                        arr3[i,j] = arr1[i, j] + arr2[i, j];
                    }
                    
                }
            }
}
       
    }
    static int[,] MatrixMultiplication(int[,] arr1, int[,] arr2)
    {

        int[,] arr3 = new int[arr1.GetLength(0), arr2.GetLength(1)];

        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                arr3[i, j] = 0;

                for (int k = 0; k < arr1.GetLength(1); k++)
                {
                    arr3[i, j] += arr1[i, k] * arr2[k, j];
                }
            }
        }

        return arr3;
    }
    private static void Main(string[] args)
    {
        string text = Console.ReadLine();
        char[] chars = text.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            char letter = chars[i];
            if (char.IsLetter(letter))
            {
                char offset = char.IsUpper(letter) ? 'A' : 'a';
                letter = (char)((letter + 3 - offset) % 26 + offset);
            }
            chars[i] = letter;
            Console.Write(chars[i]);
        }
        Console.WriteLine();
        for (int i = 0; i < chars.Length; i++)
        {
            char letter = chars[i];
            if (char.IsLetter(letter))
            {
                char offset = char.IsUpper(letter) ? 'A' : 'a';
                letter = (char)((letter - 3 - offset) % 26 + offset);
            }
            chars[i] = letter;
            Console.Write(chars[i]);
        }

        int[,] arr1 = new int[5, 5];
        int[,] arr2 = new int[5, 5];
        int[,] arr3 = new int[5, 5];
        



        Fill(arr1);
        Fill(arr2);

        Print(arr1);
        Console.WriteLine();

        Print(arr2);
        Console.WriteLine();
   

        Mnoz(arr1, 2);
        Print(arr1);
        Console.WriteLine();

        Print(arr2);
        Console.WriteLine();

        Console.WriteLine();
        Dod(arr1, arr2, ref arr3);
        Print(arr3);
        Console.WriteLine();
        Console.WriteLine();
        
        int[,] arr4 = MatrixMultiplication(arr1, arr2);
        Print(arr4);





    }
}