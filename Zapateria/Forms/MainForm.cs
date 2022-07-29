namespace Zapateria.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Form? _activeForm;
        public void ShowForm(Form childForm)
        {
            _activeForm?.Close();
            _activeForm = childForm;

            childForm.Dock = DockStyle.Fill;
            childForm.TopLevel = false;
            childForm.TopMost = true;
            childForm.FormBorderStyle = FormBorderStyle.None;

            pContainer.Controls.Add(childForm);
            childForm.Show();
        }

        private void pContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
