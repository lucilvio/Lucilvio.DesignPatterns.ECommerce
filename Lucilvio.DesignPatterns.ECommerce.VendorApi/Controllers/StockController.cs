using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Lucilvio.DesignPatterns.ECommerce.VendorApi.Controllers
{
    [ApiController]
    [Route("api/vendor-xpto/stock")]
    public class StockController : ControllerBase
    {
        [HttpGet]
        public Stock Get()
        {
            return new Stock(new List<Item>
            {
                new Item(new Product("bike", 340.22), 10),
                new Item(new Product("book", 20.50), 10),
                new Item(new Product("chair", 15.0), 14),
                new Item(new Product("socks", 2.0), 10),
                new Item(new Product("tennis", 30.0), 89),
                new Item(new Product("sunglasses", 90.0), 3),
                new Item(new Product("coat", 100.0), 100),
            });
        }
    }
}
