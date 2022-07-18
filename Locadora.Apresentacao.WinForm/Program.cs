using Locadora.Apresentacao.WinForm.Compartilhado.ServiceLocator;
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
            var serviceLocatorAutofac = new ServiceLocatorAutofac();
            Application.Run(new TelaPrincipalForm(serviceLocatorAutofac));
        }
    }
}
