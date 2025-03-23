using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Facultad.Entidades
{
    internal abstract class Persona
    {
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNac;

       public string Nombre { get => _nombre; set => _nombre = value; } 
       public string Apellido { get => _apellido; set => _apellido = value; }
       public DateTime FechaNac { get => _fechaNac; set => _fechaNac = value; }

        protected abstract void GetCredencial();
        protected virtual void GetNombreCompleto() { }

        protected void GetSaludoInformal() { }

    }
}
