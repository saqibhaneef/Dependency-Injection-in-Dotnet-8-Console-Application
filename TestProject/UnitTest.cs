using DependencyInjectionDotnet;
using DependencyInjectionDotnet.IServices;
using Moq;

namespace TestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestEmailSuccess()
        {
            var mockEmailService = new Mock<IEmailService>();
            var mockLoggerService = new Mock<ILoggerService>();
            var notificationService = new NotificationService(mockLoggerService.Object, mockEmailService.Object);

            notificationService.Notify("test@example.com", "Test Subject", "Email body");

            mockEmailService.Verify(es => es.SendEmail(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }
    }
}