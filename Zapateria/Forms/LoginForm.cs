using Zapateria.Code;

namespace Zapateria.Forms
{
    public partial class LoginForm : Form
    {
        private readonly ContainerForm _parentInstance;

        public LoginForm(ContainerForm parentInstance)
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
                ContainerForm.Username = username;

                // Cierra el login form y abre el form que corresponde. Habilita o desabilita el botón de administrador dependiendo de los permisos del usuario.
                var isAdmin = LoginService.IsUserAdmin(username);

                var menuForm = new MainForm(_parentInstance, isAdmin);

                _parentInstance.ShowForm(menuForm);
            }
            else
                MessageBox.Show(owner: this,@"Login Failed: Check your credentials and try again.");
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