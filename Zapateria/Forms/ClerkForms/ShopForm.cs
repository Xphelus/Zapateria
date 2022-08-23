using System.Data;
using System.Data.SqlClient;
using Zapateria.Code;

namespace Zapateria.Forms.ClerkForms
{
    public partial class ShopForm : Form
    {
        private DataTable _localTable = new();

        public ShopForm()
        {
            InitializeComponent();

            clientIdLabel.Visible = false;
            clientIdTB.Visible = false;
            acceptButton.Visible = false;

            RefreshTable();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var id = (int)idTB.Value;
            var amount = (int)amountTB.Value;

            // Primero necesitamos saber cuál es la cantidad del producto en este momento
            var service = new DataService();
            var query = $"SELECT Prod_Amnt FROM Products WHERE Prod_ID = {id}";

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

            // Revisa si la base de datos no encontró nada con ese ID.
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show(owner: this, @"That Product ID does not exist!");
                return;
            }

            // ReSharper tira un Warning acá sobre un posible argumento nulo. Esto en la práctica es imposible gracias al check que hace el if statement arriba.
            #pragma warning disable CS8604 // Possible null reference argument.
            var availableAmount = int.Parse(ds.Tables[0].Rows[0]["Prod_Amnt"].ToString());
            #pragma warning restore CS8604 // Possible null reference argument.
            if (MainOrderForm.Cart.ContainsKey(id))
            {
                 var alreadyAddedAmount = MainOrderForm.Cart[id];

                if ((availableAmount - amount - alreadyAddedAmount) < 0)
                {
                    MessageBox.Show(owner: this, @"The amount can't be higher than what's available.");
                    return;
                }

                MainOrderForm.Cart[id] = alreadyAddedAmount + amount;
            }
            else
            {
                if (availableAmount - amount < 0)
                {
                    MessageBox.Show(owner: this, @"The amount can't be higher than what's available.");
                    return;
                }

                MainOrderForm.Cart.Add(id, amount);
            }
        }

        private void RefreshTable()
        {
            // Consigue la tabla entera de Products desde la base de datos.
            var service = new DataService();
            _localTable = service.RetrieveDataTable("SELECT * from Products");

            // Enseña la tabla por medio del DataGridView
            dataGrid.DataSource = new BindingSource(_localTable, null);
        }

        private void DibsButton_Click(object sender, EventArgs e)
        {
            clientIdLabel.Visible = true;
            clientIdTB.Visible = true;
            acceptButton.Visible = true;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            var id = (int)idTB.Value;
            var amount = (int)amountTB.Value;
            var clientId = clientIdTB.Text;

            if (clientId is null or "")
            {
                MessageBox.Show(owner: this, @"Client ID cannot be empty!");
                return;
            }

            // Primero necesitamos saber cuál es la cantidad del producto en este momento
            var service = new DataService();
            var query = $"SELECT Prod_Amnt, Prod_Price FROM Products WHERE Prod_ID = {id}";

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

            // Revisa si la base de datos no encontró nada con ese ID.
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show(owner: this, @"That Product ID does not exist!");
                return;
            }

            // ReSharper tira un Warning acá sobre un posible argumento nulo. Esto en la práctica es imposible gracias al check que hace el if statement arriba.
#pragma warning disable CS8604 // Possible null reference argument.
            var availableAmount = int.Parse(ds.Tables[0].Rows[0]["Prod_Amnt"].ToString());
            var price = int.Parse(ds.Tables[0].Rows[0]["Prod_Price"].ToString());
#pragma warning restore CS8604 // Possible null reference argument.

            var newAmount = availableAmount - amount;

            if (newAmount < 0)
            {
                MessageBox.Show(owner: this, @"The amount can't be higher than what's available.");
                return;
            }

            try
            {
                query = $"UPDATE Products SET Prod_Amnt = {newAmount} WHERE Prod_ID = {id}";
                service.SendData(query);

                query = "SELECT * FROM Dibs";
                var dibsSet = service.FetchData(query);

                var newDibsId = dibsSet.Tables[0].Rows.Count + 1;

                var date = DateTime.Now.ToString("yyyy-MM-dd");
                query = $"INSERT INTO Dibs VALUES ({newDibsId}, {clientId}, {id}, {amount}, '{date}', {price * amount}, 0)";
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

            clientIdLabel.Visible = false;
            clientIdTB.Visible = false;
            acceptButton.Visible = false;

            RefreshTable();
        }
    }
}
