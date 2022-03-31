using CryptoReminder.DataAccess.models.Currencies;

namespace CryptoReminder.DataAccess.models.data
{
    internal class APIdata
    {
        public List<Currency> data { get; set; }
    }

    internal class APISingleData
    {
        public Currency data { get; set; }
    }
}
