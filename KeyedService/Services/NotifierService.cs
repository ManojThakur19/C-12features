namespace KeyedService.Services
{
    public class NotifierService
    {
        private readonly INotificationService _notificationServices;
        public NotifierService(IEnumerable<INotificationService> notificationServices)
        {
            _notificationServices = notificationServices.First();
        }

    }


    public interface INotifierService { 
        string Notify { get; }
    }
}
