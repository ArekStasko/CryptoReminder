
namespace CryptoReminder.DataAccess.models.Currencies
{
    public class Currency : ICurrency
    {
        public string slug { get; set; }
        public string symbol { get; set; }
        public Metrics metrics { get; set; }
        
    }
    public class Metrics
    {
        public Market market_data { get; set; }
    }

    public class Market
    {
        public decimal price_usd { get; set; }
    }
}
