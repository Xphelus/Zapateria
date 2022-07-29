using Zapateria.Code;

namespace Zapateria.Forms.UserManagement
{
    public partial class EditUserForm : Form
    {
        private readonly MainForm _parentInstance;

        public EditUserForm(MainForm parentInstance)
        {
            _parentInstance = parentInstance;
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
            service.SendData(query);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var adminForm = new AdminForm(_parentInstance);

            _parentInstance.ShowForm(adminForm);
            Close();
        }

        private void FetchButton_Click(object sender, EventArgs e)
        {
            if (userIdTextBox.Enabled)
            {
                userIdTextBox.Enabled = false;

                var userId = userIdTextBox.Text;

                if (userId is null or "")
                    return;

                var service = new DataService();
                var query = $"SELECT * FROM Users WHERE User_ID = '{userId}'";

                var ds = service.FetchData(query);

                userNameTextBox.Text = ds.Tables[0].Rows[0]["User_Name"].ToString();
                adminCheckBox.Checked = ds.Tables[0].Rows[0]["IsAdmin"].ToString().Equals("True");

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
