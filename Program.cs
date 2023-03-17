using Bussiness.Models.Order;

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
            order.ListItems.Add(new Item("TestID", "testName", 100));
            Console.WriteLine(order.GetTax());

        }
    }
}
