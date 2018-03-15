﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KantoorApplicatie.Models;
using KantoorApplicatie.Controllers;

namespace KantoorApplicatie.Views {
    public partial class CatalogProductPanel : UserControl 
    {
        public Product product { get; set; }
        public CatalogController cc { get; set; }

        private DragController dc;

        public CatalogProductPanel(Product product, DesignPanel dp, CatalogController cc) 
        {
            InitializeComponent();
            this.product = product;
            this.cc = cc;
            dc = new DragController(product, dp);
            // Sets productvalues.
            nameLabel.Text = product.name;
            priceLabel.Text = "Prijs: €" + product.price.ToString();
            descriptionLabel.Text = product.description;
            widthLabel.Text = product.width.ToString() + " cm";
            heightLabel.Text = product.height.ToString() + " cm";
            pictureBox1.Image = product.GetImage();
        }
        
        // This starts the dragging of a picture from the catalog to DesignPanel.
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            crossPicturebox.Visible = false;
            if (e.Button == MouseButtons.Left)
            {
                dc.StartDrag(sender, e);
            }
        }
        // This starts the placing of a picture held after dragging it from catalog.
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            dc.PlaceProduct();
        }

        // Hides crossbox.
        private void CatalogProductPanel_MouseLeave(object sender, EventArgs e) 
        {

            if (GetChildAtPoint(PointToClient(MousePosition)) == null) 
            {
                crossPicturebox.Visible = false;
            }
        }

        private void crossPicturebox_Click(object sender, EventArgs e) 
        {
            RemoveProductForm rpf = new RemoveProductForm(this);
            rpf.ShowDialog();
        }

        public void RemoveProductFromDesign() 
        {
            dc.RemoveProduct(product);
        }

        // Shows crossbox to allow product removal.
        private void CatalogProductPanel_MouseEnter(object sender, EventArgs e) {
            crossPicturebox.Visible = true;
        }

        private void nameLabel_Click(object sender, EventArgs e) {

        }
    }
}
