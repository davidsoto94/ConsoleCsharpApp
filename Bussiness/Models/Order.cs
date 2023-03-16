

namespace Bussiness.Models.Order
{
    public class Order
    {
         public ShippingDetails shippingDetails { get; set;}
         public List<Item> ListItems { get; set; }
         public decimal TotalPrice => ListItems.Sum(item => item.Price);

        public decimal GetTax()
         {
            var destination = shippingDetails.DestinationCountry.ToLowerInvariant();
            if(destination=="sweden"){
                var origin = shippingDetails.OriginCountry.ToLowerInvariant();
                if(destination==origin)
                {
                    return TotalPrice * 0.15m;
                }
                return 0;
            }
            if(destination=="us")
            {
                switch (shippingDetails.DestinationState.ToLowerInvariant())
                {
                    case "la":return TotalPrice * 0.095m;
                    case "ny":return TotalPrice * 0.04m;
                    case "nyc":return TotalPrice * 0.045m;
                    default:return 0m;
                }
            }
            return 0m;
        }
    }

    public class ShippingDetails
    {
        public string OriginCountry { get; set;}
        public string DestinationCountry { get; set; }
        public string DestinationState { get; set; }
    }

    public class Item
    {
        public string ID{ get; set; }
        public string Name{ get; set; }
        public decimal Price { get; set; }

    }

    public static class ItemType
    {

    }
    
}