public static class FirstSingleDemo
{
    public static void Run()
    {
        List<string> names = new() { "Aarav", "Diya", "Rohan" };

        string? firstName = names.FirstOrDefault();
        string? missingName = names.FirstOrDefault(name => name == "Meera");

        Console.WriteLine($"First: {firstName}");
        Console.WriteLine($"Missing search result: {missingName ?? "No match"}");
    }
}
