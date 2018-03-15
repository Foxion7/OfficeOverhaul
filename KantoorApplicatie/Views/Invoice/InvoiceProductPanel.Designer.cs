namespace KantoorApplicatie.Views {
    partial class InvoiceProductPanel {
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
            this.typeLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.singlePriceLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(3, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(58, 18);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "[Name]";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(3, 18);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(37, 13);
            this.typeLabel.TabIndex = 1;
            this.typeLabel.Text = "[Type]";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(200, 2);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(50, 13);
            this.numberLabel.TabIndex = 2;
            this.numberLabel.Text = "[Number]";
            // 
            // singlePriceLabel
            // 
            this.singlePriceLabel.AutoSize = true;
            this.singlePriceLabel.Location = new System.Drawing.Point(364, 2);
            this.singlePriceLabel.Name = "singlePriceLabel";
            this.singlePriceLabel.Size = new System.Drawing.Size(68, 13);
            this.singlePriceLabel.TabIndex = 3;
            this.singlePriceLabel.Text = "[Single price]";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(522, 2);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(63, 13);
            this.totalPriceLabel.TabIndex = 4;
            this.totalPriceLabel.Text = "[Total price]";
            // 
            // InvoiceProductPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.singlePriceLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "InvoiceProductPanel";
            this.Size = new System.Drawing.Size(607, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label singlePriceLabel;
        private System.Windows.Forms.Label totalPriceLabel;
    }
}
