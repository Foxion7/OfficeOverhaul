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
using KantoorApplicatie.Properties;

namespace KantoorApplicatie.Views {
    public partial class CatalogListPanel : UserControl
    {
        public CatalogListPanel()
        {
            InitializeComponent();
        }

        // Adds a product to the display.
        public void AddProduct(CatalogProductPanel pp)
        {
            Controls.Add(pp);
        }

        // Removes a product from the display.
        public void RemoveProduct(CatalogProductPanel pp)
        {
            Controls.Remove(pp);
        }
    }
}
