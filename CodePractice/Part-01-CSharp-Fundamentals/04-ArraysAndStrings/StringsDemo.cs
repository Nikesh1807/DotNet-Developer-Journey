public static class StringsDemo
{
    public static void Run()
    {
        string course = "CSharp Developer Journey";

        Console.WriteLine(course.ToUpper());
        Console.WriteLine($"Length: {course.Length}");
        Console.WriteLine($"Contains CSharp: {course.Contains("CSharp")}");
        Console.WriteLine(course.Replace("Journey", "Learning"));
    }
}
