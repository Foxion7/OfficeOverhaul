﻿using KantoorApplicatie.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KantoorApplicatie.Views 
{
    public partial class RemoveProductForm : Form 
    {
        private CatalogProductPanel cpp;

        public RemoveProductForm(CatalogProductPanel cpp) 
        {
            InitializeComponent();
            this.cpp = cpp;
            // Sets product values to see what you delete. 
            nameResultLabel.Text = cpp.product.name;
            widthResultLabel.Text = cpp.product.width.ToString();
            heightResultLabel.Text = cpp.product.height.ToString();
            priceResultLabel.Text = cpp.product.price.ToString();
            pictureBox1.Image = cpp.product.GetImage();
        }

        private void textLabel_Click(object sender, EventArgs e) 
        {

        }

        // Exits form.
        private void cancelButton_Click(object sender, EventArgs e) 
        {
            Close();
        }

        // Deletes product from everywhere except the database, updates catalog and closes form.
        private void deleteButton_Click(object sender, EventArgs e) 
        {
            cpp.product.active = false;
            cpp.RemoveProductFromDesign();
            DatabaseController.SetProductActiveProperty(cpp.product, false);
            cpp.cc.RefreshDisplayedItems();
            Close();
        }
    }
}
