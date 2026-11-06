public static class GenericConstraintsDemo
{
    public static void Run()
    {
        PrintObject(new Student("Nikesh"));
    }

    private static void PrintObject<T>(T item) where T : class
    {
        Console.WriteLine(item);
    }

    private class Student
    {
        private readonly string _name;
        public Student(string name) => _name = name;
        public override string ToString() => _name;
    }
}
