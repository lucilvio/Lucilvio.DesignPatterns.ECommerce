namespace Lucilvio.DesignPatterns.ECommerce.VendorApi.Controllers
{
    public class Item
    {
        public Item(Product _internal_product, int _qtd)
        {
            this._qtd = _qtd;
            this._internal_product = _internal_product;
        }

        public int _qtd { get; }
        public Product _internal_product { get; }
    }
}