using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadEmpleado
{
    public class Administrador
    {


        public static Empleado AgregarEmpleado()
        {
            int num = 0;
            Empleado e = new Empleado();

            Console.WriteLine("\n************* Nuevo empleado *************");
            Console.WriteLine("Ingrese los siguientes datos");

            Console.Write("Nombre: ");
            e.Nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            e.Apellido = Console.ReadLine();

            DateTime fechaNac;
            Console.Write("Fecha de nacimiento (DD/MM/AAAA): ");
            while (!DateTime.TryParse(Console.ReadLine(), out fechaNac))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fecha inválida. Por favor, intente de nuevo (DD/MM/AAAA): ");
                Console.ResetColor();
            }
            e.FechaNacimiento = fechaNac;

            Console.WriteLine("Ingrese número de documento: ");
            while ((!int.TryParse(Console.ReadLine(), out num)) || num < 10000000 || num > 99999999 )
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Valor incorrecto: ");
                Console.ResetColor();
               
            }
            e.NumDocumento = num;

            Console.WriteLine("Seleccione su tipo de documento: ");
            e.TipoDocumento.Nombre = TipoDocumento.SeleccionarTipoDocumentos();

            Console.Write("Seleccione el puesto: ");
            e.Puesto.Nombre = Puesto.SeleccionarPuesto();

            e.Guardar();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n************* Cliente agregado correctamente *************");
            Console.ResetColor();
            
            return e;
            
        }

        public static Empleado BuscarEmpleadoPorDocumento()
        {
            int buscado;
            Console.WriteLine("\n************* Buscar empleado *************");
            Console.WriteLine("Ingrese el número de documento del empleado: ");

            while (!int.TryParse(Console.ReadLine(), out buscado))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor incorrecto, se esperan solo números: ");
                Console.ResetColor();
            }

            foreach (Empleado e in Empleado.empleados)
            {
                if (e.NumDocumento == buscado)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor= ConsoleColor.Black;
                    Console.WriteLine(e.ToString());
                    Console.ResetColor();
                    return e;
                }
            }

            Console.WriteLine("No hay resultados");
            return null;
        }

        public static void BorrarEmpleado()
        {

            Empleado e = BuscarEmpleadoPorDocumento();


            if (e != null)
            {
                Console.WriteLine("\n¿Seguro que desea eliminar al empleado permanentemente? (y/n)");
                string respuesta = Console.ReadLine().ToLower();

                if (respuesta == "y")
                {

                    Empleado.empleados.Remove(e);
                    Console.WriteLine("\nEmpleado eliminado correctamente.");
                }
                else
                {
                    Console.WriteLine("\nOperación cancelada.");
                }
            }

            Console.WriteLine("Oprima cualquier tecla para volver al menú.");
            Console.ReadKey();
        }
    }
}
