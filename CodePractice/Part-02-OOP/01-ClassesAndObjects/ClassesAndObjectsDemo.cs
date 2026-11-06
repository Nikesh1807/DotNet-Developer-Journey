public static class ClassesAndObjectsDemo
{
    public static void Run()
    {
        Car car = new Car();
        car.Brand = "Toyota";
        car.Model = "Corolla";
        car.DisplayDetails();
    }

    private class Car
    {
        public string Brand { get; set; } = "";
        public string Model { get; set; } = "";

        public void DisplayDetails()
        {
            Console.WriteLine($"{Brand} {Model}");
        }
    }
}
