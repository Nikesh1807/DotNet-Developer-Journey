public static class DirectoryDemo
{
    public static void Run()
    {
        string folder = "PracticeFiles";
        Directory.CreateDirectory(folder);
        Console.WriteLine($"Folder exists: {Directory.Exists(folder)}");

        foreach (string file in Directory.GetFiles(folder))
            Console.WriteLine(file);
    }
}
