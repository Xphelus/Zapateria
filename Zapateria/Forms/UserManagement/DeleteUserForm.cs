using Zapateria.Code;

namespace Zapateria.Forms.UserManagement
{
    public partial class DeleteUserForm : Form
    {

        public DeleteUserForm()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var userId = userIdTextBox.Text.Trim();

            // Le pide a la base de datos que nos de el valor de Users con ese ID para ver si el usuario existe primero.
            var service = new DataService();
            var query = $"SELECT * FROM Users WHERE User_ID = '{userId}'";

            var ds = service.FetchData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show(@"Can't find that username.");
                return;
            }

            // El admin user es intocable por cuestiones de funcionalidad.
            if (ds.Tables[0].Rows[0]["User_ID"].ToString() == "admin")
            {
                MessageBox.Show(@"You can't delete the admin user.");
                return;
            }

            const string message = "Are you completely sure you want to delete that user?";
            var result = MessageBox.Show(message, @"Delete User", MessageBoxButtons.OKCancel);

            // Se utiliza para verificar si el usuario de veras quería eliminar a ese usuario o si se ha equivocado.
            if (result is DialogResult.Cancel or DialogResult.None)
                return;

            // Si el admin de veras quería eliminar al usuario, se manda el request a la base de datos y se cierra la ventana.
            query = $"DELETE FROM Users WHERE User_ID = '{userId}'";
            service.SendData(query);

            userIdTextBox.Clear();
        }
    }
}
