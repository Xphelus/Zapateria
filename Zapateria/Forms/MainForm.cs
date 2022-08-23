using Zapateria.Forms.ClerkForms;
using Zapateria.Forms.UserManagement;

namespace Zapateria.Forms
{
    public partial class MainForm : Form
    {
        // Una referencia al Main Form que contiene a todos los otros controls.
        private readonly ContainerForm _parentInstance;

        public MainForm(ContainerForm parentInstance, bool adminEnabled)
        {
            _parentInstance = parentInstance;
            InitializeComponent();

            adminMenuButton.Enabled = adminEnabled;
            usernameLabel.Text = ContainerForm.Username;

            // Cierra todos los menus para que la ventana aparezca limpia
            CollapseMenus();
        }

        private void ViewUserButton_Click(object sender, EventArgs e)
        {
            // Revisa si el form estaba abierto para solo cerrarlo y terminar la función.
            if (FormWasOpen<ViewUserForm>())
                return;

            // Si el form no estaba abierto, lo muestra en pantalla.
            var viewUsers = new ViewUserForm();
            ShowForm(viewUsers);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Revisa si el form estaba abierto para solo cerrarlo y terminar la función.
            if (FormWasOpen<AddUserForm>())
                return;

            // Si el form no estaba abierto, lo muestra en pantalla.
            var addUser = new AddUserForm();
            ShowForm(addUser);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            // Revisa si el form estaba abierto para solo cerrarlo y terminar la función.
            if (FormWasOpen<EditUserForm>())
                return;

            // Si el form no estaba abierto, lo muestra en pantalla.
            var editUser = new EditUserForm();
            ShowForm(editUser);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Revisa si el form estaba abierto para solo cerrarlo y terminar la función.
            if (FormWasOpen<DeleteUserForm>())
                return;

            // Si el form no estaba abierto, lo muestra en pantalla.
            var deleteUser = new DeleteUserForm();
            ShowForm(deleteUser);
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            // Revisa si el form estaba abierto para solo cerrarlo y terminar la función.
            if (FormWasOpen<InvForm>())
                return;

            // Si el form no estaba abierto, lo muestra en pantalla.
            var inventory = new InvForm();
            ShowForm(inventory);
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            // Revisa si el form estaba abierto para solo cerrarlo y terminar la función.
            if (FormWasOpen<MainOrderForm>())
                return;

            // Si el form no estaba abierto, lo muestra en pantalla.
            var order = new MainOrderForm();
            ShowForm(order);
        }

        private void ReceiptsButton_Click(object sender, EventArgs e)
        {
            // Revisa si el form estaba abierto para solo cerrarlo y terminar la función.
            if (FormWasOpen<MainReceiptsForm>())
                return;

            // Si el form no estaba abierto, lo muestra en pantalla.
            var receipts = new MainReceiptsForm();
            ShowForm(receipts);
        }

        private bool FormWasOpen<T>()
        {
            // Revisa si el form activo es del mismo tipo que el genérico T. Si no es así, retorna falso para que se muestre.
            if (_activeForm is not T) return false;

            // Si sí era del mismo tipo, hace invisible y nullifica al form activo actual, y enseña el logo de la empresa.
            paylessLogo.Visible = true;
            _activeForm.Visible = false;
            _activeForm = null;

            return true;
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
            mainSubmenu.Visible = false;
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

        // Ve qué Form está activo en el panel container de la derecha.
        private Form? _activeForm;
        public void ShowForm(Form childForm)
        {
            // Si el form no es null, lo cierra y lo reemplaza con el parámetro de este método.
            _activeForm?.Close();
            _activeForm = childForm;

            // Le damos las propiedades para que se acomode al panel container.
            childForm.Dock = DockStyle.Fill;
            childForm.TopLevel = false;
            childForm.TopMost = true;
            childForm.FormBorderStyle = FormBorderStyle.None;

            // Lo añadimos y lo mostramos, hacemos la foto de Payless invisible.
            paylessLogo.Visible = false;
            mainPanel.Controls.Add(childForm);
            childForm.Show();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            ToggleSubmenu(mainSubmenu);
        }

    }
}
