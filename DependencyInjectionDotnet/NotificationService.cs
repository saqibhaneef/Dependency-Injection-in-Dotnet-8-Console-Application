using DependencyInjectionDotnet.IServices;


namespace DependencyInjectionDotnet
{
    public class NotificationService
    {
        private readonly ILoggerService _loggerService;
        private readonly IEmailService _emailService;


        public NotificationService(ILoggerService loggerService, IEmailService emailService)
        {
            _loggerService = loggerService;
            _emailService = emailService;
        }

        public void Notify(string to, string subject, string body)
        {
            _emailService.SendEmail(to, subject, body);
            _loggerService.Log("Email sent successfully.");
        }
    }
}
