// Program.cs
using DependencyInjectionDotnet;
using DependencyInjectionDotnet.IServices;
using DependencyInjectionDotnet.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Program
{
    public static void Main(string[] args)
    {
        var host = CreateHostBuilder(args).Build();

        var notificationService = host.Services.GetRequiredService<NotificationService>();
        notificationService.Notify("example@example.com", "Test Subject", "Test Body");
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureServices((context, services) =>
            {
                services.AddTransient<ILoggerService, LoggerService>();
                services.AddTransient<IEmailService, EmailService>();
                services.AddTransient<NotificationService>();
            });
}