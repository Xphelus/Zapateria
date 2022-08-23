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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var id = idTB.Text;
            var name = nameTB.Text;
            var lastName = lastNameTB.Text;
            var address = addressTB.Text;
            var phone = phoneTB.Text;

            if (id is null or "" || name is null or "" || lastName is null or "" || address is null or "" ||
                phone is null or "")
            {
                MessageBox.Show(owner: this, @"No spaces can be empty!");
                return;
            }

            var service = new DataService();
            var query = $"INSERT INTO Clients VALUES ({id}, '{name}', '{lastName}', '{address}', {phone})";

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

            MessageBox.Show(owner: this, @"Client added successfully!");

            Close();
        }
    }
}
