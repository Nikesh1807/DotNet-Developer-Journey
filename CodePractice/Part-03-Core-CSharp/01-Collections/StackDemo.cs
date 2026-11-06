public static class StackDemo
{
    public static void Run()
    {
        Stack<string> pages = new();
        pages.Push("Home");
        pages.Push("Products");
        pages.Push("Cart");

        Console.WriteLine($"Current page: {pages.Peek()}");
        Console.WriteLine($"Back to: {pages.Pop()}");
        Console.WriteLine($"Now: {pages.Peek()}");
    }
}
