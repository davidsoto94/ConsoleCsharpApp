using Bussiness.Models;

namespace Bussiness.Strategies.SalesTax
{
    public class USASalesTazStrategy : ISalesTaxStrategy
    {
        public decimal GetTaxFor (Order order)
        {
            switch (order.shippingDetails.DestinationState.ToLowerInvariant())
            {
                case "la":return order.TotalPrice * 0.095m;
                case "ny":return order.TotalPrice * 0.04m;
                case "nyc":return order.TotalPrice * 0.045m;
                default:return 0m;
            }
        }
    }
}