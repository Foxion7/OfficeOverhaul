using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KantoorApplicatie.Models;

namespace KantoorApplicatie.Views {
    public partial class InvoiceProductPanel : UserControl 
    {
        public Product product { get; set; }
        public int amountOfCopies { get; set; }

        public InvoiceProductPanel(Product product) 
        {
            this.product = product;
            InitializeComponent();
            nameLabel.Text = product.name;
            typeLabel.Text = product.GetType().ToString();
            singlePriceLabel.Text = product.price.ToString();
        }

        public void SetRemainingValues(int amountOfCopies, Point newLocation) 
        {
            this.amountOfCopies = amountOfCopies;
            numberLabel.Text = "x" + amountOfCopies.ToString();
            totalPriceLabel.Text = (amountOfCopies * product.price).ToString();
            Location = newLocation;
        }
    }
}
