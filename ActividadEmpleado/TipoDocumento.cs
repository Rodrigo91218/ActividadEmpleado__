using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadEmpleado
{
    public class TipoDocumento
    {
        public static string[] tiposDocumento = { "DNI", "CUIL", "CUIT", "Pasaporte", "Cedula de identidad", "Libreta de enrolamiento", "Libreta civica" };

        private string nombre;

        public string Nombre { get => nombre; set => nombre = value; }
        public TipoDocumento(string nombre)
        {
            this.Nombre = nombre;
        }
        public TipoDocumento()
        {
            this.Nombre = "";
        }

        public static string SeleccionarTipoDocumentos() 
        {
            int opcion;
            for (int i = 0; i < tiposDocumento.Length; i++)
            {
                Console.WriteLine($"{i + 1}- {tiposDocumento[i]}");
            }

            
            while ((!int.TryParse(Console.ReadLine(), out opcion)) || opcion < 1 || opcion > tiposDocumento.Length)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Opción inválida. Elija un número de la lista: ");
                Console.ResetColor();
            }

            
            return tiposDocumento[opcion - 1];
        }
    }
}
