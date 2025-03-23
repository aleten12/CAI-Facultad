using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Facultad.Entidades
{
    internal class Empleado : Persona
    {
        private int _legajo;
        private DateTime _fechaIngreso;

        public DateTime FechaIngreso {  get => _fechaIngreso; set => _fechaIngreso = value; }
        public int Legajo { get => _legajo ; set => _legajo = value; }
        protected override void GetCredencial() { }

        protected abstract string ListarEmpleados(bool listarConId) { }
    }
}
