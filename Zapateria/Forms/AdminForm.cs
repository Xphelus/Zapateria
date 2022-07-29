using Zapateria.Code;
using Zapateria.Forms.UserManagement;

namespace Zapateria.Forms
{
    public partial class AdminForm : Form
    {
        private readonly MainForm _parentInstance;

        public AdminForm(MainForm parentInstance)
        {
            _parentInstance = parentInstance;
            InitializeComponent();

            CollapseMenus();
        }

        private void ViewUserButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ToggleTable();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // TODO: Abrir add user en el sidepanel en lugar del main form.

            var addUser = new AddUserForm(_parentInstance);
            _parentInstance.ShowForm(addUser);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            // TODO: Abrir edit user en el sidepanel en lugar del main form.

            var editUser = new EditUserForm(_parentInstance);

            _parentInstance.ShowForm(editUser);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // TODO: Abrir delete user en el sidepanel en lugar del main form.
            
            var deleteUser = new DeleteUserForm(_parentInstance);
            _parentInstance.ShowForm(deleteUser);
        }

        private void ToggleTable()
        {
            if (dataGrid.Visible)
            {
                dataGrid.Visible = false;
                mainPanel.Controls.Clear();
            }
            else
            {
                // Consigue la tabla de Users entera de la base de datos.
                var service = new DataService();
                var dt = service.RetrieveDataTable("SELECT * from Users");

                // Enseña la tabla por medio del DataGridView
                dataGrid.DataSource = new BindingSource(dt, null);

                mainPanel.Controls.Add(dataGrid);

                dataGrid.Visible = true;
            }
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            var login = new LoginForm(_parentInstance);

            _parentInstance.ShowForm(login);
            Close();
        }

        private void AdminMenuButton_Click(object sender, EventArgs e)
        {
            ToggleSubmenu(adminSubmenu);
        }

        private void CollapseMenus()
        {
            adminSubmenu.Visible = false;
        }

        private void ToggleSubmenu(Control submenu)
        {
            if (!submenu.Visible)
            {
                CollapseMenus();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
    }
}
