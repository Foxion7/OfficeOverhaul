using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KantoorApplicatie.Models;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using KantoorApplicatie.Controllers;

namespace KantoorApplicatie.Views
{
    public partial class RotatePanel : UserControl
    {
        private RotationController rc;
        private Product product;
        private DesignPanel dp;
        public Bitmap originalImage;

        public double bmWidth = 0;
        public double bmHeight = 0;

        public int offsetX;
        public int offsetY;

        private bool leftDown = false;
        private bool rightDown = false;

        public int count { get; set;}

        public RotatePanel(Product p, DesignPanel dp)
        {
            product = p;
            this.dp = dp;
            originalImage = p.image;
            count = 0;
            rc = new RotationController(this);
            InitializeComponent();
        }

        private void UpdatePanel()
        {
            dp.Invalidate();
        }

        // Deletes product from the list of products.
        private void Delete_Click(object sender, EventArgs e)
        {
            dp.DeleteProduct(product);
            dp.Controls.Remove(product.rp);
            UpdatePanel();
        }

        // Rotates a product by 0 degrees when placed, for consistency.
        public void StartRotation(int count) 
        {
            product.image = rc.RotateImage(originalImage, count);
            UpdatePanel();
        }

        // Mouse becomes hand when hovering over button.
        private void Button_MouseEnter(object sender, EventArgs e) {
            Cursor = Cursors.Hand;
        }

        // Mouse becomes arrow when not hovering over button.
        private void Button_MouseLeave(object sender, EventArgs e) {
            Cursor = Cursors.Arrow;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (leftDown)
            {
                count -= 2;
                product.image = rc.RotateImage(originalImage, count);
                UpdatePanel();
            }
            if (rightDown)
            {
                count += 2;
                product.image = rc.RotateImage(originalImage, count);
                UpdatePanel();
            }
        }

        private void LeftButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.timer1.Enabled = true;
            leftDown = true;
        }

        private void LeftButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.timer1.Enabled = false;
            leftDown = false;
        }

        private void RightButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.timer1.Enabled = true;
            rightDown = true;
        }

        private void RightButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.timer1.Enabled = false;
            rightDown = false;
        }
    }
}
