using CryptoReminder.DataAccess.models.Currencies;
using CryptoReminder.DataAccess.models.data;


namespace CryptoReminder.DataAccess.services.GetServices
{
    public class GetServices : IGetServices
    {

        private HttpClient client = helper.GetApiClient();
        public async Task<List<Currency>> GetCurrencies()
        {
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

        public async Task<Currency> GetBTCData()
        {
            using (HttpResponseMessage response = await client.GetAsync("assets/bitcoin/metrics"))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(response.ReasonPhrase);
                }

                APISingleData data = await response.Content.ReadAsAsync<APISingleData>();
                return data.data;
            }
        }

        public async Task<Currency> GetETHData()
        {
            using (HttpResponseMessage response = await client.GetAsync("assets/ethereum/metrics"))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(response.ReasonPhrase);
                }

                APISingleData data = await response.Content.ReadAsAsync<APISingleData>();
                return data.data;
            }
        }
    }
}
