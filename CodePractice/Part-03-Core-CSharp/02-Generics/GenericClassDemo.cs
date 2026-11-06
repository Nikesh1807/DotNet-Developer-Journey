public static class GenericClassDemo
{
    public static void Run()
    {
        Box<int> numberBox = new(25);
        Box<string> textBox = new("Hello");
        Console.WriteLine(numberBox.Value);
        Console.WriteLine(textBox.Value);
    }

    private class Box<T>
    {
        public T Value { get; }
        public Box(T value) => Value = value;
    }
}
