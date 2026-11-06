public static class LoopsDemo
{
    public static void Run()
    {
        Console.WriteLine("For loop:");
        for (int i = 1; i <= 5; i++)
            Console.Write($"{i} ");

        Console.WriteLine("\nWhile loop:");
        int count = 1;
        while (count <= 3)
        {
            Console.Write($"{count} ");
            count++;
        }

        Console.WriteLine();
    }
}
