using Bussiness.Models;

namespace Bussiness.Strategies.Invoices
{
    public class EmailInvoiceStrategy : InvoicesStrategy
    {
        public override void Generate(Order order)
        {
            var body = GenetareTextInvoice(order);
        }
    }
}