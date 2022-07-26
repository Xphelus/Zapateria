using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zapateria.Code
{  internal class DataService
    {
        private readonly SqlConnection _cnn;

        public DataService()
        {
            // Por cada instancia de DataService va a haber una nueva connexión a la base de datos.
            _cnn = new SqlConnection("Server=localhost;Database=Zapateria;Trusted_Connection=True;");
        }

        public void SendData(string query)
        {
            // Abre la conexión que se creó con el constructor.
            _cnn.Open();

            // Utiliza el DataAdapter para enviar el query a la base de datos por medio de la conexión existente.
            var da = new SqlDataAdapter
            {
                InsertCommand = new SqlCommand(query, _cnn)
            };

            // Ejecuta el comando como tal.
            da.InsertCommand.ExecuteNonQuery();

            // Se deshace de lo que ya no se necesita.
            _cnn.Close();
            da.Dispose();
        }

        public DataSet FetchData(string query)
        {
            // Abre la conexión que se creo con el constructor.
            _cnn.Open();

            // Utiliza el DataAdapter para enviar el query a la base de datos por medio de la conexión existente.
            var da = new SqlDataAdapter(query, _cnn);

            // Crea y llena el DataSet que devuelve la base de datos.
            var ds = new DataSet();
            da.Fill(ds);

            // Cierra la conexión
            _cnn.Close();

            return ds;
        }

        public DataTable RetrieveDataTable(string query)
        {
            // Abre la conexión que se creo con el constructor.
            _cnn.Open();

            // Utiliza el DataAdapter para enviar el query a la base de datos por medio de la conexión existente.
            var da = new SqlDataAdapter(query, _cnn);

            // Crea y llena el DataTable que devuelve la base de datos.
            var dt = new DataTable();
            da.Fill(dt);

            // Cierra la conexión
            _cnn.Close();

            return dt;
        }
    }
}
