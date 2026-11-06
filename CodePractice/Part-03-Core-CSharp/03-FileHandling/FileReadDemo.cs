public static class FileReadDemo
{
    public static void Run()
    {
        string path = Path.Combine("PracticeFiles", "message.txt");

        if (File.Exists(path))
            Console.WriteLine(File.ReadAllText(path));
        else
            Console.WriteLine("File not found. Run FileWriteDemo first.");
    }
}
