using System.Data;
using System.Data.SqlClient;
using Zapateria.Code;

namespace Zapateria.Forms.ClerkForms
{
    public partial class DibsForm : Form
    {
        public DibsForm()
        {
            InitializeComponent();

            RefreshTable();
        }

        private void RefreshTable()
        {
            var service = new DataService();

            var dt = service.RetrieveDataTable("SELECT * FROM Dibs");

            // Enseña la tabla por medio del DataGridView
            dataGrid.DataSource = new BindingSource(dt, null);
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            var dibsId = dibsIdTB.Text;

            if (dibsId is null or "")
            {
                MessageBox.Show(owner: this, @"The dibs ID cannot be empty!");
                return;
            }

            var service = new DataService();

            try
            {
                var query = $"SELECT * FROM Dibs WHERE Dibs_ID = {dibsId}";
                var ds = service.FetchData(query);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show(owner: this, @"No such dibs exist!");
                    return;
                }

                var isPaid = bool.Parse(ds.Tables[0].Rows[0]["Paid"].ToString());

                if (isPaid)
                {
                    MessageBox.Show(owner: this, @"That dibs has already been paid for!");
                    return;
                }

                var dibsDate = ds.Tables[0].Rows[0]["Dibs_date"].ToString();
                var amount = int.Parse(ds.Tables[0].Rows[0]["Amount"].ToString());
                var total = int.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
                var clientId = ds.Tables[0].Rows[0]["Client_ID"].ToString();
                var productId = ds.Tables[0].Rows[0]["Prod_ID"].ToString();

                query = $"UPDATE Dibs SET Paid = 1 WHERE Dibs_ID = {dibsId}";
                service.SendData(query);

                query = "SELECT Order_ID FROM Orders";
                var ordersSet = service.FetchData(query);

                var newOrderNumber = ordersSet.Tables[0].Rows.Count + 1;

                query = $"INSERT INTO Orders VALUES ({newOrderNumber}, '{ContainerForm.Username}', {clientId}, '{dibsDate}', {total})";
                service.SendData(query);

                query = $"INSERT INTO Order_Lines VALUES ({newOrderNumber}, {productId}, {amount})";
                service.SendData(query);
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

            MessageBox.Show(owner: this, @"Order completed!");

            RefreshTable();
        }
    }
}
