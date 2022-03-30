using CryptoReminder.DataAccess.models.Currencies;
using CryptoReminder.DataAccess.models.data;


namespace CryptoReminder.DataAccess.services.GetServices
{
    public class GetServices : IGetServices
    {
        public async Task<List<Currency>> GetCurrencies()
        {
            HttpClient client = helper.GetApiClient();

                using (HttpResponseMessage response = await client.GetAsync("assets?fields=id,slug,symbol,metrics/market_data/price_usd"))
                {
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception(response.ReasonPhrase);
                    }

                    APIdata data = await response.Content.ReadAsAsync<APIdata>();
                    return data.data;
                }
        }
    }
}
