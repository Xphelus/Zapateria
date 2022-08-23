using System.Data;
using System.Data.SqlClient;
using Zapateria.Code;

namespace Zapateria.Forms.ClerkForms
{
    public partial class InvForm : Form
    {
        public InvForm()
        {
            InitializeComponent();

            GetNewProductId();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            var id = idAddTB.Text;
            var name = nameAddTB.Text;
            var price = priceAddTB.Value;
            var category = categoryAddTB.Text;
            var amount = amountAddTB.Value;

            // Si alguno de los campos está vacío, da un error y detiene el método.
            if (id is null or "" || name is null or "" ||  category is null or "")
            {
                MessageBox.Show(owner: this, @"Operation Failed: No fields can be empty");
                return;
            }

            // Envía los datos a la tabla de la base de datos.
            var service = new DataService();
            var query = $"INSERT INTO Products VALUES ({id}, '{name}', {price}, '{category}', {amount});";

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
                return;
            }

            MessageBox.Show(owner: this, @"The product has been successfully added!");
            
            ClearTextBoxes();
        }
        private void FetchButton_Click(object sender, EventArgs e)
        {
            if (idEditTB.Enabled)
            {
                // Consigue todos los datos desde la base de datos para que se puedan editar.
                // Lo único no editable es el ID del producto.

                var productId = idEditTB.Text;

                if (productId is null or "")
                    return;

                var service = new DataService();
                var query = $"SELECT * from Products WHERE Prod_ID = {productId}";

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

                idEditTB.Enabled = false;

                nameEditTB.Text = ds.Tables[0].Rows[0]["Prod_Name"].ToString();
                // ReSharper tira un Warning acá sobre un posible argumento nulo. Esto en la práctica es imposible gracias al check que hace el if statement arriba.
                #pragma warning disable CS8604 // Possible null reference argument. 
                priceEditTB.Value = decimal.Parse(ds.Tables[0].Rows[0]["Prod_Price"].ToString());
                categoryEditTB.Text = ds.Tables[0].Rows[0]["Prod_Category"].ToString();
                amountEditTB.Value = decimal.Parse(ds.Tables[0].Rows[0]["Prod_Amnt"].ToString());
                #pragma warning restore CS8604 // Possible null reference argument.

                editButton.Enabled = true;
            }
            else
            {
                ClearTextBoxes();

                idEditTB.Enabled = true;
                editButton.Enabled = false;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var id = idEditTB.Text;
            var name = nameEditTB.Text;
            var price = priceEditTB.Value;
            var category = categoryEditTB.Text;
            var amount = amountEditTB.Value;

            // Los textbox no pueden ser nulos o vacíos. Algunos tampoco pueden ser menor a 0.
            if (id is null or "" || name is null or "" ||  category is null or "")
                return;

            // Prepara el query para actualizar la base de datos.
            var service = new DataService();
            var query = $"UPDATE Products SET Prod_Name = '{name}', Prod_Price = {price}, Prod_Category = '{category}', Prod_Amnt = {amount} WHERE Prod_ID = {id}";

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
                return;
            }

            MessageBox.Show(owner: this, @"The product has been successfully edited!");
        }

        private void ClearTextBoxes()
        {
            GetNewProductId(); 
            nameAddTB.Clear();
            priceAddTB.Value = 0;
            categoryAddTB.Clear();
            amountAddTB.Value =  0;

            nameEditTB.Clear();
            priceEditTB.Value = 0;
            categoryEditTB.Clear();
            amountEditTB.Value = 0;
        }

        private void GetNewProductId()
        {
            // Necesita obtener la cantidad de productos existentes para determinar el ID del nuevo producto.
            var service = new DataService();
            var ds = service.FetchData("SELECT Prod_ID FROM Products;");

            var newId = ds.Tables[0].Rows.Count + 1;

            idAddTB.Text = newId.ToString();
        }
    }
}
