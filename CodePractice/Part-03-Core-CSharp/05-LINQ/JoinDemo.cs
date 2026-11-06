public static class JoinDemo
{
    public static void Run()
    {
        var employees = new[]
        {
            new { Name = "Aarav", DepartmentId = 1 },
            new { Name = "Diya", DepartmentId = 2 }
        };

        var departments = new[]
        {
            new { Id = 1, Name = "IT" },
            new { Id = 2, Name = "HR" }
        };

        var result = employees.Join(
            departments,
            employee => employee.DepartmentId,
            department => department.Id,
            (employee, department) => new { employee.Name, Department = department.Name });

        foreach (var item in result)
            Console.WriteLine($"{item.Name} works in {item.Department}");
    }
}
