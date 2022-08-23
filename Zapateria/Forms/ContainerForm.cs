namespace Zapateria.Forms
{
    public partial class ContainerForm : Form
    {
        public static string Username { get; set; } = "";

        public ContainerForm()
        {
            InitializeComponent();
        }

        // Contiene una referencia al form que esté activo en el panel principal, puede ser null.
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

            // Lo añadimos y lo mostramos.
            pContainer.Controls.Add(childForm);
            childForm.Show();
        }
    }
}
