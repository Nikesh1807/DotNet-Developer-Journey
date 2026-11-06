public static class AggregateDemo
{
    public static void Run()
    {
        List<int> marks = new() { 70, 80, 90, 100 };

        Console.WriteLine($"Count: {marks.Count}");
        Console.WriteLine($"Sum: {marks.Sum()}");
        Console.WriteLine($"Average: {marks.Average()}");
        Console.WriteLine($"Minimum: {marks.Min()}");
        Console.WriteLine($"Maximum: {marks.Max()}");
    }
}
