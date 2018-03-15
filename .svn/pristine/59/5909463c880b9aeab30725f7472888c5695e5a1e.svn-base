using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KantoorApplicatie.Views.Themeforms;
using KantoorApplicatie.Models.Theme;
using KantoorApplicatie.Db;
using KantoorApplicatie.Controllers;

namespace KantoorApplicatie.Views.Themeforms
{
    public partial class ThemeImageDeleteForm : Form
    {
        // List with themes gets pulled from the database
        //private List<Theme> themes = DatabaseController.GetThemes();
        // List with subthemes gets pulled from the database
        //private List<SubTheme> subThemes = DatabaseController.GetSubThemes();
        // List of all the subthemes that belong in the selected main theme
        private List<SubTheme> selectedThemeSubThemes;
        // Selected main theme
        private Theme selectedTheme;
        // Selected sub theme
        private SubTheme selectedSubTheme;
        private ThemeForm tf;

        public ThemeImageDeleteForm(ThemeForm tf)
        {
            this.tf = tf;
            InitializeComponent();
            // Combobox with themes get filled
            FillThemeBox();
        }

        private void b_Delete_Click(object sender, EventArgs e)
        {
            // Check to see if subtheme is selected
            if (cb_Theme.SelectedIndex > -1 && cb_SubTheme.SelectedIndex > -1)
            {
                // Check if subtheme actually gets deleted from the database
                int x = DatabaseController.subThemeList.Count;
                if(selectedSubTheme.name == tf.selectedSubtheme.name)
                {
                    tf.ClearBackground();
                    this.BackgroundImage = null;
                }
                DatabaseController.DeleteSubTheme(selectedSubTheme);

                // Resetting comboboxes in DeleteForm
                cb_SubTheme.Items.Clear();
                cb_Theme.Items.Clear();
                FillThemeBox();

                // Resetting comboboxes in ThemeForm
                tf.ClearComboBoxes();
                this.Close();
            } else
            {
                MessageBox.Show("Selecteer een achtergrond die u wilt verwijderen.", "Niet alles is ingevuld!", MessageBoxButtons.OK);
            }
        }

        // Closes the form
        private void b_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // When a theme is selected, combobox with subthemes gets filled with the correct subthemes
        private void cb_Theme_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedTheme = DatabaseController.themeList[cb_Theme.SelectedIndex];
            selectedThemeSubThemes = DatabaseController.subThemeList.FindAll(v => v.theme.name == cb_Theme.SelectedItem.ToString());
            FillSubThemeBox(selectedThemeSubThemes);
        }

        // When a subtheme is selected, change filename label and example picture.
        private void cb_SubTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSubTheme = DatabaseController.subThemeList.First(x => x.name == cb_SubTheme.SelectedItem.ToString());
            l_FileName.Text = selectedThemeSubThemes[cb_SubTheme.SelectedIndex].name;
            pb_picture.BackgroundImageLayout = ImageLayout.Stretch;
            pb_picture.Image = Converter.ByteArrayToImage(selectedSubTheme.image);
        }

        // Fills the combobox with main themes
        private void FillThemeBox()
        {
            cb_Theme.Items.Clear();
            foreach (Theme t in DatabaseController.themeList)
            {
                cb_Theme.Items.Add(t.name);
            }
        }

        // Fills the combobox with sub themes
        private void FillSubThemeBox(List<SubTheme> subThemes)
        {
            cb_SubTheme.Items.Clear();
            foreach (SubTheme st in subThemes)
            {
                cb_SubTheme.Items.Add(st.name);
            }
        }
    }
}
