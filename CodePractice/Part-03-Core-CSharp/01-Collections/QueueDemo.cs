public static class QueueDemo
{
    public static void Run()
    {
        Queue<string> line = new();
        line.Enqueue("Customer 1");
        line.Enqueue("Customer 2");

        Console.WriteLine($"Next: {line.Peek()}");
        Console.WriteLine($"Served: {line.Dequeue()}");
        Console.WriteLine($"Waiting: {line.Count}");
    }
}
