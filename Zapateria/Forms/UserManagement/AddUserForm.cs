using Zapateria.Code;

namespace Zapateria.Forms.UserManagement
{
    public partial class AddUserForm : Form
    {
        private readonly MainForm _parentInstance;

        public AddUserForm(MainForm parentInstance)
        {
            _parentInstance = parentInstance;
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

            if (success)
            {
                var adminForm = new AdminForm(_parentInstance);

                _parentInstance.ShowForm(adminForm);
                Close();
            }
            else
                MessageBox.Show(@"Error: Could not create user.");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var adminForm = new AdminForm(_parentInstance);

            _parentInstance.ShowForm(adminForm);
            Close();
        }
    }
}
