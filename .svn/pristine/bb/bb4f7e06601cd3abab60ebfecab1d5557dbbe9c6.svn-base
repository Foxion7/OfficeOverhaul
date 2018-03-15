using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KantoorApplicatie.Controllers;
using KantoorApplicatie.Models.Theme;
using KantoorApplicatie.Views.Themeforms;
using KantoorApplicatie.Db;
using KantoorApplicatie.Properties;

namespace KantoorApplicatie.Views
{
    public partial class ThemeForm : Form
    {
        // List of all themes
        //public List<Theme> themes { get; set; }
        // List of all subthemes
        //public List<SubTheme> subThemes { get; set; }
        // Selected subtheme
        public SubTheme selectedSubtheme { get; set; }
        private int selectedThemeIndex;
        // Current selected image
        private Bitmap selectedBackground;                           
        public MainView mv { get; set; }
        private MainMenu mm;
        // List of subtheme's when a main theme is selected.
        private List<SubTheme> selectedThemeSubThemes;

        public ThemeForm(MainView mv)
        {
            this.mv = mv;
            // List of themes pulled from database
            //themes = DatabaseController.GetThemes();
            // List of subthemes pulled from database
            //subThemes = DatabaseController.GetSubThemes();
            InitializeComponent();
            if (DatabaseController.getLastSubTheme() != null)
            {
                this.BackgroundImageLayout = ImageLayout.Stretch;
                this.BackgroundImage = Converter.ByteArrayToImage(DatabaseController.getLastSubTheme().image);
            }

            // Setting "latest theme"
            if (DatabaseController.getLastSubTheme() != null)
            {
                this.label_LaatstGebruiktLink.Text = DatabaseController.getLastSubTheme().name;
                selectedSubtheme = DatabaseController.getLastSubTheme();
                SetExampleBg();
            }

            // Adding theme's to combobox
            foreach (Theme t in DatabaseController.themeList)
            {
                cb_Theme.Items.Add(t.name);
            }
        }

        // Themeform constructor when opened from main menu
        public ThemeForm(MainView mv, MainMenu mm)
            :this(mv)
        {
            this.mm = mm;
        }

        // Function for setting image in picturebox on startup
        private void SetExampleBg()
        {
            pb_Voorbeeld.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Voorbeeld.Image = Converter.ByteArrayToImage(selectedSubtheme.image);
        }

        // Function for setting background image in main menu and mainview
        private void InsertImage(SubTheme st)
        {
            this.selectedBackground = st.GetImage();
            pb_Voorbeeld.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Voorbeeld.Image = selectedBackground;
            mm.SetBackground(st);
            mv.setBackground(st);
        }

        private void cb_Theme_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Setting second combobox visible
            selectedThemeIndex = cb_Theme.SelectedIndex;
            cb_subTheme.Visible = true;
            // Clearing other items
            cb_subTheme.Items.Clear();
            // Adding the right subtheme's for each theme
            if (cb_Theme.SelectedItem != null)
            {
                selectedThemeSubThemes = DatabaseController.subThemeList.FindAll(v => v.theme.name == cb_Theme.SelectedItem.ToString());
            }
                foreach (SubTheme st in selectedThemeSubThemes)
            {
                cb_subTheme.Items.Add(st.name);
            }
        }

        private void cb_subTheme_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Setting preview image
            SubTheme ExampleImage = (selectedThemeSubThemes.Find(v => v.name == cb_subTheme.SelectedItem.ToString()));
            selectedSubtheme = (selectedThemeSubThemes.Find(v => v.name == cb_subTheme.SelectedItem.ToString()));
            SetExampleBg();
        }

        // Closing form without saving changes
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            pb_Voorbeeld.Image = null;
            this.Close();
        }

        // Setting the image from the selected subtheme as background in MainView
        private void button_Wijzig_Click(object sender, EventArgs e)
        {
            // Check to see if subtheme is selected
            if (cb_subTheme.SelectedIndex > -1)                                      
            {
                // Auto close form
                this.DialogResult = DialogResult.OK;
                this.Close();
                DatabaseController.setLastUsed(selectedSubtheme);
                mv.setBackground(selectedSubtheme);
                mm.SetBackground(selectedSubtheme);
            }
            else
            {
                // Error message if no subtheme is selected
                MessageBox.Show("Kies een achtergrond a.u.b.", "Foutmelding",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Opens ThemeImageForm
        private void button_UploadImage_Click(object sender, EventArgs e)
        {
            ThemeImageForm tif = new ThemeImageForm(this);
            tif.ShowDialog();

            //this.subThemes = DatabaseController.subThemeList;
            cb_Theme.SelectedIndex = selectedThemeIndex;

            selectedThemeSubThemes = DatabaseController.subThemeList.FindAll(v => v.theme.name == cb_Theme.SelectedItem.ToString());
            this.cb_subTheme.Items.Clear();

            foreach (SubTheme st in selectedThemeSubThemes)
            {
                cb_subTheme.Items.Add(st.name);
            }
            selectedSubtheme = tif.subTheme;
        }

        // Empty background and clears last used background in database
        private void button_Empty_Click(object sender, EventArgs e)
        {
            ClearBackground();
            this.Close();
        }

        // Opens ThemeImageDeleteForm
        private void b_DeleteImage_Click(object sender, EventArgs e)
        {
            ThemeImageDeleteForm tidf = new ThemeImageDeleteForm(this);
            tidf.ShowDialog();
            this.Refresh();
        }

        // Clears the combobox of subthemes and resets themes and subthemes list. Also sets theme combobox to blank for a fresh start
        public void ClearComboBoxes()
        {
            cb_subTheme.Items.Clear();
            //this.themes = DatabaseController.GetThemes();
            cb_Theme.SelectedIndex = -1;
            //this.subThemes = DatabaseController.GetSubThemes();
        }

        public void ClearBackground()
        {
            pb_Voorbeeld.Image = null;
            DatabaseController.ClearLastUsed();
            mv.clearBackground();
            mm.ClearBackground();
        }
    }
}
