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
    public partial class SaveRoom : Form
    {
        // Not properties because otherwise they cant be used for TryParse.
        public int height;
        public int width;

        public SaveRoom()
        {
            InitializeComponent();
            errorLabel.ForeColor = Color.Red;
            txtHeight.Text = 500.ToString();
            txtWidth.Text = 500.ToString();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtHeight.Text, out height) && Int32.TryParse(txtWidth.Text, out width))
            {
                // Check if numbers are bigger then 0.
                if (!(height <= 0 || width <= 0))
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    errorLabel.Text = "De waarde moet groter zijn dan 0";
                }
            }
            else
            {
                errorLabel.Text = "Lengte en/of breedte moet een getal zijn";
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
