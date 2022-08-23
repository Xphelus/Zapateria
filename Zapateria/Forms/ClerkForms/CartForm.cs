using System.Data;
using System.Data.SqlClient;
using Zapateria.Code;

namespace Zapateria.Forms.ClerkForms
{
    public partial class CartForm : Form
    {
        public CartForm()
        {
            InitializeComponent();

            RefreshTable();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            MainOrderForm.Cart.Clear();

            RefreshTable();
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            var clientId = clientIdTB.Text;
            var service = new DataService();

            if (clientId is null or "")
            {
                MessageBox.Show(owner: this, @"The Client ID box cannot be empty!");
                return;
            }

            string query;

            // Solo para verificar que el cliente sí exista
            try
            {
                query = $"SELECT * FROM Clients WHERE Client_ID = {clientId}";
                _ = service.FetchData(query);
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

            var total = 0;

            try
            {
                foreach (var item in MainOrderForm.Cart)
                {
                    query = $"SELECT Prod_Price, Prod_Amnt FROM Products WHERE Prod_ID = {item.Key}";

                    var productSet = service.FetchData(query);

                    total += (int.Parse(productSet.Tables[0].Rows[0]["Prod_Price"].ToString()) * item.Value);
                    var newAmount = int.Parse(productSet.Tables[0].Rows[0]["Prod_Amnt"].ToString()) - item.Value;

                    query = $"UPDATE Products SET Prod_Amnt = {newAmount} WHERE Prod_ID = {item.Key}";
                    service.SendData(query);
                }

                query = "SELECT Order_ID FROM Orders";
                var ordersSet = service.FetchData(query);

                var newOrderNumber = ordersSet.Tables[0].Rows.Count + 1;

                var date = DateTime.Now.ToString("yyyy-MM-dd");
                query = $"INSERT INTO Orders VALUES ({newOrderNumber}, '{ContainerForm.Username}', {clientId}, '{date}', {total})";
                service.SendData(query);

                foreach (var item in MainOrderForm.Cart)
                {
                    query = $"INSERT INTO Order_Lines VALUES ({newOrderNumber}, {item.Key}, {item.Value})";
                    service.SendData(query);
                }
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

            MainOrderForm.Cart.Clear();

            RefreshTable();
        }

        private void RefreshTable()
        {
            dataGrid.Rows.Clear();
            dataGrid.Columns.Clear();

            dataGrid.Columns.Add("ID", "Product ID");
            dataGrid.Columns.Add("Amount", "Amount to Purchase");

            foreach (var item in MainOrderForm.Cart)
            {
                dataGrid.Rows.Add(item.Key, item.Value);
            }
        }

        private void NewClientButton_Click(object sender, EventArgs e)
        {
            _ = new AddClient
            {
                Visible = true
            };
        }
    }
}
