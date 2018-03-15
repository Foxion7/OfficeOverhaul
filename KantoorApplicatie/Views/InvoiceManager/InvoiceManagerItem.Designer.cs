namespace KantoorApplicatie.Views.InvoiceManager
{
    partial class InvoiceManagerItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CustomerCompanyLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.InvoiceNumberLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomerCompanyLabel
            // 
            this.CustomerCompanyLabel.AutoSize = true;
            this.CustomerCompanyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerCompanyLabel.Location = new System.Drawing.Point(20, 23);
            this.CustomerCompanyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerCompanyLabel.Name = "CustomerCompanyLabel";
            this.CustomerCompanyLabel.Size = new System.Drawing.Size(194, 25);
            this.CustomerCompanyLabel.TabIndex = 0;
            this.CustomerCompanyLabel.Text = "[CustomerCompany]";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(792, 23);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(65, 25);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "[Date]";
            // 
            // InvoiceNumberLabel
            // 
            this.InvoiceNumberLabel.AutoSize = true;
            this.InvoiceNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceNumberLabel.Location = new System.Drawing.Point(715, 23);
            this.InvoiceNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InvoiceNumberLabel.Name = "InvoiceNumberLabel";
            this.InvoiceNumberLabel.Size = new System.Drawing.Size(93, 25);
            this.InvoiceNumberLabel.TabIndex = 3;
            this.InvoiceNumberLabel.Text = "[Number]";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(795, 72);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(107, 37);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Opslaan";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.Location = new System.Drawing.Point(20, 72);
            this.CustomerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(161, 25);
            this.CustomerNameLabel.TabIndex = 5;
            this.CustomerNameLabel.Text = "[CustomerName]";
            // 
            // InvoiceManagerItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.InvoiceNumberLabel);
            this.Controls.Add(this.CustomerCompanyLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InvoiceManagerItem";
            this.Size = new System.Drawing.Size(913, 121);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label CustomerCompanyLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label InvoiceNumberLabel;
        private System.Windows.Forms.Label CustomerNameLabel;
    }
}
