using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAI_Facultad.Persistencia;

namespace CAI_Facultad
{
    public partial class FormContraseña : Form
    {
        public FormContraseña()
        {
            InitializeComponent();
        }

        private void btbActualizarContraseña_Click(object sender, EventArgs e)
        {
           
            string usuario = txtUsuario.Text;
            string contraseñaNueva = txtNuevaContraseña.Text;

            CambiarContraseña(usuario, contraseñaNueva);
         
        }

        public void CambiarContraseña(string usuario, string contraseñaNueva)
        {
            List<string> listadoCredenciales = obtenerCredenciales();
            List<string> nuevasCredenciales = new List<string> { };

            try
            {
                foreach (string linea in listadoCredenciales)
                {
                    string[] campos = linea.Split(';');

                    if (campos.Length > 0 && campos[0] == usuario)
                    {
                        campos[1] = contraseñaNueva;
                    }

                    nuevasCredenciales.Add(string.Join(";", campos));
                }

                File.WriteAllLines(@"D:\\Datos\\OneDrive\\Documentos\\GitHub\\CAI-Facultad\\CAI-Facultad\\CAI-Facultad\\Datos\\credenciales.csv", nuevasCredenciales);
                MessageBox.Show("Contraseña actualizada correctamente");
            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudo actualizar la contraseña");
            }
            
        }

        private List<String> obtenerCredenciales()
        {
            PersistenciaUtils persistenciaUtils = new PersistenciaUtils();
            List<String> listado = persistenciaUtils.LeerRegistro("credenciales.csv");

            return listado;
        }


    }
}
