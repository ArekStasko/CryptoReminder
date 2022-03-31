
namespace CryptoReminder.DataAccess.models.Currencies
{
    public interface ICurrency
    {
        public string name { get; set; }
        public string slug { get; set; }
        public string symbol { get; set; }
        public Metrics metrics { get; set; }
        public Market market_data { get; set; }
    }
}
