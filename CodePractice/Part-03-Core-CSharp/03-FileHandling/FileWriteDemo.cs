public static class FileWriteDemo
{
    public static void Run()
    {
        string folder = "PracticeFiles";
        Directory.CreateDirectory(folder);
        string path = Path.Combine(folder, "message.txt");
        File.WriteAllText(path, "Hello! This text was saved using C#.");
        Console.WriteLine($"Text written to: {path}");
    }
}
