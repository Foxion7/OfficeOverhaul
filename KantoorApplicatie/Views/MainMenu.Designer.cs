﻿namespace KantoorApplicatie.Views
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            this.l_Help = new System.Windows.Forms.Label();
            this.b_Close = new System.Windows.Forms.Button();
            this.b_Thema = new System.Windows.Forms.Button();
            this.b_New = new System.Windows.Forms.Button();
            this.l_Name = new System.Windows.Forms.Label();
            this.b_Open = new System.Windows.Forms.Button();
            this.InvoiceManagerButton = new System.Windows.Forms.Button();
            this.CustomerManagerButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vormKiezenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vormOntwerpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_Help
            // 
            this.l_Help.AutoSize = true;
            this.l_Help.BackColor = System.Drawing.Color.Transparent;
            this.l_Help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.l_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Help.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.l_Help.Location = new System.Drawing.Point(376, 9);
            this.l_Help.Name = "l_Help";
            this.l_Help.Size = new System.Drawing.Size(38, 18);
            this.l_Help.TabIndex = 11;
            this.l_Help.Text = "Help";
            this.l_Help.Click += new System.EventHandler(this.l_Help_Click);
            // 
            // b_Close
            // 
            this.b_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Close.Location = new System.Drawing.Point(330, 239);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(84, 27);
            this.b_Close.TabIndex = 9;
            this.b_Close.Text = "Afsluiten";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // b_Thema
            // 
            this.b_Thema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Thema.Location = new System.Drawing.Point(12, 240);
            this.b_Thema.Name = "b_Thema";
            this.b_Thema.Size = new System.Drawing.Size(84, 26);
            this.b_Thema.TabIndex = 8;
            this.b_Thema.Text = "Thema";
            this.b_Thema.UseVisualStyleBackColor = true;
            this.b_Thema.Click += new System.EventHandler(this.b_Thema_Click);
            // 
            // b_New
            // 
            this.b_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_New.Location = new System.Drawing.Point(68, 91);
            this.b_New.Name = "b_New";
            this.b_New.Size = new System.Drawing.Size(135, 46);
            this.b_New.TabIndex = 6;
            this.b_New.Text = "Nieuw ontwerp";
            this.b_New.UseVisualStyleBackColor = true;
            this.b_New.Click += new System.EventHandler(this.b_New_Click);
            // 
            // l_Name
            // 
            this.l_Name.AutoSize = true;
            this.l_Name.BackColor = System.Drawing.Color.Transparent;
            this.l_Name.Font = new System.Drawing.Font("Segoe UI Symbol", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Name.Location = new System.Drawing.Point(71, 11);
            this.l_Name.Name = "l_Name";
            this.l_Name.Size = new System.Drawing.Size(302, 54);
            this.l_Name.TabIndex = 10;
            this.l_Name.Text = "OfficeOverhaul";
            // 
            // b_Open
            // 
            this.b_Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Open.Location = new System.Drawing.Point(220, 91);
            this.b_Open.Name = "b_Open";
            this.b_Open.Size = new System.Drawing.Size(135, 46);
            this.b_Open.TabIndex = 7;
            this.b_Open.Text = "Open ontwerp";
            this.b_Open.UseVisualStyleBackColor = true;
            this.b_Open.Click += new System.EventHandler(this.b_Open_Click);
            // 
            // InvoiceManagerButton
            // 
            this.InvoiceManagerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceManagerButton.Location = new System.Drawing.Point(68, 144);
            this.InvoiceManagerButton.Name = "InvoiceManagerButton";
            this.InvoiceManagerButton.Size = new System.Drawing.Size(135, 46);
            this.InvoiceManagerButton.TabIndex = 13;
            this.InvoiceManagerButton.Text = "Offertes";
            this.InvoiceManagerButton.UseVisualStyleBackColor = true;
            this.InvoiceManagerButton.Click += new System.EventHandler(this.InvoiceManagerButton_Click);
            // 
            // CustomerManagerButton
            // 
            this.CustomerManagerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerManagerButton.Location = new System.Drawing.Point(220, 144);
            this.CustomerManagerButton.Name = "CustomerManagerButton";
            this.CustomerManagerButton.Size = new System.Drawing.Size(135, 46);
            this.CustomerManagerButton.TabIndex = 14;
            this.CustomerManagerButton.Text = "Klanten";
            this.CustomerManagerButton.UseVisualStyleBackColor = true;
            this.CustomerManagerButton.Click += new System.EventHandler(this.CustomerManagerButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vormKiezenToolStripMenuItem,
            this.vormOntwerpenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 48);
            // 
            // vormKiezenToolStripMenuItem
            // 
            this.vormKiezenToolStripMenuItem.Name = "vormKiezenToolStripMenuItem";
            this.vormKiezenToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.vormKiezenToolStripMenuItem.Text = "Vorm kiezen";
            this.vormKiezenToolStripMenuItem.Click += new System.EventHandler(this.vormKiezenToolStripMenuItem_Click_1);
            // 
            // vormOntwerpenToolStripMenuItem
            // 
            this.vormOntwerpenToolStripMenuItem.Name = "vormOntwerpenToolStripMenuItem";
            this.vormOntwerpenToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.vormOntwerpenToolStripMenuItem.Text = "Vorm ontwerpen";
            this.vormOntwerpenToolStripMenuItem.Click += new System.EventHandler(this.vormOntwerpenToolStripMenuItem_Click_1);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 278);
            this.Controls.Add(this.l_Help);
            this.Controls.Add(this.CustomerManagerButton);
            this.Controls.Add(this.l_Name);
            this.Controls.Add(this.InvoiceManagerButton);
            this.Controls.Add(this.b_Close);
            this.Controls.Add(this.b_Thema);
            this.Controls.Add(this.b_Open);
            this.Controls.Add(this.b_New);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OfficeOverhaul";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Help;
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.Button b_Thema;
        private System.Windows.Forms.Button b_New;
        private System.Windows.Forms.Label l_Name;
        private System.Windows.Forms.Button b_Open;
        private System.Windows.Forms.Button InvoiceManagerButton;
        private System.Windows.Forms.Button CustomerManagerButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vormKiezenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vormOntwerpenToolStripMenuItem;
    }
}