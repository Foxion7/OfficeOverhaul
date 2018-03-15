namespace KantoorApplicatie.Views.Themeforms
{
    partial class ThemeImageFormSave
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
            this.b_Save = new System.Windows.Forms.Button();
            this.b_Cancel = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.cb_themes = new System.Windows.Forms.ComboBox();
            this.l_name = new System.Windows.Forms.Label();
            this.l_theme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_Save
            // 
            this.b_Save.Location = new System.Drawing.Point(160, 44);
            this.b_Save.Name = "b_Save";
            this.b_Save.Size = new System.Drawing.Size(75, 23);
            this.b_Save.TabIndex = 0;
            this.b_Save.Text = "Opslaan";
            this.b_Save.UseVisualStyleBackColor = true;
            this.b_Save.Click += new System.EventHandler(this.b_Save_Click);
            // 
            // b_Cancel
            // 
            this.b_Cancel.Location = new System.Drawing.Point(160, 121);
            this.b_Cancel.Name = "b_Cancel";
            this.b_Cancel.Size = new System.Drawing.Size(75, 23);
            this.b_Cancel.TabIndex = 1;
            this.b_Cancel.Text = "Annuleer";
            this.b_Cancel.UseVisualStyleBackColor = true;
            this.b_Cancel.Click += new System.EventHandler(this.b_Cancel_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(23, 44);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 20);
            this.tb_name.TabIndex = 2;
            // 
            // cb_themes
            // 
            this.cb_themes.FormattingEnabled = true;
            this.cb_themes.Location = new System.Drawing.Point(23, 121);
            this.cb_themes.Name = "cb_themes";
            this.cb_themes.Size = new System.Drawing.Size(121, 21);
            this.cb_themes.TabIndex = 3;
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Location = new System.Drawing.Point(20, 9);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(147, 13);
            this.l_name.TabIndex = 4;
            this.l_name.Text = "Geef de afbeelding een naam";
            // 
            // l_theme
            // 
            this.l_theme.AutoSize = true;
            this.l_theme.Location = new System.Drawing.Point(20, 92);
            this.l_theme.Name = "l_theme";
            this.l_theme.Size = new System.Drawing.Size(83, 13);
            this.l_theme.TabIndex = 5;
            this.l_theme.Text = "Kies een thema.";
            // 
            // ThemeImageFormSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.l_theme);
            this.Controls.Add(this.l_name);
            this.Controls.Add(this.cb_themes);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.b_Cancel);
            this.Controls.Add(this.b_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemeImageFormSave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thema opslaan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Save;
        private System.Windows.Forms.Button b_Cancel;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.ComboBox cb_themes;
        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.Label l_theme;
    }
}