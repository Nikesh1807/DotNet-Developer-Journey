public static class ArraysDemo
{
    public static void Run()
    {
        int[] marks = { 75, 82, 91, 68 };

        for (int i = 0; i < marks.Length; i++)
            Console.WriteLine($"Marks[{i}] = {marks[i]}");

        Console.WriteLine($"Total subjects: {marks.Length}");
    }
}
