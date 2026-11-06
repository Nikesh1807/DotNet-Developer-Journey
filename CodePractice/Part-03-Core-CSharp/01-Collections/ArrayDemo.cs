public static class ArrayDemo
{
    public static void Run()
    {
        int[] scores = { 70, 85, 90 };
        Console.WriteLine($"First score: {scores[0]}");
        Console.WriteLine($"Number of scores: {scores.Length}");
        foreach (int score in scores) Console.WriteLine(score);
    }
}
