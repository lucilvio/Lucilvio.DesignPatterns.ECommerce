using System.Collections.Generic;
using System.Linq;

namespace Lucilvio.DesignPatterns.ECommerce.Problematic
{
    public class Cart
    {
        private IList<Product> _products;

        public Cart()
        {
            this._products = new List<Product>();
        }

        public IEnumerable<Product> Products => this._products;

        internal void Add(Product product, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                this._products.Add(product);
            }
        }

        internal void Dispose()
        {
            this._products.Clear();
        }

        internal double Total()
        {
            return this._products.Sum(p => p._original_value);
        }
    }
}