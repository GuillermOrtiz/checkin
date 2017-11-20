using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChecksFinal
{
    static class Program
    {

        public static int idReserva = 0;
        public static string nombreCliente = "";
        public static string apellidoCliente = "";
        public static string fechaEntrada = "";
        public static string fechaSalida = "";
        public static int pr = '1';




        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new principal());
        }
    }
}
