using System.Net.Http.Json;

namespace BlackHawk.Services
{
    public class PriceChartingService(HttpClient? http)
    {
        private readonly HttpClient? _http = http;

        public async Task<decimal?> GetAveragePriceAsync(string comicId)
        {
            // actually do something here
            return 123.45M;
        }
    }
}
