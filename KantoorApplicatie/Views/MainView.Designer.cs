﻿namespace KantoorApplicatie
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nieuwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vormKiezenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vormZelfMakenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bewerkbaarOpslaanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optiesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wisselNachtmodusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nieuwObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nieuweOfferteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogPanel1 = new KantoorApplicatie.Views.CatalogPanel();
            this.DesignPanel1 = new KantoorApplicatie.Views.DesignPanel();
            this.closeBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkOrange;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nieuwToolStripMenuItem,
            this.openToolStripMenuItem,
            this.optiesToolStripMenuItem,
            this.optiesToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1016, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nieuwToolStripMenuItem
            // 
            this.nieuwToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vormKiezenToolStripMenuItem,
            this.vormZelfMakenToolStripMenuItem});
            this.nieuwToolStripMenuItem.Name = "nieuwToolStripMenuItem";
            this.nieuwToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.nieuwToolStripMenuItem.Text = "Nieuw";
            // 
            // vormKiezenToolStripMenuItem
            // 
            this.vormKiezenToolStripMenuItem.Name = "vormKiezenToolStripMenuItem";
            this.vormKiezenToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.vormKiezenToolStripMenuItem.Text = "Vorm kiezen";
            this.vormKiezenToolStripMenuItem.Click += new System.EventHandler(this.vormKiezenToolStripMenuItem_Click);
            // 
            // vormZelfMakenToolStripMenuItem
            // 
            this.vormZelfMakenToolStripMenuItem.Name = "vormZelfMakenToolStripMenuItem";
            this.vormZelfMakenToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.vormZelfMakenToolStripMenuItem.Text = "Vorm zelf maken";
            this.vormZelfMakenToolStripMenuItem.Click += new System.EventHandler(this.vormZelfMakenToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // optiesToolStripMenuItem
            // 
            this.optiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bewerkbaarOpslaanToolStripMenuItem,
            this.saveAsImageToolStripMenuItem});
            this.optiesToolStripMenuItem.Name = "optiesToolStripMenuItem";
            this.optiesToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.optiesToolStripMenuItem.Text = "Opslaan";
            // 
            // bewerkbaarOpslaanToolStripMenuItem
            // 
            this.bewerkbaarOpslaanToolStripMenuItem.Name = "bewerkbaarOpslaanToolStripMenuItem";
            this.bewerkbaarOpslaanToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.bewerkbaarOpslaanToolStripMenuItem.Text = "Bewerkbaar opslaan";
            this.bewerkbaarOpslaanToolStripMenuItem.Click += new System.EventHandler(this.bewerkbaarOpslaanToolStripMenuItem_Click);
            // 
            // saveAsImageToolStripMenuItem
            // 
            this.saveAsImageToolStripMenuItem.Name = "saveAsImageToolStripMenuItem";
            this.saveAsImageToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.saveAsImageToolStripMenuItem.Text = "Opslaan als afbeelding";
            this.saveAsImageToolStripMenuItem.Click += new System.EventHandler(this.saveAsImageToolStripMenuItem_Click);
            // 
            // optiesToolStripMenuItem1
            // 
            this.optiesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThemeToolStripMenuItem,
            this.wisselNachtmodusToolStripMenuItem,
            this.nieuwObjectToolStripMenuItem,
            this.nieuweOfferteToolStripMenuItem});
            this.optiesToolStripMenuItem1.Name = "optiesToolStripMenuItem1";
            this.optiesToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.optiesToolStripMenuItem1.Text = "Opties";
            // 
            // ThemeToolStripMenuItem
            // 
            this.ThemeToolStripMenuItem.Name = "ThemeToolStripMenuItem";
            this.ThemeToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.ThemeToolStripMenuItem.Text = "Thema";
            this.ThemeToolStripMenuItem.Click += new System.EventHandler(this.ThemeToolStripMenuItem_Click);
            // 
            // wisselNachtmodusToolStripMenuItem
            // 
            this.wisselNachtmodusToolStripMenuItem.Name = "wisselNachtmodusToolStripMenuItem";
            this.wisselNachtmodusToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.wisselNachtmodusToolStripMenuItem.Text = "Wissel nachtmodus";
            this.wisselNachtmodusToolStripMenuItem.Click += new System.EventHandler(this.wisselNachtmodusToolStripMenuItem_Click);
            // 
            // nieuwObjectToolStripMenuItem
            // 
            this.nieuwObjectToolStripMenuItem.Name = "nieuwObjectToolStripMenuItem";
            this.nieuwObjectToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.nieuwObjectToolStripMenuItem.Text = "Nieuw product";
            this.nieuwObjectToolStripMenuItem.Click += new System.EventHandler(this.nieuwObjectToolStripMenuItem_Click);
            // 
            // nieuweOfferteToolStripMenuItem
            // 
            this.nieuweOfferteToolStripMenuItem.Name = "nieuweOfferteToolStripMenuItem";
            this.nieuweOfferteToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.nieuweOfferteToolStripMenuItem.Text = "Nieuwe offerte";
            this.nieuweOfferteToolStripMenuItem.Click += new System.EventHandler(this.nieuweOfferteToolStripMenuItem_Click);
            // 
            // catalogPanel1
            // 
            this.catalogPanel1.AutoSize = true;
            this.catalogPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.catalogPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.catalogPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.catalogPanel1.catalogController = null;
            this.catalogPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.catalogPanel1.dp = null;
            this.catalogPanel1.Location = new System.Drawing.Point(805, 24);
            this.catalogPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.catalogPanel1.MinimumSize = new System.Drawing.Size(157, 393);
            this.catalogPanel1.Name = "catalogPanel1";
            this.catalogPanel1.Size = new System.Drawing.Size(211, 556);
            this.catalogPanel1.TabIndex = 4;
            // 
            // DesignPanel1
            // 
            this.DesignPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DesignPanel1.BackColor = System.Drawing.Color.Transparent;
            this.DesignPanel1.containsInactiveProduct = false;
            this.DesignPanel1.gPath = null;
            this.DesignPanel1.Location = new System.Drawing.Point(0, 24);
            this.DesignPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.DesignPanel1.Name = "DesignPanel1";
            this.DesignPanel1.rDesign = null;
            this.DesignPanel1.roomX = 0F;
            this.DesignPanel1.roomY = 0F;
            this.DesignPanel1.scale = 1F;
            this.DesignPanel1.Size = new System.Drawing.Size(803, 558);
            this.DesignPanel1.TabIndex = 3;
            // 
            // closeBox
            // 
            this.closeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeBox.BackgroundImage")));
            this.closeBox.Location = new System.Drawing.Point(980, 0);
            this.closeBox.Name = "closeBox";
            this.closeBox.Size = new System.Drawing.Size(36, 24);
            this.closeBox.TabIndex = 5;
            this.closeBox.TabStop = false;
            this.closeBox.Click += new System.EventHandler(this.closeBox_Click);
            this.closeBox.MouseLeave += new System.EventHandler(this.closeBox_MouseLeave);
            this.closeBox.MouseHover += new System.EventHandler(this.closeBox_MouseHover);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 580);
            this.Controls.Add(this.closeBox);
            this.Controls.Add(this.catalogPanel1);
            this.Controls.Add(this.DesignPanel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainView";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kantoorapplicatie";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nieuwToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bewerkbaarOpslaanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsImageToolStripMenuItem;
        private Views.DesignPanel DesignPanel1;
        private System.Windows.Forms.ToolStripMenuItem optiesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nieuwObjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nieuweOfferteToolStripMenuItem;
        private Views.CatalogPanel catalogPanel1;
        private System.Windows.Forms.PictureBox closeBox;
        private System.Windows.Forms.ToolStripMenuItem vormKiezenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vormZelfMakenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wisselNachtmodusToolStripMenuItem;
    }
}
