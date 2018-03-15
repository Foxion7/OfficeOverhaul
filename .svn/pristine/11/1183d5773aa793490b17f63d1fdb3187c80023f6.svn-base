using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KantoorApplicatie.Models.Invoice 
{
    public class OrderedProduct 
    {
        public int OrderedProductId { get; set; }
        public virtual Product product { get; set; }
        public virtual InvoiceData invoiceData { get; set; }
        public int amount { get; set; }

        public OrderedProduct(InvoiceData invoiceData, Product product, int amount) 
        {
            this.product = product;
            this.invoiceData = invoiceData;
            this.amount = amount;
        }

        public OrderedProduct() 
        {
        }
    }
}
