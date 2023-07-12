using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
        public partial class SignIn : Form
        {
            public SignIn()
            {
                InitializeComponent();
            }
            
            private void SignIn_Load(object sender, EventArgs e)
            {
           
            }
        private void Signinbutton_Click(object sender, EventArgs e)
            {
                string s = "";
                string n = "";
                string b = "";

                using (StreamReader sr = new StreamReader("TextFile1.Text"))
                {
                    while(sr.EndOfStream == false)
                    {
                        s = sr.ReadLine();
                        n = sr.ReadLine();
                       b = sr.ReadLine();
                    }
                }
                if (usernametxt.Text == s && passwordtxt.Text == n)
                {
                    Forms.full.Show();
                    this.Hide();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Username or Password is Invalid");
                    usernametxt.Text = "";
                    passwordtxt.Text = "";
                }

            }

            private void textBox2_TextChanged(object sender, EventArgs e)
            {
                
            }

           private void usernametxt_TextChanged(object sender, EventArgs e)
           {

           }

        private void Close_Window_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
