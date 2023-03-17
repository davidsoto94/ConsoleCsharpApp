using Bussiness.Models;
using Bussiness.Strategies.SalesTax;

namespace Program
{ 
    class Program
    {
        public static void Main()
        {
            var order = new Order
            {
                shippingDetails = new ShippingDetails
                {
                    OriginCountry="Sweden",
                    DestinationCountry="Sweden"
                }
            };
            var destination = order.shippingDetails.DestinationCountry.ToLowerInvariant();
            if(destination=="sweden")
            {
                order.salesTaxStrategy = new SwedenSalesTazStrategy();
            }
            else if(destination=="us")
            {
                order.salesTaxStrategy = new USASalesTazStrategy();
            }
            order.ListItems.Add(new Item("TestID", "testName", 100,ItemType.Literature));
            Console.WriteLine(order.GetTax());

        }
    }
}
