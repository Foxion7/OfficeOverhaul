﻿namespace KantoorApplicatie.Views.Themeforms
{
    partial class ThemeImageForm
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
            this.b_FileBrowser = new System.Windows.Forms.Button();
            this.b_Save = new System.Windows.Forms.Button();
            this.b_Cancel = new System.Windows.Forms.Button();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // b_FileBrowser
            // 
            this.b_FileBrowser.Location = new System.Drawing.Point(21, 22);
            this.b_FileBrowser.Name = "b_FileBrowser";
            this.b_FileBrowser.Size = new System.Drawing.Size(103, 53);
            this.b_FileBrowser.TabIndex = 0;
            this.b_FileBrowser.Text = "Kies Afbeelding";
            this.b_FileBrowser.UseVisualStyleBackColor = true;
            this.b_FileBrowser.Click += new System.EventHandler(this.b_FileBrowser_Click);
            // 
            // b_Save
            // 
            this.b_Save.Location = new System.Drawing.Point(216, 22);
            this.b_Save.Name = "b_Save";
            this.b_Save.Size = new System.Drawing.Size(105, 53);
            this.b_Save.TabIndex = 1;
            this.b_Save.Text = "Opslaan";
            this.b_Save.UseVisualStyleBackColor = true;
            this.b_Save.Click += new System.EventHandler(this.b_Save_Click);
            // 
            // b_Cancel
            // 
            this.b_Cancel.Location = new System.Drawing.Point(394, 22);
            this.b_Cancel.Name = "b_Cancel";
            this.b_Cancel.Size = new System.Drawing.Size(120, 53);
            this.b_Cancel.TabIndex = 2;
            this.b_Cancel.Text = "Annuleer";
            this.b_Cancel.UseVisualStyleBackColor = true;
            this.b_Cancel.Click += new System.EventHandler(this.b_Cancel_Click);
            // 
            // pb_Image
            // 
            this.pb_Image.Location = new System.Drawing.Point(0, 132);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(526, 284);
            this.pb_Image.TabIndex = 3;
            this.pb_Image.TabStop = false;
            // 
            // ThemeImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 416);
            this.Controls.Add(this.pb_Image);
            this.Controls.Add(this.b_Cancel);
            this.Controls.Add(this.b_Save);
            this.Controls.Add(this.b_FileBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemeImageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Afbeelding uploaden";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_FileBrowser;
        private System.Windows.Forms.Button b_Save;
        private System.Windows.Forms.Button b_Cancel;
        private System.Windows.Forms.PictureBox pb_Image;
    }
}