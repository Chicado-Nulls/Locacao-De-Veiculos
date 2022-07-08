using Locadora.Infra.Logging;
using System;
using System.Windows.Forms;

namespace Locadora.Apresentacao.WinForm
{
    internal static class TelaPrincipal
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfiguracaoLogLocadora.ConfgurarLog();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaPrincipalForm());
        }
    }
}
