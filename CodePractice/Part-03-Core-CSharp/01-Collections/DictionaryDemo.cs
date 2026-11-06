public static class DictionaryDemo
{
    public static void Run()
    {
        Dictionary<string, int> ages = new()
        {
            ["Aarav"] = 21,
            ["Diya"] = 20
        };

        ages["Rohan"] = 22;

        foreach (var item in ages)
            Console.WriteLine($"{item.Key}: {item.Value}");

        if (ages.TryGetValue("Diya", out int age))
            Console.WriteLine($"Diya is {age}");
    }
}
