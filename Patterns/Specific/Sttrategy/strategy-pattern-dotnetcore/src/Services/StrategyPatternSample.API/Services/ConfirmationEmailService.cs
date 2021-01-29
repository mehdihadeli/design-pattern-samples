using StrategyPatternSample.API.Models;
using System;
using System.Threading.Tasks;

namespace StrategyPatternSample.API.Services
{
    public abstract class AbstractConfirmationEmailService : IConfirmationService
    {
        public Channel Channel => Models.Channel.EMAIL;

        public abstract Task SendNotification(string identifiant);
    }
    public class ConfirmationEmailService : AbstractConfirmationEmailService
    {
        public Channel Channel => Channel.EMAIL;

        /// <summary>
        /// Envoi d'une notification par Email
        /// </summary>
        /// <param name="identifiant">Email à notifier</param>
        /// <returns></returns>
        public override Task SendNotification(string identifiant)
        {
            throw new NotImplementedException();
        }
    }
}
