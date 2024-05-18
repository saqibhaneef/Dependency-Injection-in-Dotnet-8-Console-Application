using DependencyInjectionDotnet.IServices;

namespace DependencyInjectionDotnet.Services
{
    public class LoggerService : ILoggerService
    {

        public void Log(string message)
        {
            Console.WriteLine($"Log entry: {message}");
        }
    }
}
