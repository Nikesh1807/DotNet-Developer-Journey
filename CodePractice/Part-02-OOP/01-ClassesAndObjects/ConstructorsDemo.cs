public static class ConstructorsDemo
{
    public static void Run()
    {
        Product product = new Product("Keyboard", 1200);
        product.Display();
    }

    private class Product
    {
        private readonly string _name;
        private readonly decimal _price;

        public Product(string name, decimal price)
        {
            _name = name;
            _price = price;
        }

        public void Display() => Console.WriteLine($"{_name}: ₹{_price}");
    }
}
