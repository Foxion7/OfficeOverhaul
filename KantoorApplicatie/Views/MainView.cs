using KantoorApplicatie.Views;
using KantoorApplicatie.Models;
using KantoorApplicatie.Models.Theme;
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
using System.IO;
using System.Xml;
using KantoorApplicatie.Models.Floor;
using KantoorApplicatie.Models.Invoice;
using KantoorApplicatie.Views.Invoice;
using KantoorApplicatie.Views.Themeforms;

namespace KantoorApplicatie
{
    public partial class MainView : Form
    {
        public Room room;
        public Customer customer;
        public Views.MainMenu mm { get; set; }
        //private List<Product> productList;
        public List<FloorType> floorTypeList;
        public List<FloorMaterial> floorMaterialList;
        public XmlController xml = new XmlController();
        public RoomMaker roomMaker1 { get; set; }
        private bool nightModeBool;

        public MainView(Views.MainMenu mm)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            InitializeComponent();

            nightModeBool = false;
            this.mm = mm;
            //productList = DatabaseController.GetProducts();
            floorTypeList = DatabaseController.floorTypeList;
            floorMaterialList = DatabaseController.floorMaterialList;
            // Sets all products in the database into the catalog list.
            catalogPanel1.InstantiateProductList(DesignPanel1);
            // Sets necessary info in the XmlController.
            setBackground(DatabaseController.getLastSubTheme());
            room = new Room();
            room.productList = new List<Product>();
            xml.room = room;
            //xml.productList = productList;
            //xml.floorTypeList = floorTypeList;
            xml.dp = DesignPanel1;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenXML();
        }

        // Opens menu to change the theme or add a new theme.
        private void ThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemeForm tf = new ThemeForm(this, mm);
            tf.ShowDialog();
            if (tf.DialogResult == DialogResult.OK)
            {
                mm.Hide();
                this.Show();
            }
        }

        // Opens menu to add a new product to the catalog.
        private void nieuwObjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProductForm nof = new NewProductForm(catalogPanel1);
            nof.ShowDialog();
        }

        // Open shapeselector.
        public void ShapeSelect()
        {
            room = new Room();
            ShapeSelector ss = new ShapeSelector(room);
            ss.ShowDialog();
            if (ss.DialogResult == DialogResult.OK)
            { 
                room.productList = new List<Product>();

                DesignPanel1.rDesign = room;
                //mm.Hide();
                if(roomMaker1 != null)
                {
                    roomMaker1.Hide();
                    roomMaker1 = null;
                }
                Controls.Remove(roomMaker1);

                this.Show();
            }
            DesignPanel1.UnsetMightMode();
            nightModeBool = false;
        }

        // Clears the theme.
        public void clearBackground()
        {
            DesignPanel1.BackgroundImage = null;
        }

        // Set the backgroundpicture.
        public void setBackground(SubTheme st)
        {
            if (st != null)
            {
                DesignPanel1.BackgroundImage = st.GetImage();
                DesignPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
        
        // Make a new invoice with the products in the room.
        private void nieuweOfferteToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            bool inactiveProducts = false;
            for(int i = 0; i < DesignPanel1.rDesign.productList.Count; i++)
            {
                if (!DesignPanel1.rDesign.productList[i].active)
                {
                    inactiveProducts = true;
                }
            }
            if (!inactiveProducts)
            {
                InvoiceForm ivf = new InvoiceForm(DesignPanel1.rDesign, this);
                ivf.InstantiateAutocompleteLists();
                ivf.FillExistingCustomerList();
                ivf.ShowDialog();
            }
            else
            {
                MessageBox.Show("Er staan inactieve producten in uw ontwerp. Wilt u deze verwijderen?", "Foutmelding", MessageBoxButtons.OK);
            }
        }

        // Save the room with all its products in an XML.
        private void bewerkbaarOpslaanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "Document";
            dlg.DefaultExt = ".xml";
            dlg.Filter = "XML Files (*.xml) | *.xml";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (DesignPanel1.rDesign != null)
                {
                    xml.SaveXml(dlg.FileName);
                    MessageBox.Show(String.Format("Bestand opgeslagen in {0}", dlg.FileName));
                }
                else
                {
                    MessageBox.Show("Maak eerst een ruimte aan!");
                }
            }
        }

        // Load a room with all its products from XML.
        public void OpenXML()
        {
            DesignPanel1.containsInactiveProduct = false;

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "XML Files (*.xml) | *.xml";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                xml.OpenXml(dlg.FileName);
                Show();
                mm.Hide();
            }
            // Show message when an inactive product is present.
            if (DesignPanel1.containsInactiveProduct)
            {
                string message = "De volgende producten zijn niet meer leverbaar: \n";
                foreach(Product p in DesignPanel1.rDesign.productList)
                {
                    if(!p.active)
                        message += p.name + "\n";
                }
                MessageBox.Show(message);
            }
        }

        // Confirmation message to exit program.
        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Weet u het zeker?", "Afsluiten", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(1);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        // Close button click event.
        private void closeBox_Click(object sender, EventArgs e)
        {

            this.Close();
            
        }

        // Hover event to highlight close button when hovering over.
        private void closeBox_MouseHover(object sender, EventArgs e)
        {
            closeBox.BackgroundImage = Properties.Resources.ExitHover;
        }

        // Resets the image of the close button when mouse leaves the area.
        private void closeBox_MouseLeave(object sender, EventArgs e)
        {
            closeBox.BackgroundImage = Properties.Resources.Exit;
        }

        // Opens form to choose a room shape.
        private void vormKiezenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShapeSelect();
        }

        // Opens control to make your own room shape.
        private void vormZelfMakenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            roomMaker1 = new RoomMaker(this);
            roomMaker1.Width = Width;
            roomMaker1.Height = Height;
            roomMaker1.Location = new Point(0, 22);
            Controls.Add(roomMaker1);
            roomMaker1.Show();
            roomMaker1.BringToFront();
            DesignPanel1.UnsetMightMode();
            nightModeBool = false;
        }

        // This function is used for when you created your own room.
        public void setDesignPanelRoom(Room r)
        {
            DesignPanel1.rDesign = r;
        }

        private void wisselNachtmodusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!nightModeBool) {
                DesignPanel1.SetNightMode();
                nightModeBool = true;
            }
            else
            {
                DesignPanel1.UnsetMightMode();
                nightModeBool = false;
            }
        }

        private void saveAsImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var bmp = new Bitmap(DesignPanel1.Width, DesignPanel1.Height))
            {
                // Make screenshot.
                DesignPanel1.DrawToBitmap(bmp, new Rectangle(0, 0, DesignPanel1.Width, DesignPanel1.Height));

                // Save screenshot to chosen location.
                string filePath = "";
                FolderBrowserDialog fdd = new FolderBrowserDialog();
                if (fdd.ShowDialog() == DialogResult.OK)
                {
                    filePath = fdd.SelectedPath.ToString();
                    bmp.Save(filePath + "/Kamerontwerp.png");
                } else
                {
                    fdd.Dispose();
                }
            }
        }
    }
}
