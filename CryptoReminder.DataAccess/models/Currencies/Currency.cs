
namespace CryptoReminder.DataAccess.models.Currencies
{
    public class Currency : ICurrency
    {
        public string name { get; set; }
        public string slug { get; set; }
        public string symbol { get; set; }
        public Metrics metrics { get; set; }
        public Market market_data { get; set; }
    }
    public class Metrics
    {
        public Market market_data { get; set; }
    }

    public class Market
    {
        public decimal price_usd { get; set; }
        public decimal price_btc { get; set; }
        public decimal price_eth { get; set; }
        public decimal percent_change_usd_last_1_hour { get; set; }
        public decimal percent_change_btc_last_1_hour { get; set; }
        public decimal percent_change_eth_last_1_hour { get; set; }
        public decimal percent_change_usd_last_24_hours { get; set; }
        public decimal percent_change_btc_last_24_hours { get; set; }
        public decimal percent_change_eth_last_24_hours { get; set; }

    }
}
