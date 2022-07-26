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

            RefreshTable();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _parentInstance.ShowAddUserForm();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _parentInstance.ShowDeleteUserForm();
        }

        private void RefreshTable()
        {
            // Consigue la tabla de Users entera de la base de datos.
            var service = new DataService();
            var query = "SELECT * from Users";
            var dt = service.RetrieveDataTable(query);

            // Enseña la tabla por medio del DataGridView
            dataGridView1.DataSource = new BindingSource(dt, null);
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            _parentInstance.ShowLoginForm();
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            _parentInstance.ShowEditUserForm();
        }
    }
}
