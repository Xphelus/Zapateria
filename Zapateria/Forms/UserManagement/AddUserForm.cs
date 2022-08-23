using Zapateria.Code;

namespace Zapateria.Forms.UserManagement
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var userId = userIdTextBox.Text;
            var userName = userNameTextBox.Text;
            var password = passwordTextBox.Text;
            var isAdmin = adminCheckBox.Checked;

            // Ninguno de estos campos puede ser null en la base de datos
            if (userId is null or "" || userName is null or "" || password is null or "")
                return;

            // Manda los datos de las cajas al Servicio para que intente crear un usuario.
            var success = LoginService.CreateUser(userId, userName, password, isAdmin);

            if (!success)
                MessageBox.Show(@"Error: Could not create user.");
        }
    }
}
