public static class PolymorphismDemo
{
    public static void Run()
    {
        Shape[] shapes = { new Circle(), new Rectangle() };
        foreach (Shape shape in shapes)
            shape.Draw();
    }

    private class Shape
    {
        public virtual void Draw() => Console.WriteLine("Drawing a shape");
    }

    private class Circle : Shape
    {
        public override void Draw() => Console.WriteLine("Drawing a circle");
    }

    private class Rectangle : Shape
    {
        public override void Draw() => Console.WriteLine("Drawing a rectangle");
    }
}
