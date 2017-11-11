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
        public static string nombre = "";
        public static string apellido = "";
        public static string fechaEntrada = "";
        public static string fechaSalida = "";





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
