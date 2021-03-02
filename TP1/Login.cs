using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Login : Form
    {
        private Auth auth;
        public Login()
        {
            InitializeComponent();
            this.auth = new Auth();
            this.DialogResult = DialogResult.Abort;
            tb_password.UseSystemPasswordChar = true;
        }

        private void bt_loginPress(object sender, EventArgs e)
        {
            if (this.auth.authenticate(this.tb_username.Text, this.tb_password.Text))
                this.DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Wrong password or username!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
