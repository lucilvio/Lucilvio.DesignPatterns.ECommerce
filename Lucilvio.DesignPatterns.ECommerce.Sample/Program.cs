using System;

// patterns que faltam -------------------------
// abstract factory
// builder
// prototype
// bridge
// composite - ideia de categorias e subcategorias
// façade - ideia da API
// flyweight
// proxy
// chain of responsibility
// interpretor
// iterator
// memento
// template method
// visitor

namespace Lucilvio.DesignPatterns.ECommerce.Problematic
{
    public class Program
    {
        // Aplicar Mediator pattern, aplicar command pattern
        static void Main(string[] args)
        {
            var stockLoader = new StockLoader(new Logger());
            var stock = stockLoader.Load();

            var user = new User("John Doe");

            var product = stock.FindProductByName("book");
            user.AddToCart(stock, product, 1);

            // aplicar factory qunado aplicar o strategy pattern, usar o singleton para garantir apenas uma instancia da factory
            var orderNumber = user.Pay(PaymentType.CreditCard);
            
            user.CancelOrder(orderNumber);
            user.AskForRefund(orderNumber);

            // aplicar observer pattern
            // systemAdm.AppoveRefund();

            //order.Deliver();
            Console.WriteLine(user.TrackOrder(orderNumber));

            Console.WriteLine($"Order number: {orderNumber}");
            Console.ReadLine();
        }
    }
}