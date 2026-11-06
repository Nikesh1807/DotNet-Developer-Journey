public static class MethodsDemo
{
    public static void Run()
    {
        Greet("Nikesh");
        int total = Add(10, 20);
        Console.WriteLine($"Sum: {total}");
    }

    private static void Greet(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    private static int Add(int a, int b)
    {
        return a + b;
    }
}
