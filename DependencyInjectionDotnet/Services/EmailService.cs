using DependencyInjectionDotnet.IServices;


namespace DependencyInjectionDotnet.Services
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string to, string subject, string body)
        {
            // Simulate sending an email
            Console.WriteLine($"Sending email to {to}, subject: {subject}, body: {body}");
        }
    }
}
