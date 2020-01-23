using System.Collections.Generic;

namespace Lucilvio.DesignPatterns.ECommerce.VendorApi.Controllers
{
    public class Stock
    {
        public Stock(IEnumerable<Item> items)
        {
            this.Items = items;
        }

        public IEnumerable<Item> Items { get; }
    }
}
