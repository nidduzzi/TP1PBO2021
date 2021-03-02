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
    public partial class App : Form
    {
        private Login login;
        private MainMenu mainMenu;
        public App()
        {
            InitializeComponent();
            this.login = new Login();
            this.mainMenu = new MainMenu();
        }

        private void app_loaded(object sender, EventArgs e)
        {
            if (this.login.ShowDialog(this) == DialogResult.OK)
                mainMenu.ShowDialog(this);
            this.Close();
        }
    }
}
