using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KantoorApplicatie.Models.Invoice;
using KantoorApplicatie.Controllers;
using KantoorApplicatie.Views.Invoice;
using KantoorApplicatie.Models;
using KantoorApplicatie.Db;

namespace KantoorApplicatie.Views.InvoiceManager
{
    public partial class InvoiceManagerItem : UserControl
    {
        private InvoiceData invoiceData;
        private InvoiceController ic;
        private InvoiceManagerController imc;

        public InvoiceManagerItem(InvoiceData id)
        {
            InitializeComponent();

            invoiceData = id;
            ic = new InvoiceController(id.orderedProducts);
            imc = new InvoiceManagerController();
            
            // Setting invoice information.
            CustomerCompanyLabel.Text = id.customer.companyName;
            CustomerNameLabel.Text = id.customer.name;
            DateLabel.Text = id.invoiceDate.Date.ToString("d");
            switch (id.InvoiceDataId.ToString().Length)
            {
                case 1:
                    InvoiceNumberLabel.Text = "000" + id.InvoiceDataId.ToString();
                    break;
                case 2:
                    InvoiceNumberLabel.Text = "00" + id.InvoiceDataId.ToString();
                    break;
                case 3:
                    InvoiceNumberLabel.Text = "0" + id.InvoiceDataId.ToString();
                    break;
                case 4:
                    InvoiceNumberLabel.Text = id.InvoiceDataId.ToString();
                    break;
            }
        }

        // Savebutton clicked.
        private void SaveButton_Click(object sender, EventArgs e)
        {
            imc.GeneratePDF(invoiceData, ic);
        }
    }
}
