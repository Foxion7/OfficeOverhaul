﻿namespace KantoorApplicatie.Views
{
    partial class CustomerForm
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
            this.b_set = new System.Windows.Forms.Button();
            this.l_text = new System.Windows.Forms.Label();
            this.cb_customers = new System.Windows.Forms.ComboBox();
            this.b_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_set
            // 
            this.b_set.Location = new System.Drawing.Point(87, 238);
            this.b_set.Name = "b_set";
            this.b_set.Size = new System.Drawing.Size(75, 23);
            this.b_set.TabIndex = 0;
            this.b_set.Text = "Selecteer klant";
            this.b_set.UseVisualStyleBackColor = true;
            this.b_set.Click += new System.EventHandler(this.b_set_Click);
            // 
            // l_text
            // 
            this.l_text.AutoSize = true;
            this.l_text.Location = new System.Drawing.Point(84, 25);
            this.l_text.Name = "l_text";
            this.l_text.Size = new System.Drawing.Size(102, 13);
            this.l_text.TabIndex = 1;
            this.l_text.Text = "Selecteer een klant.";
            // 
            // cb_customers
            // 
            this.cb_customers.FormattingEnabled = true;
            this.cb_customers.Location = new System.Drawing.Point(87, 79);
            this.cb_customers.Name = "cb_customers";
            this.cb_customers.Size = new System.Drawing.Size(121, 21);
            this.cb_customers.TabIndex = 2;
            this.cb_customers.SelectedIndexChanged += new System.EventHandler(this.cb_customers_SelectedIndexChanged);
            // 
            // b_Cancel
            // 
            this.b_Cancel.Location = new System.Drawing.Point(200, 238);
            this.b_Cancel.Name = "b_Cancel";
            this.b_Cancel.Size = new System.Drawing.Size(75, 23);
            this.b_Cancel.TabIndex = 3;
            this.b_Cancel.Text = "Annuleer";
            this.b_Cancel.UseVisualStyleBackColor = true;
            this.b_Cancel.Click += new System.EventHandler(this.b_Cancel_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 314);
            this.Controls.Add(this.b_Cancel);
            this.Controls.Add(this.cb_customers);
            this.Controls.Add(this.l_text);
            this.Controls.Add(this.b_set);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klant selecteren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_set;
        private System.Windows.Forms.Label l_text;
        private System.Windows.Forms.ComboBox cb_customers;
        private System.Windows.Forms.Button b_Cancel;
    }
}