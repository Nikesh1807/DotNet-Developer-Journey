public static class InterfacesDemo
{
    public static void Run()
    {
        INotification notification = new EmailNotification();
        notification.Send("Your registration is complete.");
    }

    private interface INotification
    {
        void Send(string message);
    }

    private class EmailNotification : INotification
    {
        public void Send(string message) =>
            Console.WriteLine($"Email sent: {message}");
    }
}
