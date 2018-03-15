namespace KantoorApplicatie.Views
{
    partial class RoomMaker
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
            this.restartButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.undoLast = new System.Windows.Forms.Button();
            this.btnFloor = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(4, 55);
            this.restartButton.Margin = new System.Windows.Forms.Padding(4);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(128, 44);
            this.restartButton.TabIndex = 0;
            this.restartButton.Text = "Opnieuw beginnen";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            this.restartButton.MouseHover += new System.EventHandler(this.restartButton_MouseHover);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(4, 20);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(128, 28);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Opslaan";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            this.saveButton.MouseHover += new System.EventHandler(this.saveButton_MouseHover);
            // 
            // undoLast
            // 
            this.undoLast.Location = new System.Drawing.Point(5, 107);
            this.undoLast.Margin = new System.Windows.Forms.Padding(4);
            this.undoLast.Name = "undoLast";
            this.undoLast.Size = new System.Drawing.Size(127, 42);
            this.undoLast.TabIndex = 2;
            this.undoLast.Text = "Ongedaan maken";
            this.undoLast.UseVisualStyleBackColor = true;
            this.undoLast.Click += new System.EventHandler(this.undoLast_Click);
            this.undoLast.MouseHover += new System.EventHandler(this.undoLast_MouseHover);
            // 
            // btnFloor
            // 
            this.btnFloor.Location = new System.Drawing.Point(5, 156);
            this.btnFloor.Name = "btnFloor";
            this.btnFloor.Size = new System.Drawing.Size(127, 34);
            this.btnFloor.TabIndex = 3;
            this.btnFloor.Text = "Vloer kiezen";
            this.btnFloor.UseVisualStyleBackColor = true;
            this.btnFloor.Click += new System.EventHandler(this.btnFloor_Click);
            this.btnFloor.MouseHover += new System.EventHandler(this.fillButton_MouseHover);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(5, 196);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(127, 23);
            this.btnColor.TabIndex = 4;
            this.btnColor.Text = "Kleur kiezen";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            this.btnColor.MouseHover += new System.EventHandler(this.btnColor_MouseHover);
            // 
            // RoomMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnFloor);
            this.Controls.Add(this.undoLast);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.restartButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoomMaker";
            this.Size = new System.Drawing.Size(1183, 559);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RoomMaker_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button undoLast;
        private System.Windows.Forms.Button btnFloor;
        private System.Windows.Forms.Button btnColor;
    }
}
