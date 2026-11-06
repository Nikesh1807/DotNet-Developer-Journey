public static class SortingDemo
{
    public static void Run()
    {
        List<int> marks = new() { 72, 91, 65, 88 };
        var ascending = marks.OrderBy(mark => mark);
        var descending = marks.OrderByDescending(mark => mark);

        Console.WriteLine("Ascending: " + string.Join(", ", ascending));
        Console.WriteLine("Descending: " + string.Join(", ", descending));
    }
}
