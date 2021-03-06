using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
namespace TP1
{
    public partial class App : MaterialForm
    {
        private Login login;
        private MainMenu mainMenu;
        public App()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.Grey900, Primary.DeepOrange800, Accent.LightBlue200, TextShade.WHITE);
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
