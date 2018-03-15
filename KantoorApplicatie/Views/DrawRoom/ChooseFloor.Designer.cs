﻿namespace KantoorApplicatie.Views
{
    partial class ChooseFloor
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
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.floorPanel = new System.Windows.Forms.Panel();
            this.priceLabel = new System.Windows.Forms.Label();
            this.floorTypeLabel = new System.Windows.Forms.Label();
            this.floorMaterialLabel = new System.Windows.Forms.Label();
            this.floorTypeComboBox = new System.Windows.Forms.ComboBox();
            this.floorMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.floorPictureBox = new System.Windows.Forms.PictureBox();
            this.floorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.floorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(25, 340);
            this.okBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(56, 19);
            this.okBtn.TabIndex = 0;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(320, 340);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(73, 19);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Annuleren";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // floorPanel
            // 
            this.floorPanel.BackColor = System.Drawing.Color.Transparent;
            this.floorPanel.Controls.Add(this.priceLabel);
            this.floorPanel.Controls.Add(this.floorTypeLabel);
            this.floorPanel.Controls.Add(this.floorMaterialLabel);
            this.floorPanel.Controls.Add(this.floorTypeComboBox);
            this.floorPanel.Controls.Add(this.floorMaterialComboBox);
            this.floorPanel.Controls.Add(this.floorPictureBox);
            this.floorPanel.Location = new System.Drawing.Point(25, 169);
            this.floorPanel.Name = "floorPanel";
            this.floorPanel.Size = new System.Drawing.Size(368, 127);
            this.floorPanel.TabIndex = 16;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(129, 84);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(0, 13);
            this.priceLabel.TabIndex = 6;
            // 
            // floorTypeLabel
            // 
            this.floorTypeLabel.AutoSize = true;
            this.floorTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floorTypeLabel.Location = new System.Drawing.Point(3, 63);
            this.floorTypeLabel.Name = "floorTypeLabel";
            this.floorTypeLabel.Size = new System.Drawing.Size(36, 15);
            this.floorTypeLabel.TabIndex = 5;
            this.floorTypeLabel.Text = "Soort";
            // 
            // floorMaterialLabel
            // 
            this.floorMaterialLabel.AutoSize = true;
            this.floorMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floorMaterialLabel.Location = new System.Drawing.Point(3, 14);
            this.floorMaterialLabel.Name = "floorMaterialLabel";
            this.floorMaterialLabel.Size = new System.Drawing.Size(90, 15);
            this.floorMaterialLabel.TabIndex = 4;
            this.floorMaterialLabel.Text = "Vloer materiaal";
            // 
            // floorTypeComboBox
            // 
            this.floorTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.floorTypeComboBox.FormattingEnabled = true;
            this.floorTypeComboBox.Location = new System.Drawing.Point(4, 81);
            this.floorTypeComboBox.Name = "floorTypeComboBox";
            this.floorTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.floorTypeComboBox.TabIndex = 3;
            this.floorTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.floorTypeComboBox_SelectedIndexChanged);
            // 
            // floorMaterialComboBox
            // 
            this.floorMaterialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.floorMaterialComboBox.FormattingEnabled = true;
            this.floorMaterialComboBox.Location = new System.Drawing.Point(4, 30);
            this.floorMaterialComboBox.Name = "floorMaterialComboBox";
            this.floorMaterialComboBox.Size = new System.Drawing.Size(121, 21);
            this.floorMaterialComboBox.TabIndex = 2;
            this.floorMaterialComboBox.SelectedIndexChanged += new System.EventHandler(this.floorMaterialComboBox_SelectedIndexChanged);
            // 
            // floorPictureBox
            // 
            this.floorPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.floorPictureBox.Location = new System.Drawing.Point(230, 0);
            this.floorPictureBox.Name = "floorPictureBox";
            this.floorPictureBox.Size = new System.Drawing.Size(128, 127);
            this.floorPictureBox.TabIndex = 1;
            this.floorPictureBox.TabStop = false;
            // 
            // ChooseFloor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 379);
            this.Controls.Add(this.floorPanel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseFloor";
            this.Text = "Vloer selecteren";
            this.floorPanel.ResumeLayout(false);
            this.floorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.floorPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Panel floorPanel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label floorTypeLabel;
        private System.Windows.Forms.Label floorMaterialLabel;
        private System.Windows.Forms.ComboBox floorTypeComboBox;
        private System.Windows.Forms.ComboBox floorMaterialComboBox;
        private System.Windows.Forms.PictureBox floorPictureBox;
    }
}