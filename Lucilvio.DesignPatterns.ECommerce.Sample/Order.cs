using System;
using System.Collections.Generic;

namespace Lucilvio.DesignPatterns.ECommerce.Problematic
{
    public class Order
    {
        private OrderStatus _status;
        private Tracking _tracking;
        private readonly double _total;
        private readonly DateTime _date;
        private readonly IEnumerable<Product> _products;

        public Order(Cart cart)
        {
            Number = Guid.NewGuid();
            this._products = cart.Products;
            this._total = cart.Total();
            this._date = DateTime.Now;
        }

        internal void Cancel()
        {
            if (this._status == OrderStatus.Paied || this._status == OrderStatus.WaitingPaymentApproval)
                this._status = OrderStatus.Canceled;
        }

        internal void Deliver()
        {
            if (this._status != OrderStatus.Paied)
                return;

            this._tracking = new Tracking(new List<string> { $"{DateTime.Now} - Shipped" });
        }

        internal Tracking Traking()
        {
            if (this._status != OrderStatus.Shipped)
                return null; // aplicar null object pattern

            return this._tracking;
        }

        internal void Refund()
        {
            if (this._status != OrderStatus.Delivered)
                return;

            this._status = OrderStatus.WaitingRefundApproval;
        }

        public Guid Number { get; }
    }

    // aplicar state pattern
    internal enum OrderStatus
    {
        Shipped,
        Delivered,
        WaitingPaymentApproval,
        Paied,
        Canceled,
        WaitingRefundApproval
    }
}