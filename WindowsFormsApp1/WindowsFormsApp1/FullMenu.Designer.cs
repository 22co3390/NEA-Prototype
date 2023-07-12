namespace WindowsFormsApp1
{
    partial class FullMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FullMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Maximize_Restore = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.Close_Window = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.Maximize_Restore);
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.Close_Window);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 43);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Maximize_Restore
            // 
            this.Maximize_Restore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maximize_Restore.Image = ((System.Drawing.Image)(resources.GetObject("Maximize_Restore.Image")));
            this.Maximize_Restore.Location = new System.Drawing.Point(902, 8);
            this.Maximize_Restore.Name = "Maximize_Restore";
            this.Maximize_Restore.Size = new System.Drawing.Size(30, 30);
            this.Maximize_Restore.TabIndex = 4;
            this.Maximize_Restore.Text = "+";
            this.Maximize_Restore.UseVisualStyleBackColor = true;
            this.Maximize_Restore.Click += new System.EventHandler(this.Maximize_Restore_Click);
            // 
            // Minimize
            // 
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.Black;
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(866, 8);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(30, 30);
            this.Minimize.TabIndex = 5;
            this.Minimize.Text = "-";
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Close_Window
            // 
            this.Close_Window.Image = ((System.Drawing.Image)(resources.GetObject("Close_Window.Image")));
            this.Close_Window.Location = new System.Drawing.Point(938, 8);
            this.Close_Window.Name = "Close_Window";
            this.Close_Window.Size = new System.Drawing.Size(30, 30);
            this.Close_Window.TabIndex = 4;
            this.Close_Window.Text = "X";
            this.Close_Window.UseVisualStyleBackColor = true;
            this.Close_Window.Click += new System.EventHandler(this.Close_Window_Click);
            // 
            // FullMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(993, 597);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FullMenu";
            this.ShowInTaskbar = false;
            this.Text = "FullMenu";
            this.Load += new System.EventHandler(this.FullMenu_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Maximize_Restore;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Close_Window;
    }
}