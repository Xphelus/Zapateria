using Zapateria.Forms.UserManagement;

namespace Zapateria.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            ShowLoginForm();
        }

        public void ShowLoginForm()
        {
            pContainer.Controls.Clear();

            var loginForm = new LoginForm(this)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,

                FormBorderStyle = FormBorderStyle.None
            };

            pContainer.Controls.Add(loginForm);
            loginForm.Show();
        }

        public void ShowAdminForm()
        {
            pContainer.Controls.Clear();

            var adminForm = new AdminForm(this)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,

                FormBorderStyle = FormBorderStyle.None
            };

            pContainer.Controls.Add(adminForm);
            adminForm.Show();
        }

        public void ShowAddUserForm()
        {
            pContainer.Controls.Clear();

            var addUserForm = new AddUserForm(this)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,

                FormBorderStyle = FormBorderStyle.None
            };

            pContainer.Controls.Add(addUserForm);
            addUserForm.Show();
        }

        public void ShowDeleteUserForm()
        {
            pContainer.Controls.Clear();

            var deleteUserForm = new DeleteUserForm(this)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,

                FormBorderStyle = FormBorderStyle.None
            };

            pContainer.Controls.Add(deleteUserForm);
            deleteUserForm.Show();
        }

        public void ShowEditUserForm()
        {
            pContainer.Controls.Clear();

            var editUserForm = new EditUserForm(this)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,

                FormBorderStyle = FormBorderStyle.None
            };

            pContainer.Controls.Add(editUserForm);
            editUserForm.Show();
        }
    }
}
