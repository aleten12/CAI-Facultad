using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAI_Facultad.Entidades;
using CAI_Facultad.Persistencia;

namespace CAI_Facultad
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public bool ValidarCredenciales(string usuario, string contraseña, string nombreArchivo)
        {
            string rutaCsv = @"D:\Datos\OneDrive\Documentos\GitHub\CAI-Facultad\CAI-Facultad\CAI-Facultad\Datos\" + nombreArchivo;

            if (!File.Exists(rutaCsv))
            {
                MessageBox.Show("No se encontró el archivo de credenciales.");
                return false;
            }

            string[] lineas = File.ReadAllLines(rutaCsv);

            foreach (string linea in lineas)
            {
                string[] campos = linea.Split(';');

                if (campos.Length >= 2)
                {
                    string user = campos[0];
                    string pass = campos[1];

                    if (usuario == user && contraseña == pass)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void btbIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtLoginUsuario.Text;
            string contraseña = txtConstraseña.Text;

            bool usuarioValido = ValidarTexto(usuario, "Usuario");
            bool contraseñaValida = ValidarTexto(contraseña, "Contraseña");

            if (usuarioValido && contraseñaValida)
            {
                
                if (ValidarCredenciales(usuario, contraseña, "credenciales.csv"))
                {
                    validarEstadoClave(txtLoginUsuario.Text);
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de login");
                }
            }
        }

        private bool ValidarTexto(string texto, string campo)
        {
            bool flag = false;

            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show($"El campo {campo} no puede estar vacio.", "Error");
            }
            else if (texto.Length < 6)
            {
                MessageBox.Show($"El campo {campo} debe contener 6 o más carácteres.", "Error");
            }
            else
            {
                flag = true;
            }

            return flag;
        }
        private void validarEstadoClave(string usuarioLogin)
        {
            Credencial credencialLogin = buscarUsuario(usuarioLogin);

            if (credencialLogin.FechaUltimoIngreso == null)
            {
                this.Hide();
                FormContraseña formContraseña = new FormContraseña();
                formContraseña.ShowDialog();
            } else
            {
                this.Hide();
                FormMenu formMenu = new FormMenu();
                formMenu.ShowDialog();
            }

            if (credencialLogin.FechaUltimoIngreso < DateTime.Today.AddDays(-30))
            {
                this.Hide();
                FormContraseña formContraseña = new FormContraseña();
                formContraseña.ShowDialog();
            }
            else
            {
                this.Hide();
                FormMenu formMenu = new FormMenu();
                formMenu.ShowDialog();
            }

        }

        private Credencial buscarUsuario(String usuarioLogin)
        {
            Credencial credencialLogin = null;

            foreach (Credencial credencial in obtenerCredenciales())
            {
                if (credencial.Usuario.Equals(usuarioLogin))
                {
                    credencialLogin = credencial;
                }
            }

            return credencialLogin;
        }

        private List<Credencial> obtenerCredenciales()
        {

            string archivo = "credenciales.csv";
            PersistenciaUtils persistenciaUtils = new PersistenciaUtils();
            List<String> listado = persistenciaUtils.LeerRegistro(archivo);
            List<Credencial> listadoCredenciales = new List<Credencial>();

            foreach (String registro in listado)
            {
                Credencial credencial = new Credencial(registro);
                listadoCredenciales.Add(credencial);
            }

            return listadoCredenciales;
        }
        private void btbContraseña_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormContraseña formContraseña = new FormContraseña();
            formContraseña.ShowDialog();
        }
    }
}
