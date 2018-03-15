﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KantoorApplicatie.Models.Invoice 
{
    public class InvoiceData 
    {
        public int InvoiceDataId {get; set; }
        public DateTime invoiceDate { get; set; }
        public virtual Room room { get; set; }
        public virtual Customer customer { get; set; }
        public virtual Representative representative { get; set; }
        public virtual ICollection<OrderedProduct> orderedProducts { get; set; }

        public InvoiceData(Customer customer, Representative representative, DateTime invoiceDate, Room room) 
        {
            orderedProducts = new List<OrderedProduct>();
            this.room = room;
            this.customer = customer;
            this.representative = representative;
            this.invoiceDate = invoiceDate;
        }

        public InvoiceData() 
        {
        }
    }
}
