using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            string filename = "TextFile1.Text";

            using(StreamWriter sw = File.AppendText(filename))
            {
                sw.WriteLine(usernametxt.Text);
                sw.WriteLine(passwordtxt.Text);
                sw.WriteLine(comboBoxmob.Text);
            }

            MessageBox.Show("Account Created");
            Close();
            Forms.mm.Show();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            Close();
            Forms.mm.Show();
        }

        private void Close_Window_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
