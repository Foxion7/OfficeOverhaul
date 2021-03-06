﻿namespace KantoorApplicatie.Views {
    partial class CatalogProductPanel {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.crossPicturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Enabled = false;
            this.nameLabel.Location = new System.Drawing.Point(3, 5);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "[Naam]";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Enabled = false;
            this.descriptionLabel.Location = new System.Drawing.Point(3, 18);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(178, 47);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "[Beschrijving]";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(76, 71);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.CatalogProductPanel_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.CatalogProductPanel_MouseLeave);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Enabled = false;
            this.widthLabel.Location = new System.Drawing.Point(3, 98);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(53, 13);
            this.widthLabel.TabIndex = 3;
            this.widthLabel.Text = "[Breedte] ";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Enabled = false;
            this.heightLabel.Location = new System.Drawing.Point(3, 133);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(51, 13);
            this.heightLabel.TabIndex = 4;
            this.heightLabel.Text = "[Hoogte] ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(3, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Breedte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(3, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hoogte:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Enabled = false;
            this.priceLabel.Location = new System.Drawing.Point(73, 5);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(32, 13);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "[Prijs]";
            // 
            // crossPicturebox
            // 
            this.crossPicturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.crossPicturebox.Image = global::KantoorApplicatie.Properties.Resources.ExitHover;
            this.crossPicturebox.Location = new System.Drawing.Point(154, -1);
            this.crossPicturebox.Name = "crossPicturebox";
            this.crossPicturebox.Size = new System.Drawing.Size(24, 23);
            this.crossPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.crossPicturebox.TabIndex = 8;
            this.crossPicturebox.TabStop = false;
            this.crossPicturebox.Visible = false;
            this.crossPicturebox.Click += new System.EventHandler(this.crossPicturebox_Click);
            this.crossPicturebox.MouseLeave += new System.EventHandler(this.CatalogProductPanel_MouseLeave);
            // 
            // CatalogProductPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.crossPicturebox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nameLabel);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(180, 160);
            this.Name = "CatalogProductPanel";
            this.Size = new System.Drawing.Size(180, 160);
            this.MouseEnter += new System.EventHandler(this.CatalogProductPanel_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.CatalogProductPanel_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.PictureBox crossPicturebox;
    }
}
