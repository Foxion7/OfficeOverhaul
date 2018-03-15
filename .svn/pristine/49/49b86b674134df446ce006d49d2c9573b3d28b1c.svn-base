using KantoorApplicatie.Models;
using KantoorApplicatie.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KantoorApplicatie.Controllers {
    public class CatalogController {

        // Vanillalist is the unchanged productlist retrieved from the database. It should never change unless a product is added.
        //private List<Product> vanillaList;
        public List<Product> productList { get; set; }
        public List<CatalogProductPanel> productPanelList { get; set; }

        private CatalogListPanel clp;
        private DesignPanel dp;

        private const string orderTextAZ = "Naam: A-Z";
        private const string orderTextZA = "Naam: Z-A";
        private const string orderTextHL = "Prijs: Hoog-Laag";
        private const string orderTextLH = "Prijs: Laag-Hoog";

        public string currentSorting { get; set; }
        public string currentOrdering { get; set; }
        public string currentSearch { get; set; }

        public CatalogController(CatalogListPanel clp, DesignPanel dp) 
        {
            this.dp = dp;
            productList = Db.DatabaseController.productList;
            this.clp = clp;
            //vanillaList = productList;
            productPanelList = new List<CatalogProductPanel>();

            // The standard sorting, ordering and searchqueries are set everytime the program starts.
            currentOrdering = "Naam: A-Z";
            currentSorting = "Alle";
            currentSearch = "";
        }

        // Refreshes the displayed products in the catalog and applies the current order, sorting or searchquery.
        public void RefreshDisplayedItems() 
        {
            ClearDisplayedProductList();
            productList = RemoveNonSearchedProducts(Db.DatabaseController.productList);
            productList = RemoveNonSortedProducts(productList);
            productList = OrderProducts(productList);
            FillDisplayedProductList();
        }

        // Removes products from productlist that do not comply with the searchquery.
        public List<Product> RemoveNonSearchedProducts(List<Product> list) 
            {
            if (currentSearch == "") 
                {
                return list;
            }
            currentSearch = currentSearch.ToLower();
            List<Product> newList = new List<Product>();
            for (int i = 0; i < list.Count; i++) {
                if (list[i].name.ToLower().Contains(currentSearch)) 
                {
                    newList.Add(list[i]);
                }
            }
            return newList;
        }

        // Removes products from productlist that do not comply with the sorttype.
        public List<Product> RemoveNonSortedProducts(List<Product> list) 
        {
            if (currentSorting == "" || currentSorting == "Alle") 
            {
                return list;
            }
            else
            {
                List<Product> newList = new List<Product>();
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].GetType().BaseType.Name.Equals(currentSorting))
                    {
                        newList.Add(list[i]);
                    }
                }
                return newList;
            }
        }
        
        // Orders the productlist in one of the various orders. 
        public List<Product> OrderProducts(List<Product> list) 
        {
            switch (currentOrdering) 
            {
                case orderTextAZ:
                    list = list.OrderBy(x => x.name).ToList();
                    break;
                case orderTextZA:
                    list = list.OrderBy(x => x.name).ToList();
                    list.Reverse();
                    break;
                case orderTextHL:
                    list = list.OrderBy(x => x.price).ToList();
                    list.Reverse();
                    break;
                case orderTextLH:
                    list = list.OrderBy(x => x.price).ToList();
                    break;
            }
            return list;
        }

        // Makes CatalogProductPanels from all products in productlist.
        // It positions them correctly and adds these to the actual display: CatalogListPanel.
        private void FillDisplayedProductList()
        {
            Point point = new Point(0, 0);
            foreach (Product product in productList) 
            {
                if (product.active) {
                    CatalogProductPanel pp = new CatalogProductPanel(product, dp, this);
                    pp.Location = point;
                    productPanelList.Add(pp);
                    clp.AddProduct(pp);
                    point.Y += 160;
                }
            }
        }

        // Clears all currently displayed products from the catalog.
        private void ClearDisplayedProductList() 
        {
            foreach (CatalogProductPanel pp in productPanelList) 
            {
                clp.RemoveProduct(pp);
            }
            productPanelList.Clear();
        }

        //public void AddProductToVanillaList(Product p) 
        //{
            //vanillaList.Add(p);
            //Db.DatabaseController.AddProducts(p);
        //}
    }
}
