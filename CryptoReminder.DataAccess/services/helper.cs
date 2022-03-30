using System.Net.Http;
using System.Net.Http.Headers;

namespace CryptoReminder.DataAccess
{
    //API : assets?fields=id,slug,symbol,metrics/market_data/price_usd
    //BTC API : assets/bitcoin/metrics
    //ETH API : assets/ethereum/profile

    internal class helper
    {
        private static HttpClient _httpClient = new HttpClient();
        private static HttpClient InitializeClient()
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return _httpClient;
        }

        public static HttpClient GetApiClient()
        {
            _httpClient.BaseAddress = new Uri("https://data.messari.io/api/v1/");
            return InitializeClient();
        }

    }
}
