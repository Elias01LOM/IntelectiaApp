using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace IntelectiaApp
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;    // Esto habilita el protocolo 'TLS 1.2' para descargar imágenes sin errores
            Application.EnableVisualStyles();    // Forma parte de la configuración visual
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());    // Iniciamos la app en el formulario de login
        }
    }
}
