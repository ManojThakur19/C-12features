namespace KeyedService.Services
{
    public interface INotificationService
    {
        string Notify(string message);
    }

    public class SmsNotificationService : INotificationService
    {
        public string Notify(string message) => $"[SMS] {message}";
    }

    public class EmailNotificationService : INotificationService
    {
        public string Notify(string message) => $"[EMAIL] {message}";
    }
}
