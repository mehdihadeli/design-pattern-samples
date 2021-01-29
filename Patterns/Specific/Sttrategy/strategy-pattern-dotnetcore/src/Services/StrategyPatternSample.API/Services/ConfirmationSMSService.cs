using StrategyPatternSample.API.Models;
using System;
using System.Threading.Tasks;

namespace StrategyPatternSample.API.Services
{

    public abstract class AbstractConfirmationSMSService : IConfirmationService
    {
        public Channel Channel => Models.Channel.SMS;

        public abstract Task SendNotification(string identifiant);
    }

    public class ConfirmationSMSService : AbstractConfirmationSMSService
    {

        /// <summary>
        /// Envoi d'une notification par sms
        /// </summary>
        /// <param name="identifiant">Numéro de téléphone à notifier</param>
        /// <returns></returns>
        public override Task SendNotification(string identifiant)
        {
            throw new NotImplementedException();
        }
    }
}
