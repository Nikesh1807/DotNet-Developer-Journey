public static class IfElseDemo
{
    public static void Run()
    {
        int marks = 76;

        if (marks >= 80)
            Console.WriteLine("Distinction");
        else if (marks >= 60)
            Console.WriteLine("First class");
        else
            Console.WriteLine("Needs improvement");
    }
}
