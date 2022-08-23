using Zapateria.Code;

namespace Zapateria.Forms.ClerkForms
{
    public partial class MainOrderForm : Form
    {
        public static Dictionary<int, int> Cart { get; set; } = new();

        public MainOrderForm()
        {
            InitializeComponent();

            // Por defecto muestra el form del inventario.
            var shop = new ShopForm();
            ShowForm(shop);
        }

        private void InvButton_Click(object sender, EventArgs e)
        {
            var shop = new ShopForm();

            ShowForm(shop);
        }

        private void CartButton_Click(object sender, EventArgs e)
        {
            var cartForm = new CartForm();

            ShowForm(cartForm);
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
