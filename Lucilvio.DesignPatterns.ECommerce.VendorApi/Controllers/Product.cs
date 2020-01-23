namespace Lucilvio.DesignPatterns.ECommerce.VendorApi.Controllers
{
    public class Product
    {
        public Product(string _internal_name_identifier, double _original_value)
        {
            this._internal_name_identifier = _internal_name_identifier;
            this._original_value = _original_value;
        }

        public string _internal_name_identifier { get; }
        public double _original_value { get; }
    }
}