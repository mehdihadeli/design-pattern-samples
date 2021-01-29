using Microsoft.AspNetCore.Mvc;
using StrategyPatternSample.API.Models;
using StrategyPatternSample.API.Services;
using System.Collections.Generic;
using System.Linq;

namespace StrategyPatternSample.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConfirmationController : ControllerBase
    {

        private readonly Dictionary<Channel, IConfirmationService> iConfirmationServices;


        public ConfirmationController(IEnumerable<IConfirmationService> iConfirmationServices)
        {
            this.iConfirmationServices = iConfirmationServices.ToDictionary(service => service.Channel);
        }

        [HttpGet("{type}/{identifiant}")]
        public NoContentResult Get(Channel type, string identifiant)
        {
            iConfirmationServices[type].SendNotification(identifiant);

            return NoContent();
        }
    }
}
