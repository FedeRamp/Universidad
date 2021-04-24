using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Libreria.Clases
{
    public class Alumno : Persona
    {
        private int codigo;

        public Alumno(string nombre, string apellido, DateTime fechaNac, int codigo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = fechaNac;
            this.codigo = codigo;
        }

        protected override string GetCredencial()
        {
            return $"{this.apellido} {this.nombre}, cod: {this.codigo}. Nacido: {this.fechaNac}";
        }
    }
}
