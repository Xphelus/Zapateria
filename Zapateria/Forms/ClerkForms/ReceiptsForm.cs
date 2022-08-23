using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zapateria.Code;

namespace Zapateria.Forms.ClerkForms
{
    public partial class ReceiptsForm : Form
    {
        public ReceiptsForm()
        {
            InitializeComponent();

            RefreshTable();
        }

        private static bool _detailsOn;
        private void DetailsButton_Click(object sender, EventArgs e)
        {
            if (_detailsOn)
            {
                detailsButton.Text = @"View Details";

                RefreshTable();

                _detailsOn = false;
            }
            else
            {
                var orderId = orderIdTB.Text;

                if (orderId is null or "")
                {
                    MessageBox.Show(owner: this, @"Order ID cannot be empty!");
                    return;
                }

                var service = new DataService();

                DataTable dt;

                try
                {
                    dt = service.RetrieveDataTable(
                        $"SELECT Order_Lines.Product_ID, Products.Prod_Name, Order_Lines.Prod_Amnt FROM Order_Lines INNER JOIN Products ON Order_Lines.Product_ID = Products.Prod_ID AND Order_Lines.Order_ID = {orderId}");
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

                // Enseña la tabla por medio del DataGridView
                dataGrid.DataSource = new BindingSource(dt, null);

                detailsButton.Text = @"Exit Details";

                _detailsOn = true;
            }
        }

        private void RefreshTable()
        {
            var service = new DataService();

            var dt = service.RetrieveDataTable("SELECT * FROM Orders");

            // Enseña la tabla por medio del DataGridView
            dataGrid.DataSource = new BindingSource(dt, null);
        }
    }
}
