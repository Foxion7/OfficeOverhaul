﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KantoorApplicatie.Controllers;

namespace KantoorApplicatie.Views.InvoiceManager
{
    public partial class InvoiceManagerList : UserControl
    {
        public InvoiceManagerList()
        {
            InvoiceManagerController imc = new InvoiceManagerController();
            imc.FillInvoiceList(this);
            InitializeComponent();
        }

        // Add invoice to InvoiceManagerList.
        public void AddInvoice(InvoiceManagerItem imi)
        {
            Controls.Add(imi);
        }
    }
}
