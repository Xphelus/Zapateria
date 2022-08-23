using Zapateria.Code;

namespace Zapateria.Forms.UserManagement
{
    public partial class ViewUserForm : Form
    {
        public ViewUserForm()
        {
            InitializeComponent();

            // Consigue la tabla de Users entera de la base de datos.
            var service = new DataService();
            var dt = service.RetrieveDataTable("SELECT * from Users");

            // Enseña la tabla por medio del DataGridView
            dataGrid.DataSource = new BindingSource(dt, null);
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
