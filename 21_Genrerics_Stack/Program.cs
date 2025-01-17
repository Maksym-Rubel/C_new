using _21_Genrerics_Stack;

internal class Program
{
    private static void Main(string[] args)
    {
        MyStack<int> stack = new MyStack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);
        stack.Push(6);

        while(stack.Count > 0)
        {
            Console.WriteLine(stack.Peek());
            stack.Pop();
        }

    }
}