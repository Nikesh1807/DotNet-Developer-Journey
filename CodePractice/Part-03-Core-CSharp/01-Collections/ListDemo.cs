// Topic: List<T>
// List<T> is a resizable collection. It can grow or shrink as items are added or removed.
public class ListDemo
{
    public static void Run()
    {
        List<string> students = new List<string>();

        students.Add("Aarav");
        students.Add("Diya");
        students.Add("Rohan");

        Console.WriteLine("All students:");
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine($"Total students: {students.Count}");

        students.Remove("Diya");

        Console.WriteLine("After removing Diya:");
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }
    }
}
