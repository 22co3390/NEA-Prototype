namespace WindowsFormsApp1
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.usernameBox = new System.Windows.Forms.GroupBox();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.GroupBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.Signinbutton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_Window = new System.Windows.Forms.Button();
            this.Maximize_Restore = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.usernameBox.SuspendLayout();
            this.passwordBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameBox
            // 
            this.usernameBox.Controls.Add(this.usernametxt);
            this.usernameBox.Font = new System.Drawing.Font("MS Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(74, 73);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(714, 77);
            this.usernameBox.TabIndex = 0;
            this.usernameBox.TabStop = false;
            this.usernameBox.Text = "Username";
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(25, 26);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(662, 27);
            this.usernametxt.TabIndex = 1;
            this.usernametxt.TextChanged += new System.EventHandler(this.usernametxt_TextChanged);
            // 
            // passwordBox
            // 
            this.passwordBox.Controls.Add(this.passwordtxt);
            this.passwordBox.Font = new System.Drawing.Font("MS Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(74, 189);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(714, 77);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.TabStop = false;
            this.passwordBox.Text = "Password";
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(25, 26);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(662, 27);
            this.passwordtxt.TabIndex = 2;
            this.passwordtxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Signinbutton
            // 
            this.Signinbutton.Font = new System.Drawing.Font("MS PGothic", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signinbutton.Location = new System.Drawing.Point(227, 303);
            this.Signinbutton.Name = "Signinbutton";
            this.Signinbutton.Size = new System.Drawing.Size(389, 86);
            this.Signinbutton.TabIndex = 2;
            this.Signinbutton.Text = "Sign In";
            this.Signinbutton.UseVisualStyleBackColor = true;
            this.Signinbutton.Click += new System.EventHandler(this.Signinbutton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.Maximize_Restore);
            this.panel1.Controls.Add(this.Close_Window);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 43);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Close_Window
            // 
            this.Close_Window.Image = ((System.Drawing.Image)(resources.GetObject("Close_Window.Image")));
            this.Close_Window.Location = new System.Drawing.Point(805, 9);
            this.Close_Window.Name = "Close_Window";
            this.Close_Window.Size = new System.Drawing.Size(30, 30);
            this.Close_Window.TabIndex = 5;
            this.Close_Window.Text = "X";
            this.Close_Window.UseVisualStyleBackColor = true;
            this.Close_Window.Click += new System.EventHandler(this.Close_Window_Click);
            // 
            // Maximize_Restore
            // 
            this.Maximize_Restore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maximize_Restore.Image = ((System.Drawing.Image)(resources.GetObject("Maximize_Restore.Image")));
            this.Maximize_Restore.Location = new System.Drawing.Point(770, 9);
            this.Maximize_Restore.Name = "Maximize_Restore";
            this.Maximize_Restore.Size = new System.Drawing.Size(30, 30);
            this.Maximize_Restore.TabIndex = 5;
            this.Maximize_Restore.Text = "+";
            this.Maximize_Restore.UseVisualStyleBackColor = true;
            // 
            // Minimize
            // 
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.Black;
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(735, 9);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(30, 30);
            this.Minimize.TabIndex = 6;
            this.Minimize.Text = "-";
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(844, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Signinbutton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.usernameBox.ResumeLayout(false);
            this.usernameBox.PerformLayout();
            this.passwordBox.ResumeLayout(false);
            this.passwordBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox usernameBox;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.GroupBox passwordBox;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Button Signinbutton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Close_Window;
        private System.Windows.Forms.Button Maximize_Restore;
        private System.Windows.Forms.Button Minimize;
    }
}