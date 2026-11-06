public static class OperatorsDemo
{
    public static void Run()
    {
        int first = 20;
        int second = 6;

        Console.WriteLine($"Addition: {first + second}");
        Console.WriteLine($"Remainder: {first % second}");
        Console.WriteLine($"Is first greater? {first > second}");
        Console.WriteLine($"Both are positive? {first > 0 && second > 0}");
    }
}
