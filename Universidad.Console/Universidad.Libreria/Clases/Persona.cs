using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Libreria.Clases
{
    public abstract class Persona
    {
        protected string apellido;
        protected DateTime fechaNac;
        protected string nombre;

        public string Apellido { get => apellido; }
        public DateTime FechaNac { get => fechaNac; }
        public string Nombre { get => nombre; }

        protected virtual string GetCredencial()
        {
            return $"";
        }

        public override string ToString()
        {
            return this.GetCredencial();
        }

        protected string GetNombreCompleto()
        {
            return $"{this.nombre} {this.apellido}";
        }
    }
}
