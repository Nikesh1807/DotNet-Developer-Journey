public static class GenericMethodDemo
{
    public static void Run()
    {
        PrintItem<int>(100);
        PrintItem<string>("Learning C#");
    }

    private static void PrintItem<T>(T item)
    {
        Console.WriteLine($"Value: {item}");
    }
}
