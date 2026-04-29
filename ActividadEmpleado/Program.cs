using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadEmpleado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] opciones = { "AGREGAR EMPLEADO", "BUSCAR EMPLEADO", "BORRAR EMPLEADO", "SALIR" };
            int indice = 0;
            ConsoleKey tecla;

           
            do
            {

                do
                {
                    Console.Clear();
                   

                    for (int i = 0; i < opciones.Length; i++)
                    {
                        if (i == indice)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"-> {opciones[i]}");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine($"  {opciones[i]}");
                        }
                    }

                    tecla = Console.ReadKey(true).Key;

                    if (tecla == ConsoleKey.UpArrow)
                    {
                        indice = (indice - 1 + opciones.Length) % opciones.Length;
                    }
                    else if (tecla == ConsoleKey.DownArrow)
                    {
                        indice = (indice + 1) % opciones.Length;
                    }

                } while (tecla != ConsoleKey.Enter);

                Console.Clear();

                switch (indice)
                {
                    case 0:
                        Administrador.AgregarEmpleado();

                        break;

                    case 1:
                        Administrador.BuscarEmpleadoPorDocumento();
                        break;

                    case 2:
                        Administrador.BorrarEmpleado();
                        break;
                }

                if (indice != 3)
                {
                    Console.WriteLine("\nPresione una tecla para volver al menú...");
                    Console.ReadKey();
                }

            } while (indice != 3);
            Console.WriteLine("Programa finalizado.");
        }
    }
}
