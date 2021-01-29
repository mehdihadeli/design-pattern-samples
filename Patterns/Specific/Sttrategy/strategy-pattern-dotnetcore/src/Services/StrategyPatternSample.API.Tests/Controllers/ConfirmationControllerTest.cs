using Moq;
using StrategyPatternSample.API.Controllers;
using StrategyPatternSample.API.Services;
using System.Collections.Generic;
using Xunit;

namespace StrategyPatternSample.API.Tests.Controllers
{
    public class ConfirmationControllerTest
    {
        private readonly ConfirmationController controller;
        private readonly Mock<AbstractConfirmationSMSService> confirmationSMSService;
        private readonly Mock<AbstractConfirmationEmailService> confirmationEmailService;

        public ConfirmationControllerTest()
        {
            confirmationSMSService = new Mock<AbstractConfirmationSMSService>();
            confirmationEmailService = new Mock<AbstractConfirmationEmailService>();
            List<IConfirmationService> services = new List<IConfirmationService>
            {
                confirmationSMSService.Object,
                confirmationEmailService.Object
            };
            controller = new ConfirmationController(services);
        }


        [Fact]
        public void Confirmation_should_call_SMS_channel_corresponding_implementation()
        {
            // arrange
            string phoneNumber = "0612121212";
            // act
            controller.Get(Models.Channel.SMS, phoneNumber);

            // assert
            confirmationSMSService.Verify(mock => mock.SendNotification(It.Is<string>(id => id.Equals(phoneNumber))), Times.Once);
            confirmationEmailService.Verify(mock => mock.SendNotification(It.IsAny<string>()), Times.Never);
        }

        [Fact]
        public void Confirmation_should_call_EMAIL_channel_corresponding_implementation()
        {
            // arrange
            string email = "john.doe@cwep.br";
            // act
            controller.Get(Models.Channel.EMAIL, email);

            // assert
            confirmationEmailService.Verify(mock => mock.SendNotification(It.Is<string>(id => id.Equals(email))), Times.Once);
            confirmationSMSService.Verify(mock => mock.SendNotification(It.IsAny<string>()), Times.Never);
        }
    }
}
