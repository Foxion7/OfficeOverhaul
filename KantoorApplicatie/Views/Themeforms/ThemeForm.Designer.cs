﻿using KantoorApplicatie.Models.Theme;
namespace KantoorApplicatie.Views
{
    partial class ThemeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_LaatstGebruikt = new System.Windows.Forms.Label();
            this.label_LaatstGebruiktLink = new System.Windows.Forms.Label();
            this.button_Wijzig = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_UploadImage = new System.Windows.Forms.Button();
            this.cb_Theme = new System.Windows.Forms.ComboBox();
            this.cb_subTheme = new System.Windows.Forms.ComboBox();
            this.button_Empty = new System.Windows.Forms.Button();
            this.b_DeleteImage = new System.Windows.Forms.Button();
            this.pb_Voorbeeld = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Voorbeeld)).BeginInit();
            this.SuspendLayout();
            // 
            // label_LaatstGebruikt
            // 
            this.label_LaatstGebruikt.AutoSize = true;
            this.label_LaatstGebruikt.BackColor = System.Drawing.Color.Transparent;
            this.label_LaatstGebruikt.Location = new System.Drawing.Point(15, 88);
            this.label_LaatstGebruikt.Name = "label_LaatstGebruikt";
            this.label_LaatstGebruikt.Size = new System.Drawing.Size(79, 13);
            this.label_LaatstGebruikt.TabIndex = 0;
            this.label_LaatstGebruikt.Text = "Huidige Thema";
            // 
            // label_LaatstGebruiktLink
            // 
            this.label_LaatstGebruiktLink.AutoSize = true;
            this.label_LaatstGebruiktLink.BackColor = System.Drawing.Color.Transparent;
            this.label_LaatstGebruiktLink.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_LaatstGebruiktLink.ForeColor = System.Drawing.Color.Black;
            this.label_LaatstGebruiktLink.Location = new System.Drawing.Point(15, 114);
            this.label_LaatstGebruiktLink.Name = "label_LaatstGebruiktLink";
            this.label_LaatstGebruiktLink.Size = new System.Drawing.Size(49, 13);
            this.label_LaatstGebruiktLink.TabIndex = 1;
            this.label_LaatstGebruiktLink.Text = "              ";
            // 
            // button_Wijzig
            // 
            this.button_Wijzig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Wijzig.Location = new System.Drawing.Point(17, 149);
            this.button_Wijzig.Name = "button_Wijzig";
            this.button_Wijzig.Size = new System.Drawing.Size(121, 35);
            this.button_Wijzig.TabIndex = 2;
            this.button_Wijzig.Text = "Wijzig";
            this.button_Wijzig.UseVisualStyleBackColor = true;
            this.button_Wijzig.Click += new System.EventHandler(this.button_Wijzig_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Cancel.Location = new System.Drawing.Point(17, 190);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(121, 35);
            this.button_Cancel.TabIndex = 3;
            this.button_Cancel.Text = "Annuleer";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_UploadImage
            // 
            this.button_UploadImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_UploadImage.Location = new System.Drawing.Point(16, 272);
            this.button_UploadImage.Name = "button_UploadImage";
            this.button_UploadImage.Size = new System.Drawing.Size(121, 35);
            this.button_UploadImage.TabIndex = 4;
            this.button_UploadImage.Text = "Upload afbeelding";
            this.button_UploadImage.UseVisualStyleBackColor = true;
            this.button_UploadImage.Click += new System.EventHandler(this.button_UploadImage_Click);
            // 
            // cb_Theme
            // 
            this.cb_Theme.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cb_Theme.FormattingEnabled = true;
            this.cb_Theme.Location = new System.Drawing.Point(16, 24);
            this.cb_Theme.Name = "cb_Theme";
            this.cb_Theme.Size = new System.Drawing.Size(121, 21);
            this.cb_Theme.TabIndex = 5;
            this.cb_Theme.Text = "Thema\'s";
            this.cb_Theme.SelectedIndexChanged += new System.EventHandler(this.cb_Theme_SelectedIndexChanged);
            // 
            // cb_subTheme
            // 
            this.cb_subTheme.FormattingEnabled = true;
            this.cb_subTheme.Location = new System.Drawing.Point(16, 51);
            this.cb_subTheme.Name = "cb_subTheme";
            this.cb_subTheme.Size = new System.Drawing.Size(121, 21);
            this.cb_subTheme.TabIndex = 6;
            this.cb_subTheme.Text = "Sub Thema\'s";
            this.cb_subTheme.Visible = false;
            this.cb_subTheme.SelectedIndexChanged += new System.EventHandler(this.cb_subTheme_SelectedIndexChanged);
            // 
            // button_Empty
            // 
            this.button_Empty.Location = new System.Drawing.Point(17, 231);
            this.button_Empty.Name = "button_Empty";
            this.button_Empty.Size = new System.Drawing.Size(120, 35);
            this.button_Empty.TabIndex = 10;
            this.button_Empty.Text = "Leeg thema";
            this.button_Empty.UseVisualStyleBackColor = true;
            this.button_Empty.Click += new System.EventHandler(this.button_Empty_Click);
            // 
            // b_DeleteImage
            // 
            this.b_DeleteImage.Location = new System.Drawing.Point(16, 313);
            this.b_DeleteImage.Name = "b_DeleteImage";
            this.b_DeleteImage.Size = new System.Drawing.Size(121, 35);
            this.b_DeleteImage.TabIndex = 11;
            this.b_DeleteImage.Text = "Verwijder afbeelding";
            this.b_DeleteImage.UseVisualStyleBackColor = true;
            this.b_DeleteImage.Click += new System.EventHandler(this.b_DeleteImage_Click);
            // 
            // pb_Voorbeeld
            // 
            this.pb_Voorbeeld.Location = new System.Drawing.Point(199, 0);
            this.pb_Voorbeeld.Name = "pb_Voorbeeld";
            this.pb_Voorbeeld.Size = new System.Drawing.Size(503, 382);
            this.pb_Voorbeeld.TabIndex = 9;
            this.pb_Voorbeeld.TabStop = false;
            // 
            // ThemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(701, 376);
            this.Controls.Add(this.b_DeleteImage);
            this.Controls.Add(this.button_Empty);
            this.Controls.Add(this.pb_Voorbeeld);
            this.Controls.Add(this.cb_subTheme);
            this.Controls.Add(this.cb_Theme);
            this.Controls.Add(this.button_UploadImage);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Wijzig);
            this.Controls.Add(this.label_LaatstGebruiktLink);
            this.Controls.Add(this.label_LaatstGebruikt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thema selecteren";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Voorbeeld)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_LaatstGebruikt;
        private System.Windows.Forms.Label label_LaatstGebruiktLink;
        private System.Windows.Forms.Button button_Wijzig;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_UploadImage;
        private System.Windows.Forms.ComboBox cb_Theme;
        private System.Windows.Forms.ComboBox cb_subTheme;
        private System.Windows.Forms.Button button_Empty;
        private System.Windows.Forms.Button b_DeleteImage;
        private System.Windows.Forms.PictureBox pb_Voorbeeld;
    }
}