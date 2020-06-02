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

namespace Ejercicio4_Alumnos_Maestros_
{
    public partial class frmAlumno : Form
    {
        int cont;
        int contM;
        int cantidadAlumnos;
        Alumno objAlumno = new Alumno();
        public frmAlumno()
        {
            InitializeComponent();
        }

        private void btnRegistrarAlumnos_Click(object sender, EventArgs e)
        {
            grbDatosGenerales.Enabled = true;
            grbDatosEspecificos.Enabled = true;
            btnRegistrar.Enabled = true;
            contM = 0;
            cont = 0;
            cantidadAlumnos = (int)nudCantidadAlumnos.Value;
            objAlumno.nombre = new string[cantidadAlumnos];
            objAlumno.fechaNacimiento = new DateTime[cantidadAlumnos];
            objAlumno.curp = new string[cantidadAlumnos];
            objAlumno.telefono = new int[cantidadAlumnos];
            objAlumno.eMail = new string[cantidadAlumnos];
            objAlumno.numeroControl = new int[cantidadAlumnos];
            objAlumno.carrera = new string[cantidadAlumnos];
            nudCantidadAlumnos.Enabled = false;
            btnRegistrarAlumnos.Enabled = false;
        }

        private void nudCantidadAlumnos_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblCantidadAlumnos_Click(object sender, EventArgs e)
        {

        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {
            grbDatosGenerales.Enabled = false;
            grbMaterias.Enabled = false;
            grbDatosEspecificos.Enabled = false;
            btnCapturar.Enabled = false;
            btnRegistrar.Enabled = false;
            btnGuardar.Enabled = false;
            btnImprimir.Enabled = false;
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

            decimal calificacion;
            if (!Decimal.TryParse(txtCalificacion.Text, out calificacion))
            {
                errorProvider1.SetError(txtCalificacion, "Debe ingresar números en el campo calificación");
                txtCalificacion.Focus();
                return;
            }
            errorProvider1.SetError(txtCalificacion, "");

            if (calificacion < 0)
            {
                errorProvider1.SetError(txtCalificacion, "Debe ingresar un número positivo");
                txtCalificacion.Focus();
                return;
            }
            errorProvider1.SetError(txtCalificacion, "");

            if (contM <= objAlumno.cantidadMateriasAlumno)
            {
                objAlumno.materias[cont, contM] = txtMateria.Text;
                objAlumno.calificacion[cont, contM] = double.Parse(txtCalificacion.Text);
                contM++;
                txtMateria.Text = "";
                txtCalificacion.Text = "";
            }

            if (contM == objAlumno.cantidadMateriasAlumno)
            {
                MessageBox.Show("Se han registrado correctamente las " + contM + " materias", "Materias");
                grbMaterias.Enabled = false;
                contM = 0;
                btnGuardar.Enabled = true;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            grbMaterias.Enabled = true;
            btnCapturar.Enabled = true;
            txtMateria.Enabled = true;
            
            if (txtNumero.Text == "")
            {
                errorProvider1.SetError(txtNumero, "Debe ingresar número de alumno");
                txtNumero.Focus();
                return;
            }
            errorProvider1.SetError(txtNumero, "");

            if (txtSC.Text == "")
            {
                errorProvider1.SetError(txtSC, "Debe ingresar la carrera del alumno");
                txtSC.Focus();
                return;
            }
            txtCalificacion.Enabled = true;
            objAlumno.cantidadMateriasAlumno = (int)nudCantidadMaterias.Value;
            objAlumno.materias = new string[cantidadAlumnos,objAlumno.cantidadMateriasAlumno];
            objAlumno.calificacion = new double[cantidadAlumnos,objAlumno.cantidadMateriasAlumno];

            cont = 0;
            btnRegistrar.Enabled = false;
            nudCantidadMaterias.Enabled = false;
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

            if (cont <= cantidadAlumnos)
            {
                objAlumno.nombre[cont] = txtNombre.Text;
                objAlumno.fechaNacimiento[cont] = dtpFechaNacimiento.Value;
                objAlumno.curp[cont] = txtCurp.Text;
                objAlumno.telefono[cont] = int.Parse(txtTelefono.Text);
                objAlumno.eMail[cont] = txtEmail.Text;
                objAlumno.numeroControl[cont] = int.Parse(txtNumero.Text);
                objAlumno.carrera[cont] = txtSC.Text;
                MessageBox.Show("Los datos del maestro han sido registrados exitosamente", "Maestro registrado");
                cont++;
                limpiarControles();
            }

            if (cont == cantidadAlumnos)
            {
                MessageBox.Show("Se han capturado los " + cantidadAlumnos + " alumnos.", "Registro de alumnos");
                grbDatosGenerales.Enabled = false;
                grbDatosEspecificos.Enabled = false;
                grbMaterias.Enabled = false;
                cantidadAlumnos = 0;
                btnImprimir.Enabled = true;
            }

            
        }
        public void limpiarControles()
        {
            nudCantidadAlumnos.Value = nudCantidadAlumnos.Minimum;
            txtNombre.Text = " ";
            txtCurp.Text = " ";
            txtEmail.Text = " ";
            txtTelefono.Text = " ";
            txtNumero.Text = " ";
            txtSC.Text = " ";
            txtCalificacion.Text = " ";
            txtMateria.Text = " ";
        }

        public void ImprimirDatosAlumno()
        {

            string datosAlumno = "";
            for (int i = 0; i < cantidadAlumnos; i++)
            {
                string datos = objAlumno.imprimirDatosAlumno();
                datosAlumno += datos + Environment.NewLine;
            }
            MessageBox.Show(datosAlumno, "Datos Alumnos");
        }
    }
}
