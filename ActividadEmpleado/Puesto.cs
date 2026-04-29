using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadEmpleado
{
    public class Puesto
    {
        public static string[] listaPuestos = { "Operario","Administrativo","Jefe de departamento", "Director general", "Coordinador", "Secretario" };

        private string nombre;
        private string descripcion;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public Puesto(string nombre, string descripcion)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }
        public Puesto()
        {
            this.Nombre = "";
            this.Descripcion = "";
        }

        public static string SeleccionarPuesto()
        {
            int opcion;
            for (int i = 0; i < listaPuestos.Length; i++)
            {
                Console.WriteLine($"{i + 1}- {listaPuestos[i]}");
            }

            Console.WriteLine("\n");
            while ((!int.TryParse(Console.ReadLine(), out opcion)) || opcion < 1 || opcion > listaPuestos.Length)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Opción inválida. Elija un número de la lista: ");
                Console.ResetColor();
            }


            return listaPuestos[opcion - 1];
        }
    }
}
