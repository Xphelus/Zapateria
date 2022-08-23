using System.Data;
using System.Data.SqlClient;
using Zapateria.Code;

namespace Zapateria.Forms.UserManagement
{
    public partial class EditUserForm : Form
    {
        public EditUserForm()
        {
            InitializeComponent();

            editButton.Enabled = false;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var userId = userIdTextBox.Text;
            var userName = userNameTextBox.Text;
            var password = passwordTextBox.Text;
            var isAdmin = adminCheckBox.Checked;

            // Ninguno de estos campos puede ser null en la base de datos
            if (userId is null or "" || userName is null or "")
                return;

            var isAdminBit = isAdmin ? 1 : 0;
            var query = password is null or "" 
                ? $"UPDATE Users SET User_Name = '{userName}', IsAdmin = {isAdminBit} WHERE User_ID = '{userId}'"
                : $"UPDATE Users SET User_Name = '{userName}', Password = '{password}', IsAdmin = {isAdminBit} WHERE User_ID = '{userId}'";


            var service = new DataService();

            try
            {
                service.SendData(query);
            }
            catch (SqlException ex)
            {
                // Si ocurre algún error, lo muestra acá.
                // La expresión LINQ fue sugerencia de la extensión ReSharper, como reemplazo más compacto para un foreach que concatena el texto de los errores.
                var print = ex.Errors.Cast<SqlError>()
                    .Aggregate("", (current, error) => current + error.Message + "\n");

                MessageBox.Show(owner: this, print);
            }
        }

        private void FetchButton_Click(object sender, EventArgs e)
        {
            if (userIdTextBox.Enabled)
            {
                var userId = userIdTextBox.Text;

                if (userId is null or "")
                    return;

                var service = new DataService();
                var query = $"SELECT * FROM Users WHERE User_ID = '{userId}'";

                DataSet ds;

                try
                {
                    ds = service.FetchData(query);
                }
                catch (SqlException ex)
                {
                    // Si ocurre algún error, lo muestra acá.
                    // La expresión LINQ fue sugerencia de la extensión ReSharper, como reemplazo más compacto para un foreach que concatena el texto de los errores.
                    var print = ex.Errors.Cast<SqlError>()
                        .Aggregate("", (current, error) => current + error.Message + "\n");

                    MessageBox.Show(owner: this, print);
                    return;
                }

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show(owner: this, @"That user does not exist!");
                    return;
                }

                userIdTextBox.Enabled = false;

                userNameTextBox.Text = ds.Tables[0].Rows[0]["User_Name"].ToString();
                // ReSharper tira un Warning acá sobre un posible argumento nulo. Esto en la práctica es imposible gracias al check que hace el if statement arriba.
                #pragma warning disable CS8602 // Dereference of a possibly null reference.
                adminCheckBox.Checked = ds.Tables[0].Rows[0]["IsAdmin"].ToString().Equals("True");
                #pragma warning restore CS8602 // Dereference of a possibly null reference.

                // Solo se puede cambiar la contraseña del admin pero no lo demás.
                if (userId == "admin")
                {
                    userNameTextBox.Enabled = false;
                    adminCheckBox.Enabled = false;
                }

                editButton.Enabled = true;
            }
            else
            {
                editButton.Enabled = false;
                userIdTextBox.Enabled = true;
                userNameTextBox.Enabled = true;
                adminCheckBox.Enabled = true;
            }
        }
    }
}
