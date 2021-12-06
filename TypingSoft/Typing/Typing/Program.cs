using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Typing.Presentacion;//importando o haciendo visible nuestras interfacez
using Typing.Control;//importando o haciendo visible nuestras clases

namespace Typing
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());//llamando a nuestro formulario principal de Typing.Presentacion
        }
    }
}
