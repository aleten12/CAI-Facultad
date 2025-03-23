using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Facultad.Entidades
{
    internal class Facultad
    {
        private  List<Alumno> _alumnos;
        private int _cantidadSedes;
        private string _nombre;
        private List<Empleado> _empleados;

        public int CantidadSedes {  get => _cantidadSedes; set => _cantidadSedes = value; }
        public string Nombre { get => _nombre ;  set => _nombre = value; }

        public List<Alumno> Alumnos { get => _alumnos; set => _alumnos = value; }
        public List<Empleado> Empleados { get => _empleados; set => _empleados = value; }
    }
}
