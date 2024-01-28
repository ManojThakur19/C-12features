using KeyedService.Services;
using Microsoft.AspNetCore.Mvc;

namespace KeyedService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotificationController : ControllerBase
    {
        //private readonly INotificationService _notificationService;
        //public NotificationController(INotificationService notificationService)
        //{
        //    _notificationService = notificationService;
        //}

        //[HttpGet(Name = "sendNotification")]
        //public string SendNotification()
        //{
        //    //get last registered instance from container
        //    var message = _notificationService.Notify("Hello");
        //    return message;
        //}

        //private readonly IEnumerable<INotificationService> _services;
        //public NotificationController(IEnumerable<INotificationService> services)
        //{
        //    _services = services;
        //}

        //[HttpGet(Name = "sendNotification")]
        //public string SendNotification(string notificationWay)
        //{
        //    string message = string.Empty;
        //    switch (notificationWay)
        //    {
        //        case "sms":
        //            message = _services.First().Notify("Hello from Sms Notification");
        //            break;
        //        case "email":
        //            message = _services.Last().Notify("Hello from Email Notification");
        //            break;
        //        default:
        //            message = _services.First().Notify("Hello from Sms Notification");
        //            break;
        //    }
        //    return message;
        //}

        private readonly INotificationService _smsNotificationService;
        private readonly INotificationService _emailNotificationService;
        public NotificationController([FromKeyedServices("sms")] INotificationService smsService,
            [FromKeyedServices("email")] INotificationService emailService)
        {
            _smsNotificationService = smsService;
            _emailNotificationService = emailService;
        }
        [HttpGet(Name = "sendNotification")]
        public string SendNotification()
        {
            //var message = _smsNotificationService.Notify("Hello");
            var message = _emailNotificationService.Notify("Hello");
            return message;
        }
    }
}
