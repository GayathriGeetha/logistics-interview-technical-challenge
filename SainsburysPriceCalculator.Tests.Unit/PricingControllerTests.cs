using Microsoft.AspNetCore.Mvc;
using SainsburysPriceCalculator.Controllers;

namespace SainsburysPriceCalculator.Tests.Unit
{
    public class PricingControllerTests
    {
        [Fact]
        public void CalculatePrice_GivenAJourneyWithDiscount_ReturnsExpectedPrice()
        {
            var controller = new PricingController();
            
            var response = controller.CalculatePrice(new PricingRequest
            {
                JourneyCode = "A1",
                Discount = 15,
                Distance = 120
            });

            var price = response as OkObjectResult;
            Assert.Equal(165, price.Value);
        }

        [Fact]
        public void CalculatePrice_GivenBJourneyWithNoDiscount_ReturnsExpectedPrice()
        {
            var controller = new PricingController();

            var response = controller.CalculatePrice(new PricingRequest
            {
                JourneyCode = "B1",
                Discount = 0,
                Distance = 19
            });

            var price = response as OkObjectResult;
            Assert.Equal(33, price.Value);
        }

        [Fact]
        public void CalculatePrice_GivenAJourneyWithLargeDiscount_ReturnsBadRequest()
        {
            var controller = new PricingController();

            var response = controller.CalculatePrice(new PricingRequest
            {
                JourneyCode = "A1",
                Discount = 1200,
                Distance = 18
            });

            Assert.IsType<BadRequestResult>(response);
        }
    }
}