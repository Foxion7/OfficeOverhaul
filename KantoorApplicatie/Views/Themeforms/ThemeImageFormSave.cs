﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KantoorApplicatie.Models.Theme;
using KantoorApplicatie.Views;
using KantoorApplicatie.Db;

namespace KantoorApplicatie.Views.Themeforms
{
    public partial class ThemeImageFormSave : Form
    {
        public string name { get; set; }
        public Theme theme { get; set; }
        public bool show { get; set; }
        private ThemeForm tf;
        private ThemeImageForm tif;
        //private List<Theme> themes;

        public ThemeImageFormSave(ThemeForm tf, ThemeImageForm tif)
        {
            this.tf = tf;
            this.tif = tif;
            InitializeComponent();
            //using (var mc = new MyContext())
            //{
            //    themes = (from s in mc.themes
            //              select s).ToList<Theme>();
            //}

            foreach (Theme t in DatabaseController.themeList)
            {
                cb_themes.Items.Add(t.name);
            }
        }

        // Adding image to database
        private void b_Save_Click(object sender, EventArgs e)
        {
            if (tb_name.Text != "" && cb_themes.SelectedIndex >= 0)
            {
                this.name = tb_name.Text;
                this.theme = DatabaseController.themeList[cb_themes.SelectedIndex];

                DatabaseController.AddSubTheme(this.name, tif.image, this.theme.themeId);
                //tif.subTheme = st;

                MessageBox.Show("Thema opgeslagen");
                this.Close();
            } else
            {
                MessageBox.Show("Vul eerst een naam en thema in.", "ERROR", MessageBoxButtons.OK);
            }
        }

        // closes this form
        private void b_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
