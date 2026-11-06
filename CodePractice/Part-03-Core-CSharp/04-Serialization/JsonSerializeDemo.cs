using System.Text.Json;

public static class JsonSerializeDemo
{
    public static void Run()
    {
        Student student = new("Aarav", 21);
        string json = JsonSerializer.Serialize(student);
        Console.WriteLine(json);
    }

    private record Student(string Name, int Age);
}
