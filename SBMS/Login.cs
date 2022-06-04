using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBMS.Model;
using SBMS.BLL;

namespace SBMS
{
    public partial class Login : Form
    {
        LoginRegisterManager _registerManager = new LoginRegisterManager();
        Register register = new Register();

        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            register.UserName = usernameTextBox.Text;
            register.Password = passwordTextBox.Text;

            if (_registerManager.Login(register))
            {
                this.Hide();
                SBMSMDIParent sBMSMDIParent = new SBMSMDIParent();
                sBMSMDIParent.Show();
            }
            else
            {
                MessageBox.Show("Username or Password does not match..");
            }
        }
    }
}
