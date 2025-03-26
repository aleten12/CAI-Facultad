using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Facultad.Entidades
{
    internal class Bedel : Persona
    {
        private string _apodo;

        public string Apodo {  get => _apodo; set => _apodo = value; }

        public void GetNombreCompleto() { }

        protected override void GetCredencial() { }

        
    }
}
