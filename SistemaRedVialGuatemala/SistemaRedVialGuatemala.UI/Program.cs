using System;
using System.Windows.Forms;
using SistemaRedVialGuatemala.UI.Formularios;

namespace SistemaRedVialGuatemala.UI
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrincipal());
        }
    }
}
