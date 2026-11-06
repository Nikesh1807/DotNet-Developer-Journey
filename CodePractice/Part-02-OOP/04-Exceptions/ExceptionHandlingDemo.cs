public static class ExceptionHandlingDemo
{
    public static void Run()
    {
        try
        {
            int divisor = 0;
            int result = 100 / divisor;
            Console.WriteLine(result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Cannot divide by zero: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Calculation attempt finished.");
        }
    }
}
