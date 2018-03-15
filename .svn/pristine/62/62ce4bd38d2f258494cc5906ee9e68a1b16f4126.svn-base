using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KantoorApplicatie.Models.Floor;
using KantoorApplicatie.Db;
namespace KantoorApplicatie.Views
{
    public partial class ChooseFloor : Form
    {
        // List of all types.
        private List<FloorType> floorTypes { get; set; }
        // List of all materials.
        private List<FloorMaterial> floorMaterials { get; set; }
        // List of floortypes when material is selected.
        private List<FloorType> tempFloorType;
        // Is the selected floortype.
        public FloorType chosenFloorType;

        public ChooseFloor()
        {
            InitializeComponent();
            this.floorTypes = DatabaseController.floorTypeList;
            this.floorMaterials = DatabaseController.floorMaterialList;

            // add floor materials to combo box
            foreach (FloorMaterial material in floorMaterials)
            {
                floorMaterialComboBox.Items.Add(material.name);
            }
            floorMaterialComboBox.SelectedIndex = 0;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if(chosenFloorType != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Geen vloer soort geselecteerd.");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Makes a combobox of all kinds of floortypes for the selected floor material.
        private void floorMaterialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Resets the floortype combobox and picturebox when a new material is selected.
            if (floorTypeComboBox.Items.Count > 0)
            {
                floorTypeComboBox.ResetText();
            }
            floorTypeComboBox.Items.Clear();
            floorPictureBox.Image = null;
            // Find all floortypes of the selected floormaterial.
            tempFloorType = floorTypes.FindAll(v => v.floorMaterial.name == floorMaterialComboBox.SelectedItem.ToString());
            // Fill the combobox of floorype
            foreach (FloorType type in tempFloorType)
            {
                floorTypeComboBox.Items.Add(type.name);
            }
            // Change selected floortype.
            if (tempFloorType.Count > 0)
            {
                floorTypeComboBox.SelectedIndex = 0;
            }
        }

        // Shows the image of the selected floortype.
        private void floorTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenFloorType = tempFloorType.Find(v => v.name == floorTypeComboBox.SelectedItem.ToString());
            Bitmap image = chosenFloorType.GetImage();
            floorPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            floorPictureBox.Image = image;
            priceLabel.Text = "€" + tempFloorType.Find(v => v.name == floorTypeComboBox.SelectedItem.ToString()).price.ToString() + "  / m2";
        }
    }

   
}
