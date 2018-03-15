﻿namespace KantoorApplicatie.Views.Themeforms
{
    partial class ThemeImageDeleteForm
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
            this.b_Delete = new System.Windows.Forms.Button();
            this.b_Cancel = new System.Windows.Forms.Button();
            this.cb_Theme = new System.Windows.Forms.ComboBox();
            this.cb_SubTheme = new System.Windows.Forms.ComboBox();
            this.l_Selected = new System.Windows.Forms.Label();
            this.l_FileName = new System.Windows.Forms.Label();
            this.pb_picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // b_Delete
            // 
            this.b_Delete.Location = new System.Drawing.Point(189, 25);
            this.b_Delete.Name = "b_Delete";
            this.b_Delete.Size = new System.Drawing.Size(75, 23);
            this.b_Delete.TabIndex = 0;
            this.b_Delete.Text = "Delete";
            this.b_Delete.UseVisualStyleBackColor = true;
            this.b_Delete.Click += new System.EventHandler(this.b_Delete_Click);
            // 
            // b_Cancel
            // 
            this.b_Cancel.Location = new System.Drawing.Point(189, 99);
            this.b_Cancel.Name = "b_Cancel";
            this.b_Cancel.Size = new System.Drawing.Size(75, 23);
            this.b_Cancel.TabIndex = 1;
            this.b_Cancel.Text = "Annuleer";
            this.b_Cancel.UseVisualStyleBackColor = true;
            this.b_Cancel.Click += new System.EventHandler(this.b_Cancel_Click);
            // 
            // cb_Theme
            // 
            this.cb_Theme.FormattingEnabled = true;
            this.cb_Theme.Location = new System.Drawing.Point(12, 25);
            this.cb_Theme.Name = "cb_Theme";
            this.cb_Theme.Size = new System.Drawing.Size(121, 21);
            this.cb_Theme.TabIndex = 2;
            this.cb_Theme.SelectedIndexChanged += new System.EventHandler(this.cb_Theme_SelectedIndexChanged);
            // 
            // cb_SubTheme
            // 
            this.cb_SubTheme.FormattingEnabled = true;
            this.cb_SubTheme.Location = new System.Drawing.Point(12, 101);
            this.cb_SubTheme.Name = "cb_SubTheme";
            this.cb_SubTheme.Size = new System.Drawing.Size(121, 21);
            this.cb_SubTheme.TabIndex = 3;
            this.cb_SubTheme.SelectedIndexChanged += new System.EventHandler(this.cb_SubTheme_SelectedIndexChanged);
            // 
            // l_Selected
            // 
            this.l_Selected.AutoSize = true;
            this.l_Selected.Location = new System.Drawing.Point(12, 155);
            this.l_Selected.Name = "l_Selected";
            this.l_Selected.Size = new System.Drawing.Size(73, 13);
            this.l_Selected.TabIndex = 4;
            this.l_Selected.Text = "Geselecteerd:";
            // 
            // l_FileName
            // 
            this.l_FileName.AutoSize = true;
            this.l_FileName.Location = new System.Drawing.Point(12, 178);
            this.l_FileName.Name = "l_FileName";
            this.l_FileName.Size = new System.Drawing.Size(28, 13);
            this.l_FileName.TabIndex = 5;
            this.l_FileName.Text = "       ";
            // 
            // pb_picture
            // 
            this.pb_picture.Location = new System.Drawing.Point(118, 141);
            this.pb_picture.Name = "pb_picture";
            this.pb_picture.Size = new System.Drawing.Size(171, 96);
            this.pb_picture.TabIndex = 6;
            this.pb_picture.TabStop = false;
            // 
            // ThemeImageDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 233);
            this.Controls.Add(this.pb_picture);
            this.Controls.Add(this.l_FileName);
            this.Controls.Add(this.l_Selected);
            this.Controls.Add(this.cb_SubTheme);
            this.Controls.Add(this.cb_Theme);
            this.Controls.Add(this.b_Cancel);
            this.Controls.Add(this.b_Delete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemeImageDeleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thema verwijderen";
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Delete;
        private System.Windows.Forms.Button b_Cancel;
        private System.Windows.Forms.ComboBox cb_Theme;
        private System.Windows.Forms.ComboBox cb_SubTheme;
        private System.Windows.Forms.Label l_Selected;
        private System.Windows.Forms.Label l_FileName;
        private System.Windows.Forms.PictureBox pb_picture;
    }
}