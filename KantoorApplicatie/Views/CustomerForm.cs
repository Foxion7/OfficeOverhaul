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
using KantoorApplicatie.Models.Invoice;
using KantoorApplicatie.Db;

namespace KantoorApplicatie.Views
{
    public partial class CustomerForm : Form
    {
        public Customer customer { get; set; }
        public SubTheme subtheme { get; set; }
        private MainMenu mm;
        private List<Customer> customers;

        public CustomerForm(MainMenu mm)
        {
            this.mm = mm;
            mm.Hide();
            customers = DatabaseController.GetCustomers();
            InitializeComponent();
            foreach (Customer c in customers)
            {
                cb_customers.Items.Add($"{c.companyName} - {c.department} - {c.name}");
            }
            
        }

        // sets selected customer
        private void b_set_Click(object sender, EventArgs e)
        {
            if (cb_customers.SelectedIndex > -1)
            {
                if (subtheme != null)
                {
                    DatabaseController.setLastUsed(subtheme);
                    mm.SetBackground(subtheme);
                }
                this.Close();
                mm.Show();
            } else
            {
                MessageBox.Show("Selecteer een klant", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void SetSubTheme(int ID)
        // Sets the subtheme from customer
        {
            List<SubTheme> subthemes = DatabaseController.subThemeList;
            foreach (SubTheme s in subthemes)
            {
                if(s.subThemeId == customer.subThemeId)
                {
                    this.subtheme = s;
                }
            }
        }

        // Set backgroundimage
        private void SetBackGround(SubTheme st)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Converter.ByteArrayToImage(st.image);
        }

        public void SetCustomer(Customer c)
        {
            this.customer = c;
            mm.customer = c;
        }

        // When a customer is selected, send customer to Main Menu
        private void cb_customers_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Customer c in customers)
            {
                if (($"{c.companyName} - {c.department} - {c.name}") == cb_customers.SelectedItem.ToString())
                {
                    SetCustomer(c);
                }
            }
            if (subtheme != null)
            {
                SetSubTheme(customer.subThemeId);
                SetBackGround(subtheme);
            }
        }

        // Closes form
        private void b_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            mm.Show();
        }
    }
}
