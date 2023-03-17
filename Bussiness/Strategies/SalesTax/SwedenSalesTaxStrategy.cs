using Bussiness.Models;

namespace Bussiness.Strategies.SalesTax
{
    public class SwedenSalesTazStrategy : ISalesTaxStrategy
    {
        public decimal GetTaxFor (Order order)
        {
            decimal totalTax = 0m;
            foreach(var item in order.ListItems)
            {
                switch(item.ItemType)
                {
                    case ItemType.Food:
                        totalTax += (item.Price * 0.06m);
                        break;
                    case ItemType.Literature:
                        totalTax += (item.Price * 0.08m);
                        break;
                    
                }
            }
            return totalTax;
        }
    }
}