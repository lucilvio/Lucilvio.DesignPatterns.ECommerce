using System.Linq;
using System.Collections.Generic;
using System;

namespace Lucilvio.DesignPatterns.ECommerce.Problematic
{
    public class User
    {
        protected readonly Cart _cart;
        protected readonly IList<Order> _orders;

        private User()
        {
            this._cart = new Cart();
            this._orders = new List<Order>();
        }

        public User(string name) : this()
        {
            this.Name = name;

        }

        public string Name { get; }

        internal void CancelOrder(Guid number)
        {
            this._orders.FirstOrDefault(o => o.Number == number).Cancel();
        }

        internal void AskForRefund(Guid number)
        {
            this._orders.FirstOrDefault(o => o.Number == number).Refund();
        }

        internal Tracking TrackOrder(Guid number)
        {
            return this._orders.FirstOrDefault(o => o.Number == number).Traking();
        }

        public void AddToCart(Stock stock, Product product, int quantity)
        {
            var item = stock.GetItem(product, quantity);
            this._cart.Add(item._internal_product, item._qtd);
        }

        public Guid Pay(PaymentType paymentType)
        {
            var total = this._cart.Total();


            // aplicar strategy pattern
            if(paymentType == PaymentType.CreditCard)
            {
                // a lot of specific credit card logic 
                System.Console.WriteLine($"Paied {total} euros with card");
            }
            else if (paymentType == PaymentType.Billet)
            {
                // a lot of specific billet process
                System.Console.WriteLine($"Paied {total} euros with billet");
            }
            else if (paymentType == PaymentType.MbWay)
            {
                // a lot of specific MB Way process
                System.Console.WriteLine($"Paied {total} euros with MB Way");
            }
            else if (paymentType == PaymentType.PayPal)
            {
                // a lot of specific PayPal process
                System.Console.WriteLine($"Paied {total} euros with PayPal");
            }

            var newOrder = new Order(this._cart);
            this._orders.Add(newOrder);

            this.DisposeCart();

            return newOrder.Number;
        }

        private void DisposeCart()
        {
            this._cart.Dispose();
        }
    }
}