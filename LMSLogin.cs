using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class LMSLogin : Form
    {
        public LMSLogin()
        {
            InitializeComponent();
        }

        private void subLogin_Click(object sender, EventArgs e)
        {
            LMSMainForAdmin adminMain = new LMSMainForAdmin();
            if (txtUsername.Text.Equals("admin") && txtPassword.Text.Equals("admin"))
            {
                adminMain.Visible = true;
                adminMain.menuBorrower.Visible = true;
                this.Visible = false;
            }
            else if (txtUsername.Text.Equals(txtPassword.Text))
            {
                adminMain.Visible = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Kindly enter valid usesname/password");
            }
        }
    }
}
