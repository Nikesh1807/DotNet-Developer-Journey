public static class GroupingDemo
{
    public static void Run()
    {
        var students = new[]
        {
            new { Name = "Aarav", Department = "IT" },
            new { Name = "Diya", Department = "HR" },
            new { Name = "Rohan", Department = "IT" }
        };

        var groups = students.GroupBy(student => student.Department);

        foreach (var group in groups)
        {
            Console.WriteLine(group.Key);
            foreach (var student in group)
                Console.WriteLine($" - {student.Name}");
        }
    }
}
