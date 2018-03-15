
using KantoorApplicatie.Controllers;
using KantoorApplicatie.Models;
using KantoorApplicatie.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KantoorApplicatie.Views {
    [Serializable]
    public partial class CatalogPanel : UserControl
    {
        public CatalogController catalogController { get; set; }

        public List<Product> productList;

        public CatalogPanel()
        {
            InitializeComponent();
            // Voorbeeldvulling
            productList = new List<Product> {
                new Chair("Hünke Tünke", "Een lederen stoel", 40, 80, 49.99, Resources.Bureaustoel),
                new Sofa("Hanke honke", "Een rooie bank", 300, 100, 75.99, Resources.OranjeSofa),
                new Chair("Hünke Tünke", "Een lederen stoel", 40, 80, 49.99, Resources.Bureaustoel),
                new Sofa("Hanke honke", "Een rooie bank", 300, 100, 75.99, Resources.OranjeSofa),
                new Chair("Hünke Tünke", "Een lederen stoel", 40, 80, 49.99, Resources.Bureaustoel),
                new Sofa("Hanke honke", "Een rooie bank", 300, 100, 75.99, Resources.OranjeSofa),
                new Chair("Hünke Tünke", "Een lederen stoel", 40, 80, 49.99, Resources.Bureaustoel),
                new Sofa("Hanke honke", "Een rooie bank", 300, 100, 75.99, Resources.OranjeSofa),
                new Chair("Hünke Tünke", "Een lederen stoel", 40, 80, 49.99, Resources.Bureaustoel),
                new Sofa("Hanke honke", "Een rooie bank", 300, 100, 75.99, Resources.OranjeSofa),
                new Chair("Hünke Tünke", "Een lederen stoel", 40, 80, 49.99, Resources.Bureaustoel),
                new Sofa("Hanke honke", "Een rooie bank", 300, 100, 75.99, Resources.OranjeSofa)
            };
            catalogController = new CatalogController(catalogListPanel1, productList);
            catalogController.RefreshDisplayedItems();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            catalogController.currentOrdering = comboBox1.SelectedItem.ToString();
            catalogController.RefreshDisplayedItems();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            catalogController.currentSorting = comboBox2.SelectedItem.ToString();
            catalogController.RefreshDisplayedItems();
        }


        private void searchBox1_Click(object sender, EventArgs e) {
            if (searchBox1.Text.Equals("Zoek op naam...")) {
                searchBox1.Text = "";
            }
        }

        private void searchBox1_TextChanged(object sender, EventArgs e) {
            if (!searchBox1.Text.Equals("Zoek op naam...") && !searchBox1.Text.Equals("")) {
                catalogController.currentSearch = searchBox1.Text;
                catalogController.RefreshDisplayedItems();
            }
        }


        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;

        //    Product p = new Bureaustoel();
        //    Product p2 = new Sofa();
        //    Product p3 = new PingPongTafel();

        //    g.DrawImage(p.GetImage(), new Point(10, 10));
        //    g.DrawImage(p2.GetImage(), new Point(10, 100));
        //    g.DrawImage(p3.GetImage(), new Point(10, 200));
        //}
    }
}
