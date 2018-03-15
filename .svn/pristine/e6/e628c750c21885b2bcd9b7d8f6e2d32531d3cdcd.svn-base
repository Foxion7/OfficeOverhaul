using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KantoorApplicatie.Db;
using KantoorApplicatie.Controllers;

namespace KantoorApplicatie.Views.InvoiceManager
{
    public partial class InvoiceManagerForm : Form
    {
        public InvoiceManagerForm()
        {
            InitializeComponent();
            if (DatabaseController.getLastSubTheme() != null) {
                this.BackgroundImageLayout = ImageLayout.Stretch;
                this.BackgroundImage = Converter.ByteArrayToImage(DatabaseController.getLastSubTheme().image);
            }
        }

        // Close InvoiceManagerForm.
        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
