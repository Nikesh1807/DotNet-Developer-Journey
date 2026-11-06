public static class EncapsulationDemo
{
    public static void Run()
    {
        BankAccount account = new BankAccount();
        account.Deposit(500);
        Console.WriteLine($"Balance: ₹{account.GetBalance()}");
    }

    private class BankAccount
    {
        private decimal _balance;

        public void Deposit(decimal amount)
        {
            if (amount > 0) _balance += amount;
        }

        public decimal GetBalance() => _balance;
    }
}
