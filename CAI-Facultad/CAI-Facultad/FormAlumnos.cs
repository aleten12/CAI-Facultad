using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAI_Facultad.Entidades;
using CAI_Facultad.Persistencia;
using Microsoft.Win32;

namespace CAI_Facultad
{
    public partial class FormAlumnos : Form
    {
        public FormAlumnos()
        {
            InitializeComponent();
        }

        private void FormAlumnos_Load(object sender, EventArgs e)
        {

        }

        private void btbListarAlumnos_Click(object sender, EventArgs e)
        {
            List<string> listado = new List<string>();
            listado = obtenerUsuarios();

            if (listado.Count > 0)
            {
                foreach (string registro in listado)
                {
                    Alumno alumno = new Alumno(registro);
                    lstAlumnos.Items.Add(alumno.ToString());
                }
            }
            
        }

        

        private List<String> obtenerUsuarios()
        {
            PersistenciaUtils persistenciaUtils = new PersistenciaUtils();
            List<String> listado = persistenciaUtils.LeerRegistro("alumnos.csv");

            return listado;
        }
    }
}
