using Bussiness.Models;

namespace Bussiness.Strategies.Invoices
{
    public abstract class InvoicesStrategy : IInvoicesStrategy
    {
        public abstract void Generate(Order order);

        public string GenetareTextInvoice(Order order)
        {
            var invoice = $"INVOICE DATE: {DateTimeOffset.Now}{Environment.NewLine}";
            invoice += $"ID|NAME|PRICE|QUANTITY{Environment.NewLine}";
            foreach(var item in order.ListItems){
                invoice += $"{item.ID}|{item.Name}|{item.Price}|1";
            }
            invoice += Environment.NewLine + Environment.NewLine;
            var tax = order.GetTax();
            var total = order.TotalPrice + tax;
            invoice += $"TAX TOTAL: {tax}{Environment.NewLine}";
            invoice += $"TOTAL: {total}{Environment.NewLine}";
            return invoice;
        }
    }
}