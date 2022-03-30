using CryptoReminder.DataAccess.services.GetServices;
using CryptoReminder.DataAccess.models.Currencies;

namespace CryptoReminder.DataAccess
{
    public static class DataAccessFactory
    {
        public static IGetServices GetServicesInstance() => new GetServices();
        public static ICurrency GetCurrencyInstance() => new Currency();
    }
}