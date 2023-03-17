using Bussiness.Strategies.SalesTax;

namespace Bussiness.Models
{
    public class Order
    {
        public ShippingDetails shippingDetails { get; set; } = new ShippingDetails();
        public List<Item> ListItems { get; set; } = new List<Item>();
        public decimal TotalPrice => ListItems.Sum(item => item.Price);
        public ISalesTaxStrategy? salesTaxStrategy { get; set; }

        public decimal GetTax()
        {
            if(salesTaxStrategy == null)
            {
                return 0m;
            }
            return salesTaxStrategy.GetTaxFor(this);
        }
    }

    public class ShippingDetails
    {
        public ShippingDetails(){
            OriginCountry = "";
            DestinationCountry = "";
            DestinationState = "";
        }

        public string OriginCountry { get; set;}
        public string DestinationCountry { get; set; }
        public string DestinationState { get; set; }
    }

    public class Item
    {
        public Item(string ID,string Name,decimal Price,string ItemType){
            this.ID = ID;
            this.Name = Name;
            this.Price = Price;
            this.ItemType = ItemType;
        }
        public string ID{ get; set; }
        public string Name{ get; set; }
        public decimal Price { get; set; }
        public string ItemType{ get; set; }
    }

    public static class ItemType
    {
        public const string Literature = "Literature";
        public const string Food = "Food";
        public const string Other = "Other";
    }
    
}