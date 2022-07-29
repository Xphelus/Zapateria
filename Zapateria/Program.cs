using Zapateria.Forms;

namespace Zapateria
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var mainForm = new MainForm();
            var loginForm = new LoginForm(mainForm);
            mainForm.ShowForm(loginForm);

            Application.Run(mainForm);
        }
    }
}