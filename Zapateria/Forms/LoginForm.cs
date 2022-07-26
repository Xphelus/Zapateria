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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*private void createButton_Click(object sender, EventArgs e)
        {
            var username = userTextBox.Text;
            var password = passTextBox.Text;

            // En caso de que alguna de las dos cajas estén vacías.
            if (username.Equals("") || password.Equals(""))
            {
                MessageBox.Show(@"Please fill in both boxes.");
                return;
            }

            // Manda a crear el usuario en la base de datos y contesta de forma acorde.
            MessageBox.Show(LoginService.CreateUser(username, "", password, false)
                ? @"USER CREATION SUCCESSFUL"
                : @"USER CREATION FAILED");
        } */

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var username = userTextBox.Text;
            var password = passTextBox.Text;

            // Manda a autenticar al usuario con LoginService. Abre el menú principal si se logeó correctamente.
            if (LoginService.Authenticate(username, password))
            {
                if (LoginService.IsUserAdmin(username))
                {
                    _parentInstance.ShowAdminForm();
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
    }
}