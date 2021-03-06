using System;
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
            bool enteredMenu = false;
            do
            {
                enteredMenu = false;
                if (this.login.ShowDialog(this) == DialogResult.OK)
                {
                    mainMenu.ShowDialog(this);
                    enteredMenu = true;
                }
            } while (enteredMenu);
            this.Close();
        }
    }
}
