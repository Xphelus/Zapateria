using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zapateria.Forms.ClerkForms
{
    public partial class MainReceiptsForm : Form
    {
        public MainReceiptsForm()
        {
            InitializeComponent();

            var receiptsForm = new ReceiptsForm();

            ShowForm(receiptsForm);
        }

        private void ReceiptsButton_Click(object sender, EventArgs e)
        {
            var receiptsForm = new ReceiptsForm();

            ShowForm(receiptsForm);
        }

        private void DibsButton_Click(object sender, EventArgs e)
        {
            var dibsForm = new DibsForm();

            ShowForm(dibsForm);
        }

        // Ve qué Form está activo en el panel container del centro.
        private Form? _activeForm;
        public void ShowForm(Form childForm)
        {
            // Si el form no es null, lo cierra y lo reemplaza con el parámetro de este método.
            _activeForm?.Close();
            _activeForm = childForm;

            // Le damos las propiedades para que se acomode al panel container.
            childForm.Dock = DockStyle.Fill;
            childForm.TopLevel = false;
            childForm.TopMost = true;
            childForm.FormBorderStyle = FormBorderStyle.None;

            centerPanel.Controls.Add(childForm);
            childForm.Show();
        }
    }
}
