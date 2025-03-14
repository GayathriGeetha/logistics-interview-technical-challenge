using Microsoft.AspNetCore.Mvc;

namespace SainsburysPriceCalculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PricingController : ControllerBase
    {
        [HttpPost]
        public ActionResult CalculatePrice([FromBody] PricingRequest pricingRequest)
        {
            throw new NotImplementedException();
        }
    }
}
