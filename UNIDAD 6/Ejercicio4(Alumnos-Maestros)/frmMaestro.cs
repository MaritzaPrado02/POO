using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Ejercicio4_Alumnos_Maestros_
{
    public partial class frmMaestro : Form
    {
        int cont;
        int contM;
        int cantidadMaestros;
        Maestro objMaestro = new Maestro();
        TextWriter archivo;
        public frmMaestro()
        {
            InitializeComponent();
        }

        private void btnRegistrarAlumnos_Click(object sender, EventArgs e)
        {
            grbDatosGenerales.Enabled = true;
            grbDatosEspecificos.Enabled = true;
            btnRegistrar.Enabled = true;
            cont = 0;
            contM = 0;
            cantidadMaestros = (int)nudCantidadMaestros.Value;
            objMaestro.nombre = new string[cantidadMaestros];
            objMaestro.fechaNacimiento = new DateTime[cantidadMaestros];
            objMaestro.curp = new string[cantidadMaestros];
            objMaestro.telefono = new long[cantidadMaestros];
            objMaestro.eMail = new string[cantidadMaestros];
            objMaestro.numeroMaestro= new int[cantidadMaestros];
            objMaestro.sueldo = new double[cantidadMaestros];
            nudCantidadMaestros.Enabled = false;
            btnRegistrarMaestros.Enabled = false;
            objMaestro.MatM = new int[cantidadMaestros];
        }

        private void frmMaestro_Load(object sender, EventArgs e)
        {
            archivo = new StreamWriter("ArchivoMaestros.txt");
            grbDatosGenerales.Enabled = false;
            grbMaterias.Enabled = false;
            grbDatosEspecificos.Enabled = false;
            btnCapturar.Enabled = false;
            btnRegistrar.Enabled = false;
            btnGuardar.Enabled = false;
            btnImprimir.Enabled = false;
        }

        private void grbDatosEspecificos_Enter(object sender, EventArgs e)
        {

        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {

            if (txtMateria.Text == "")
            {
                errorProvider1.SetError(txtMateria, "Ingrese materia");
                txtMateria.Focus();
                return;
            }
            errorProvider1.SetError(txtMateria, "");

            if (contM <= objMaestro.cantMatM)
            {
                objMaestro.materias[contM] = txtMateria.Text;
                contM++;
                txtMateria.Text = " ";
            }

            if (contM == objMaestro.cantMatM)
            {
                MessageBox.Show("Se han registrado correctamente las " + contM + " materias", "Materias");
                grbMaterias.Enabled = false;
                btnGuardar.Enabled = true;
                contM = 0;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            grbMaterias.Enabled = true;
            btnCapturar.Enabled = true;
            txtMateria.Enabled = true;
            if (txtNumero.Text == "")
            {
                errorProvider1.SetError(txtNumero, "Debe ingresar número de maestro");
                txtNumero.Focus();
                return;
            }
            errorProvider1.SetError(txtNumero, "");

            decimal Salario;
            if (!Decimal.TryParse(txtSC.Text, out Salario))
            {
                errorProvider1.SetError(txtSC, "Debe ingresar números en el campo salario");
                txtSC.Focus();
                return;
            }
            errorProvider1.SetError(txtSC, "");

            if (Salario < 0)
            {
                errorProvider1.SetError(txtSC, "Debe ingresar un número positivo");
                txtSC.Focus();
                return;
            }
            errorProvider1.SetError(txtSC, "");

            

            objMaestro.cantMatM = (int)nudCantidadMaterias.Value;
            objMaestro.materias = new string[objMaestro.cantMatM];
            grbMaterias.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Debe ingresar nombre");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            if (txtCurp.Text == "")
            {
                errorProvider1.SetError(txtCurp, "Debe ingresar CURP");
                txtCurp.Focus();
                return;
            }
            errorProvider1.SetError(txtCurp, "");

            Regex reEmail = new Regex(@"^(([^<>()[\]\\.,;:\s@\""]+"
                                     + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                                     + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}]"
                                     + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                                     + @"[a-zA-Z]{2,}))$", RegexOptions.Compiled);

            if (!reEmail.IsMatch(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Debe ingresar una dirección de correo válida");
                txtEmail.Focus();
                return;
            }
            errorProvider1.SetError(txtEmail, "");


            decimal numeroTelefono;
            if (!Decimal.TryParse(txtTelefono.Text, out numeroTelefono))
            {
                errorProvider1.SetError(txtTelefono, "Debe ingresar solo números (número telefonico de 10 digitos)");
                txtTelefono.Focus();
                return;
            }
            errorProvider1.SetError(txtTelefono, "");

            if (cont <= cantidadMaestros)
            {
                objMaestro.nombre[cont] = txtNombre.Text;
                objMaestro.fechaNacimiento[cont] = dtpFechaNacimiento.Value;
                objMaestro.curp[cont] = txtCurp.Text;
                objMaestro.telefono[cont] = long.Parse(txtTelefono.Text);
                objMaestro.eMail[cont] = txtEmail.Text;
                objMaestro.numeroMaestro[cont] = int.Parse(txtNumero.Text);
                objMaestro.sueldo[cont] = double.Parse(txtSC.Text);
                objMaestro.MatM[cont] = (int)nudCantidadMaterias.Value;
                MessageBox.Show("Los datos del maestro han sido registrados exitosamente", "Maestro registrado");
                cont++;
                limpiarControles();
            }

            if (cont == cantidadMaestros)
            {
                MessageBox.Show("Se han capturado los " + cantidadMaestros + " maestros.", "Registro de maestros");
                limpiarControles();
                //objMaestro.cantMatM = 0;
                grbDatosGenerales.Enabled = false;
                grbMaterias.Enabled = false;
                grbDatosEspecificos.Enabled = false;
                
                btnImprimir.Enabled = true;
                //cont = 0;
            }

        }

        public void limpiarControles()
        {
           //nudCantidadMaestros.Value = nudCantidadMaestros.Minimum;
            txtNombre.Text = "";
            txtCurp.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtNumero.Text = "";
            txtSC.Text = "";
            txtMateria.Text = "";
            nudCantidadMaterias.Enabled = true;
            btnRegistrar.Enabled = true;
        }
        public void ImprimirDatosMaestro()
        {
            
            string datosMaestro = "";
            for (int i = 0; i < cantidadMaestros; i++)
            {
                string datos = objMaestro.imprimirDatosMaestro();
                datosMaestro += datos + Environment.NewLine;
                objMaestro.j++;
            }
            MessageBox.Show(datosMaestro, "Datos Maestros");
            archivo.WriteLine(datosMaestro);
            archivo.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimirDatosMaestro();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            TextReader leerArchivo;

            leerArchivo = new StreamReader("ArchivoMaestros.txt");

            MessageBox.Show(leerArchivo.ReadToEnd(), "ArchivoMaestros.txt");
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Process.Start("ArchivoMaestros.txt");
        }
    }
}
