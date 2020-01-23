using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace Lucilvio.DesignPatterns.ECommerce.Problematic
{
    public class StockLoader
    {
        private readonly Logger _logger;


        // aplicar decorator pattern para logger e caching
        public StockLoader(Logger logger)
        {
            this._logger = logger;
        }

        public Stock Load()
        {
            this._logger.Log("Loading products ....");

            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = httpClient.GetStringAsync("http://localhost:62866/api/vendor-xpto/stock").GetAwaiter().GetResult();
                    this._logger.Log("Products loaded with success!");

                    // aplicar adapter pattern
                    return JsonConvert.DeserializeObject<Stock>(response);
                }
            }
            catch (Exception ex)
            {
                this._logger.Log($"Error on load products!!!! \n {ex.Message}");
                throw;
            }

        }
    }
}