namespace KantoorApplicatie.Views
{
    partial class RotatePanel
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
            this.components = new System.ComponentModel.Container();
            this.LeftButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LeftButton
            // 
            this.LeftButton.Location = new System.Drawing.Point(0, 2);
            this.LeftButton.Margin = new System.Windows.Forms.Padding(2);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(21, 19);
            this.LeftButton.TabIndex = 0;
            this.LeftButton.Text = "<";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftButton_MouseDown);
            this.LeftButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.LeftButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.LeftButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftButton_MouseUp);
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(51, 2);
            this.RightButton.Margin = new System.Windows.Forms.Padding(2);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(20, 19);
            this.RightButton.TabIndex = 1;
            this.RightButton.Text = ">";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightButton_MouseDown);
            this.RightButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.RightButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.RightButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightButton_MouseUp);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(26, 2);
            this.Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(21, 19);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "X";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            this.Delete.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.Delete.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RotatePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.LeftButton);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RotatePanel";
            this.Size = new System.Drawing.Size(76, 26);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Timer timer1;
    }
}
