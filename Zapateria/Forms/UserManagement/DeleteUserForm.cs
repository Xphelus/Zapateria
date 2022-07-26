using Zapateria.Code;

namespace Zapateria.Forms.UserManagement
{
    public partial class DeleteUserForm : Form
    {
        private readonly MainForm _parentInstance;

        public DeleteUserForm(MainForm parentInstance)
        {
            _parentInstance = parentInstance;
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _parentInstance.ShowAdminForm();
            Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var userId = userIdTextBox.Text.Trim();

            var service = new DataService();
            var query = $"SELECT * FROM Users WHERE User_ID = '{userId}'";

            var ds = service.FetchData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show(@"Can't find that username.");
                return;
            }

            if (ds.Tables[0].Rows[0]["User_ID"].ToString() == "admin")
            {
                MessageBox.Show(@"You can't delete the admin user.");
                return;
            }

            const string message = "Are you completely sure you want to delete that user?";
            var result = MessageBox.Show(message, @"Delete User", MessageBoxButtons.OKCancel);

            if (result is DialogResult.Cancel or DialogResult.None)
                return;

            query = $"DELETE FROM Users WHERE User_ID = '{userId}'";

            service.SendData(query);

            _parentInstance.ShowAdminForm();
            Close();
        }

        private void userIdLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
