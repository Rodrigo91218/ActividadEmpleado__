using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadEmpleado
{
    public class Empleado
    {

        public static List<Empleado> empleados = new List<Empleado>();
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private int numDocumento;
        private TipoDocumento tipoDocumento;
        private Puesto puesto;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int NumDocumento { get => numDocumento; set => numDocumento = value; }
        public TipoDocumento TipoDocumento { get => tipoDocumento; set => tipoDocumento = value; }
        public Puesto Puesto { get => puesto; set => puesto = value; }
        public static List<Empleado> Empleados { get => empleados; set => empleados = value; }

        public Empleado(string nombre, string apellido, DateTime fechaNacimiento, int numDocumento, TipoDocumento tipoDocumento, Puesto puesto)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNacimiento = fechaNacimiento;
            this.NumDocumento = numDocumento;
            this.TipoDocumento = tipoDocumento;
            this.Puesto = puesto;
        }
        public Empleado()
        {
            this.Nombre = "";
            this.Apellido = "";
            this.FechaNacimiento = DateTime.Today;
            this.NumDocumento = 0;
            this.TipoDocumento = new TipoDocumento();
            this.Puesto = new Puesto();

        }

        public override string ToString()
        {
            return $"\n{numDocumento} | {apellido}, {nombre} | {Puesto.Nombre}.";
        }

        public void Guardar()
        {
            Empleado.empleados.Add(this);
        }

        public static void Guardar(Empleado nuevo)
        {
            Empleado.empleados.Add(nuevo);
        }
    }
}
