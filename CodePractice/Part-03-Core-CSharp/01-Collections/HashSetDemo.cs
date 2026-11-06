public static class HashSetDemo
{
    public static void Run()
    {
        HashSet<int> numbers = new() { 1, 2, 2, 3, 3, 4 };
        numbers.Add(5);

        Console.WriteLine("HashSet keeps unique values:");
        foreach (int number in numbers) Console.WriteLine(number);
    }
}
