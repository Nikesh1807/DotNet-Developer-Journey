public static class WhereSelectDemo
{
    public static void Run()
    {
        List<int> numbers = new() { 2, 5, 8, 11, 14 };
        var doubledEvenNumbers = numbers
            .Where(number => number % 2 == 0)
            .Select(number => number * 2);

        foreach (int number in doubledEvenNumbers)
            Console.WriteLine(number);
    }
}
