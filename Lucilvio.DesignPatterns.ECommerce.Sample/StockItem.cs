using System;
using Newtonsoft.Json;

namespace Lucilvio.DesignPatterns.ECommerce.Problematic
{
    public class StockItem
    {
        public StockItem()
        {

        }

        public StockItem(Product internal_product, int qtd)
        {
            _qtd = qtd;
            _internal_product = internal_product;
        }

        public int _qtd { get; set; }
        public Product _internal_product { get; set; }

        internal void Subtract(int quantity)
        {
            this._qtd =- quantity;
        }
    }
}