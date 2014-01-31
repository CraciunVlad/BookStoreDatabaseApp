using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Main : Form
    {
        public Main()
        {
           InitializeComponent();           
           tbID.Text="Please login";           
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login fr = new Login();
            fr.ShowDialog();
            if (Program.logged == true)
            {
                btnGo.Enabled = true;
                tbID.Text = "Hello, ";
            }
            else
            {
                btnGo.Enabled = false;
                tbID.Text = "Please login";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BookStore v.1\n\nDeveloped by:\n\tCraciun Vlad\n\tRadu Ionut");
        }
    }
}
