class Program
{
    public static void Main()
    {
        Stack<int> Stack = new Stack<int>();
        while (Stack.Count < 6)
        {
            Console.WriteLine("Enter a number");
            Stack.Push(int.Parse(Console.ReadLine()!));
        }
        while (Stack.Count > 0)
        {
            Console.WriteLine(Stack.Pop());
        }
    }
    public static Stack<int> ReverseStack(Stack<int> Stack)
    {
        Stack<int> Reversed = new Stack<int>();
        while (Stack.Count > 0)
        {
            Reversed.Push(Stack.Pop());
        }
        return Reversed;
    }
}