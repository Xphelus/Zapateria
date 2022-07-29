using Zapateria.Code;

namespace Zapateria.Forms
{
    public partial class LoginForm : Form
    {
        private readonly MainForm _parentInstance;

        public LoginForm(MainForm parentInstance)
        {
            InitializeComponent();
            _parentInstance = parentInstance;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var username = userTextBox.Text;
            var password = passTextBox.Text;

            // Manda a autenticar al usuario con LoginService. Abre el menú principal si se logeó correctamente.
            if (LoginService.Authenticate(username, password))
            {
                // Cierra el login form y abre el form que corresponda.
                if (LoginService.IsUserAdmin(username))
                {
                    var adminForm = new AdminForm(_parentInstance);

                    _parentInstance.ShowForm(adminForm);
                }
                else
                {
                    // TODO: Open user menu
                }
            }
            else
                MessageBox.Show(owner: this,@"LOGIN FAILED");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            _parentInstance.Close();
        }

        private void PassTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoginButton_Click(sender, e);
        }
    }
}