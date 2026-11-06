public static class AbstractionDemo
{
    public static void Run()
    {
        Payment payment = new CardPayment();
        payment.Pay(500);
    }

    private abstract class Payment
    {
        public abstract void Pay(decimal amount);
    }

    private class CardPayment : Payment
    {
        public override void Pay(decimal amount) =>
            Console.WriteLine($"Paid ₹{amount} using card.");
    }
}
