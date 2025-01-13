
delegate bool Condition<T>(T numb);

internal class Program
{
   

    public static int CountInArray<T>(T[] arr, Condition<T> func)
    {
        int count = 0;
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    if(func(i))
        //        count++;
        //}
        return count;
    }

    public static T[] FilterArray<T>(T[] arr, Condition<T> func)
    {
        T[] arr_ = new T[0];
        foreach(var item in arr)
        {
            if(func(item))
            {
                Array.Resize(ref arr_, arr_.Length + 1);
                arr_[arr_.Length - 1] = item;
            }
        }
        return arr_;
    }




    private static void Main(string[] args)
    {
        int[] arr = { 1, 8, -4, -5, -7, 6, 3, 5, -6 };
        Console.WriteLine($"Number positive elements :: {CountInArray(arr,e => e > 0)}");
        Console.WriteLine($"Number negative elements :: {CountInArray(arr, e => e < 0)}");

        double[] arr2 = {1.5, -5.3, 2.3, -14.2, 2.5 };
    }
}