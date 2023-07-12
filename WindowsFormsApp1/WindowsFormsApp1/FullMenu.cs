using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using FebAssess;

namespace WindowsFormsApp1
{
    public partial class FullMenu : Form
    {
        public FullMenu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.MinimizeBox = false;
            this.AutoScroll = true;
            int locationv = 0;
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = new Button();
                b[i].Name = bw[i];
                b[i].Text = bw[i];
                b[i].Location = new Point((this.Width / 2 - 100) +locationv, 50);
                b[i].Size = new Size(120, 75);
                b[i].Font = new Font(Forms.si.Font, FontStyle.Bold);

                locationv += 200;
            }
           
                foreach (Button l in b)
                {
                    l.Click += this.Button_Click;
                }
        }


        static Button[] b = new Button[4];
        static List<FlowLayoutPanel> f = new List<FlowLayoutPanel>();
        string[] bw= {"Randomiser", "Access Custom Recommendation", "View Porgres", "Input BMI"};
        private void Button_Click(object sender, EventArgs e)
        {
            Button l = sender as Button;

            if(l != null && bw.Contains(l.Text))
            {
                if(l.Text == bw[0])
                {
                    foreach(Button v in b)
                    {
                       v.Visible = false;
                    }
                    Open_FlowLayoutPanel();
                }
                else if(l.Text == bw[1])
                {
                    foreach (Button v in b)
                    {
                        v.Visible = false;
                    }
                }
                else if(l.Text == bw[2])
                {
                    this.Hide();
                    Forms.v.Show();
                }
                
            }
        }
        private void Open_FlowLayoutPanel()
        {
            Forms.t.Wait();
            int numx = 0;
            int numy = 0;
            for(int i = 0; i < 30; i++)
            {
                FlowLayoutPanel p = new FlowLayoutPanel();
                p.Visible= true;
                p.BackColor = Color.White;
                p.Size = new Size(239, 262);
                p.Location = new Point(numx + 12, numy + 12);
                if (p.Location.X > 1000)
                {
                    numy += 290;
                    numx = 0;
                }
                else
                {
                    numx += 250;
                }
                f.Add(p);
            }
            for(int i = 0; i<30; i++)
            {
                PictureBox p = new PictureBox();
                p.Size = new Size(200, 140);
                p.Location = new Point(15, 15);
                p.SizeMode = PictureBoxSizeMode.Zoom;
                string j = APIs.GetImage(i);
                using (WebClient wc = new WebClient())
                {
                    do
                    {
                        try
                        {
                            byte[] ib = wc.DownloadData(j);
                            using (var ms = new System.IO.MemoryStream(ib))
                            {
                                p.Image = Image.FromStream(ms);
                            }
                        }
                        catch
                        {
                            Random r= new Random();
                            j = APIs.GetImage(r.Next(30, 120));
                        }
                    } while (p.Image == null);
                }
                    f[i].Controls.Add(p);
                
               
            }
            for(int i =0; i<30; i++)
            {
                Label l = new Label();
                l.Size = new Size(220, 90);
                l.Location = new Point(15, 170);
                l.Text = APIs.GetText(i);
                f[i].Controls.Add(l);
                this.Controls.Add(f[i]);
            }
            
        }
        

        private void FullMenu_Load(object sender, EventArgs e)
        {

            for(int i = 0; i < b.Length; i++)
            {
                this.Controls.Add(b[i]);    
            }
            Close_Window.Location = new Point(this.Width-41, (panel1.Height/2)-10);
            Maximize_Restore.Location = new Point(this.Width -77, (panel1.Height / 2) - 10);
            Minimize.Location = new Point(this.Width - 113, (panel1.Height / 2) - 10);
            panel1.Width = this.Width;
        }

        private void Maximize_Restore_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
    }
}