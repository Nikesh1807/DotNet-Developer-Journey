public static class MethodsAndPropertiesDemo
{
    public static void Run()
    {
        Employee employee = new Employee { Name = "Aarav", Salary = 35000 };
        Console.WriteLine($"{employee.Name} earns ₹{employee.Salary}");
    }

    private class Employee
    {
        public string Name { get; set; } = "";
        public decimal Salary { get; set; }
    }
}
