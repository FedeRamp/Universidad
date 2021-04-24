using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Libreria.Clases
{
    class Empleado : Persona
    {
        private DateTime fechaIngreso;
        private int legajo;
        private List<Salario> salarios;

        public Empleado(string nombre, string apellido, DateTime nacimiento, DateTime ingreso, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = nacimiento;
            this.fechaIngreso = ingreso;
            this.legajo = legajo;
        }

        public void AgregarSalario(Salario)
        {

        }
    }
}
