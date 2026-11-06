public static class PathDemo
{
    public static void Run()
    {
        string folder = "PracticeFiles";
        string fileName = "students.json";
        string fullPath = Path.Combine(folder, fileName);

        Console.WriteLine($"Combined path: {fullPath}");
        Console.WriteLine($"Extension: {Path.GetExtension(fullPath)}");
        Console.WriteLine($"File name: {Path.GetFileName(fullPath)}");
    }
}
