using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.IO.Pipes;
using System.Windows.Forms;
using FebAssess;

namespace WindowsFormsApp1
{

    public partial class Forms : Form
    {
        public static MainMenu mm = new MainMenu();
        public static CreateAccount ca = new CreateAccount();
        public static SignIn si = new SignIn();
        public static FullMenu full = new FullMenu();
        public static View_Progress v = new View_Progress();
        public static Task t = new Task(() => APIs.newMain());
        private void InitializeComponent()
        {
            this.SuspendLayout();

        }

        private void Forms_Load(object sender, EventArgs e)
        {

        }
    }
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
