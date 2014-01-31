using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace BookStore
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UtiliatorBL function = new UtiliatorBL();
            int x=function.login(tbUser.Text, tbParola.Text);

            if (x != 0)
            {
                MessageBox.Show("e ok");
                Program.logged = true;
                this.Close();                       
            }
            else
            {
                MessageBox.Show("nu-i ok");
                Program.logged = false; 
            }
        }
    }
}
