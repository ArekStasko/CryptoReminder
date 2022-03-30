using CryptoReminder.DataAccess.models.Currencies;

namespace CryptoReminder.DataAccess.services.GetServices
{
    public interface IGetServices
    {
        public Task<List<Currency>> GetCurrencies();
    }
}
