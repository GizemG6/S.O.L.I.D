namespace DependencyInversionPrinciple
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dependency Inversion Principle(DIP): High-level modules should not depend on low-level modules; " +
                "both should depend on abstractions.");
        }
    }
    public class Run
    {
        public void Print()
        {
            Console.WriteLine("Dependency Inversion Principle(DIP): High-level modules should not depend on low-level modules; " +
                "both should depend on abstractions.");
        }
    }

    // NotificationManager_Wrong directly depends on the EmailService_Wrong class.
    // This makes it difficult to change dependencies and reduces the testability of the code.

    public class NotificationManager_Wrong
    {
        private EmailService_Wrong _emailService;

        public NotificationManager_Wrong()
        {
            _emailService = new EmailService_Wrong();
        }

        public void SendNotification(string message)
        {
            _emailService.SendEmail(message);
        }
    }

    // The NotificationManager_Correct class depends on the IMessageService interface,
    // which allows you to use different message services and makes dependencies more flexible.

    public class NotificationManager_Correct
    {
        private IMessageService _messageService;

        public NotificationManager_Correct(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void SendNotification(string message)
        {
            _messageService.SendMessage(message);
        }
    }
}
