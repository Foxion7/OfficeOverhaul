using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KantoorApplicatie.Views.InvoiceManager;
using KantoorApplicatie.Db;
using KantoorApplicatie.Models.Invoice;
using System.Drawing;
using KantoorApplicatie.Models;

namespace KantoorApplicatie.Controllers
{
    class InvoiceManagerController
    {
        // Retrieving invoices from database and making items to put in InvoiceManagerList.
        public void FillInvoiceList(InvoiceManagerList iml)
        {
            int y = 0;
            
            foreach (InvoiceData id in DatabaseController.invoiceList)
            {
                InvoiceManagerItem item = new InvoiceManagerItem(id);
                item.Location = new Point(0, y);
                y += 105;
                iml.AddInvoice(item);
            }
        }

        // Generate and save PDF to pc.
        public void GeneratePDF(InvoiceData invoiceData, InvoiceController ic)
        {
            // Retrieving the corresponding customer and representative from database.
            Customer cus = DatabaseController.invoiceList.Find(i => i.InvoiceDataId == invoiceData.InvoiceDataId).customer;
            Representative rep = DatabaseController.invoiceList.Find(i => i.InvoiceDataId == invoiceData.InvoiceDataId).representative;
            Room room = DatabaseController.invoiceList.Find(i => i.InvoiceDataId == invoiceData.InvoiceDataId).room;

            // Set info for PDF and generate PDF.
            ic.SetInfo(cus, rep, invoiceData.InvoiceDataId.ToString(), room);
            ic.MakeProductListFromOrderedProducts(invoiceData.orderedProducts);
            ic.MakePdf();
        }
    }
}
