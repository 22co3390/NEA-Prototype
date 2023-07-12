namespace WindowsFormsApp1
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.usernameBox = new System.Windows.Forms.GroupBox();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.GroupBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.MonthBox = new System.Windows.Forms.GroupBox();
            this.comboBoxmob = new System.Windows.Forms.ComboBox();
            this.Or = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Maximize_Restore = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.Close_Window = new System.Windows.Forms.Button();
            this.usernameBox.SuspendLayout();
            this.passwordBox.SuspendLayout();
            this.MonthBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameBox
            // 
            this.usernameBox.Controls.Add(this.usernametxt);
            this.usernameBox.Font = new System.Drawing.Font("MS Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(104, 59);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(711, 70);
            this.usernameBox.TabIndex = 0;
            this.usernameBox.TabStop = false;
            this.usernameBox.Text = "Username";
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(28, 26);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(638, 27);
            this.usernametxt.TabIndex = 1;
            this.usernametxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passwordBox
            // 
            this.passwordBox.Controls.Add(this.passwordtxt);
            this.passwordBox.Font = new System.Drawing.Font("MS Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(104, 147);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(711, 70);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.TabStop = false;
            this.passwordBox.Text = "Password";
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(28, 26);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(638, 27);
            this.passwordtxt.TabIndex = 0;
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("MS PGothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.Location = new System.Drawing.Point(252, 310);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(368, 53);
            this.CreateButton.TabIndex = 2;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // MonthBox
            // 
            this.MonthBox.Controls.Add(this.comboBoxmob);
            this.MonthBox.Font = new System.Drawing.Font("MS PGothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthBox.Location = new System.Drawing.Point(104, 223);
            this.MonthBox.Name = "MonthBox";
            this.MonthBox.Size = new System.Drawing.Size(711, 70);
            this.MonthBox.TabIndex = 3;
            this.MonthBox.TabStop = false;
            this.MonthBox.Text = "Month of birth";
            // 
            // comboBoxmob
            // 
            this.comboBoxmob.FormattingEnabled = true;
            this.comboBoxmob.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBoxmob.Location = new System.Drawing.Point(28, 36);
            this.comboBoxmob.Name = "comboBoxmob";
            this.comboBoxmob.Size = new System.Drawing.Size(638, 28);
            this.comboBoxmob.TabIndex = 4;
            // 
            // Or
            // 
            this.Or.AutoSize = true;
            this.Or.Font = new System.Drawing.Font("MS PGothic", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Or.Location = new System.Drawing.Point(405, 377);
            this.Or.Name = "Or";
            this.Or.Size = new System.Drawing.Size(60, 33);
            this.Or.TabIndex = 4;
            this.Or.Text = "OR";
            // 
            // MainMenu
            // 
            this.MainMenu.Font = new System.Drawing.Font("MS PGothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.Location = new System.Drawing.Point(252, 427);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(368, 53);
            this.MainMenu.TabIndex = 5;
            this.MainMenu.Text = "MainMenu";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
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
            this.panel1.Size = new System.Drawing.Size(876, 43);
            this.panel1.TabIndex = 6;
            // 
            // Maximize_Restore
            // 
            this.Maximize_Restore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maximize_Restore.Image = ((System.Drawing.Image)(resources.GetObject("Maximize_Restore.Image")));
            this.Maximize_Restore.Location = new System.Drawing.Point(794, 8);
            this.Maximize_Restore.Name = "Maximize_Restore";
            this.Maximize_Restore.Size = new System.Drawing.Size(30, 30);
            this.Maximize_Restore.TabIndex = 4;
            this.Maximize_Restore.Text = "+";
            this.Maximize_Restore.UseVisualStyleBackColor = true;
            // 
            // Minimize
            // 
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.Black;
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(758, 8);
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
            this.Close_Window.Location = new System.Drawing.Point(830, 8);
            this.Close_Window.Name = "Close_Window";
            this.Close_Window.Size = new System.Drawing.Size(30, 30);
            this.Close_Window.TabIndex = 4;
            this.Close_Window.Text = "X";
            this.Close_Window.UseVisualStyleBackColor = true;
            this.Close_Window.Click += new System.EventHandler(this.Close_Window_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(876, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Or);
            this.Controls.Add(this.MonthBox);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            this.usernameBox.ResumeLayout(false);
            this.usernameBox.PerformLayout();
            this.passwordBox.ResumeLayout(false);
            this.passwordBox.PerformLayout();
            this.MonthBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox usernameBox;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.GroupBox passwordBox;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.GroupBox MonthBox;
        private System.Windows.Forms.ComboBox comboBoxmob;
        private System.Windows.Forms.Label Or;
        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Maximize_Restore;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Close_Window;
    }
}