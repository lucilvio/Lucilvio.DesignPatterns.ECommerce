using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using System;

namespace Lucilvio.DesignPatterns.ECommerce.Problematic
{
    public partial class Stock
    {
        [JsonProperty("items")]
        private List<StockItem> items { get; set; }

        public Product FindProductByName(string name)
        {
            var item = this.items.FirstOrDefault(i => i._internal_product._internal_name_identifier == name);
            return item._internal_product;
        }

        internal StockItem GetItem(Product product, int quantity)
        {
            var item = this.items.FirstOrDefault(i => i._internal_product._internal_name_identifier == product._internal_name_identifier);
            item.Subtract(quantity);

            return new StockItem(product, quantity);
        }
    }
}