public static class ListDemo
{
    public static void Run()
    {
        List<string> students = new() { "Aarav", "Diya", "Rohan" };
        students.Add("Meera");
        students.Remove("Diya");

        foreach (string student in students)
            Console.WriteLine(student);

        Console.WriteLine($"Count: {students.Count}");
    }
}
