public static class InheritanceDemo
{
    public static void Run()
    {
        Manager manager = new Manager("Riya", "IT");
        manager.Introduce();
    }

    private class Employee
    {
        protected string Name;
        public Employee(string name) => Name = name;
        public void Introduce() => Console.WriteLine($"I am {Name}.");
    }

    private class Manager : Employee
    {
        private readonly string _department;
        public Manager(string name, string department) : base(name) => _department = department;

        public new void Introduce() =>
            Console.WriteLine($"I am {Name}, managing {_department}.");
    }
}
