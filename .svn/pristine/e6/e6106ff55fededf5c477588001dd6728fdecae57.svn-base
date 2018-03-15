
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
        public DesignPanel dp { get; set; }
        public List<Product> productList;

        public CatalogPanel() 
        {
            InitializeComponent();
        }

        // Sets the productlist so that it's filled on startup. Then it refreshes the displayed products to fill the catalog.
        public void InstantiateProductList(DesignPanel dp) 
        {
            this.productList = Db.DatabaseController.productList;
            this.dp = dp;
            catalogController = new CatalogController(catalogListPanel1, dp);
            catalogController.RefreshDisplayedItems();
        }

        // Sets sorting- and orderingcomboboxes to their first options.
        protected override void OnLoad(EventArgs e) 
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }
        // Sets ordering and refreshes displayed items whenever the ordering is changed.
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            catalogListPanel1.AutoScroll = false;
            if (catalogController != null) 
            {
                catalogController.currentOrdering = comboBox1.SelectedItem.ToString();
                catalogController.RefreshDisplayedItems();
            }
            catalogListPanel1.AutoScroll = true;
        }

        // Translates items, sets sorting and refreshes displayed items whenever the sorting is changed.
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            catalogListPanel1.AutoScroll = false;
            string type = comboBox2.SelectedItem.ToString();
            if (type.Equals("Stoel")) 
            {
                type = "Chair";
            } else if (type.Equals("Kast")) 
            {
                type = "Closet";
            } else if (type.Equals("Essentiële")) 
            {
                type = "Essentials";
            } else if (type.Equals("Bank"))
            {
                type = "Sofa";
            } else if (type.Equals("Tafel")) 
            {
                type = "Table";
            } else if (type.Equals("WandAccesoire")) 
            {
                type = "WallAccessories";
            }
            if (catalogController != null) 
            {
                catalogController.currentSorting = type;
                catalogController.RefreshDisplayedItems();
            }
            catalogListPanel1.AutoScroll = true;
        }

        // Empties searchTextbox when user first clicks on it.
        private void searchBox1_Click(object sender, EventArgs e)
        {
            if (searchBox1.Text.Equals("Zoek op naam..."))
            {
                searchBox1.Text = "";
            }
        }

        // Sets searchquery and refreshes displayed list whenever the searchTextbox updates.
        private void searchBox1_TextChanged(object sender, EventArgs e)
        {
            catalogListPanel1.AutoScroll = false;
            if (!searchBox1.Text.Equals("Zoek op naam..."))
            {
                catalogController.currentSearch = searchBox1.Text;
                catalogController.RefreshDisplayedItems();
            }
            catalogListPanel1.AutoScroll = true;
        }
    }
}
