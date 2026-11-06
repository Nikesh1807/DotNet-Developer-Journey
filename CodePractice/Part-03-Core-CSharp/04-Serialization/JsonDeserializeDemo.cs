using System.Text.Json;

public static class JsonDeserializeDemo
{
    public static void Run()
    {
        string json = """{"Name":"Diya","Age":20}""";
        Student? student = JsonSerializer.Deserialize<Student>(json);

        if (student is not null)
            Console.WriteLine($"{student.Name} is {student.Age} years old.");
    }

    private class Student
    {
        public string Name { get; set; } = "";
        public int Age { get; set; }
    }
}
