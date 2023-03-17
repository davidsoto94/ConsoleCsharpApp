using Bussiness.Models;

namespace Bussiness.Strategies.Invoices
{
    public interface IInvoicesStrategy
    {
        public void Generate(Order order);
    }
}