namespace SainsburysPriceCalculator
{
    public class PricingRequest
    {
        public required string JourneyCode { get; set; }
        public int Distance { get; set; }
        public int Discount { get; set; }
    }
}
