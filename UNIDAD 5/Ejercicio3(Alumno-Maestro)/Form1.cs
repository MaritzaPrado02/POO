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

namespace Ejercicio3_Alumno_Maestro_
{
    public partial class frmDatos : Form
    {
        Alumno objAlumno = new Alumno();
        Maestro objMaestro = new Maestro();
        int cont;
         
        public frmDatos()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grbDatosGenerales.Enabled = false;
            grbMaterias.Enabled = false;
            grbDatosEspecificos.Enabled = false;
            btnCapturar.Enabled = false;
            btnRegistrar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            grbDatosGenerales.Enabled = true;

            grbDatosEspecificos.Enabled = true;
            btnRegistrar.Enabled = true;
            cont = 0;

            if (cmbOcupacion.Text == "Alumno")
            {
                lblNumero.Text = "Número de control:";
                lblSC.Text = "Carrera:";
                lblMaterias.Text = "# Materias que curso:";
                lblNombreMateria.Text = "Materia:";
                lblCalificacion.Text = "Calificación";
            }
            else
            {
                if (cmbOcupacion.Text == "Maestro")
                {
                lblNumero.Text = "Número de maestro:";
                lblSC.Text = "Sueldo:";
                lblMaterias.Text = "# Materias que impartio:";
                    lblNombreMateria.Text = "Materia:";
                    txtCalificacion.Enabled = false;
                }      
            }
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
          if(cmbOcupacion.Text == "Alumno")
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

                if (cont <= objAlumno.cantidadMateriasAlumno)
                {
                    objAlumno.materias[cont] = Convert.ToString(txtMateria.Text);
                    objAlumno.calificacion[cont] = double.Parse(txtCalificacion.Text);
                    cont++;
                    txtMateria.Text = "";
                    txtCalificacion.Text = "";
                }

                if (cont == objAlumno.cantidadMateriasAlumno)
                {
                    MessageBox.Show("Se han registrado correctamente las " + cont + " materias", "Materias");
                    grbMaterias.Enabled = false;
                    cont = 0;
                    grbDatosGenerales.Enabled = false;
                    grbDatosEspecificos.Enabled = false;
                    grbMaterias.Enabled = false;
                    btnCapturar.Enabled = false;
                    btnGuardar.Enabled = true;
                    
                }
            }
          else
            {
                if (cmbOcupacion.Text == "Maestro")
                {

                    if (txtMateria.Text == "")
                    {
                        errorProvider1.SetError(txtMateria, "Ingrese materia");
                        txtMateria.Focus();
                        return;
                    }
                    errorProvider1.SetError(txtMateria, "");
                   
                    if (cont <= objMaestro.cantidadMateriasMaestro)
                    {
                        objMaestro.materias[cont] = Convert.ToString(txtMateria.Text);
                        cont++;
                        txtMateria.Text = "";
                    }

                    if (cont == objMaestro.cantidadMateriasMaestro)
                    {
                        MessageBox.Show("Se han registrado correctamente las " + cont + " materias", "Materias");
                        grbMaterias.Enabled = false;
                        cont = 0;
                        grbDatosGenerales.Enabled = false;
                        grbDatosEspecificos.Enabled = false;
                        grbMaterias.Enabled = false;
                        btnCapturar.Enabled = false;
                        btnGuardar.Enabled = true;
                        
                    }

                }
            }
        }

        public void ImprimirDatosAlumno()
        {
            string datos = "";
            string materias = objAlumno.imprimirDatosAlumno();
            datos = materias + Environment.NewLine;

            MessageBox.Show(datos, "Datos Maestro");
        }
        public void ImprimirDatosMaestro()
        {
                string datos = "";
                string materias = objMaestro.imprimirDatosMaestro();
                datos = materias + Environment.NewLine;

            MessageBox.Show(datos,"Datos Maestro");

        }

        private void ctnRegistrar_Click(object sender, EventArgs e)
        {
            grbMaterias.Enabled = true;
            btnCapturar.Enabled = true;
            txtMateria.Enabled = true;
            if (cmbOcupacion.Text == "Alumno")
            {
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
                objAlumno.cantidadMateriasAlumno= (int)nudCantidadMaterias.Value;
                objAlumno.materias = new string[objAlumno.cantidadMateriasAlumno];
                objAlumno.calificacion = new double[objAlumno.cantidadMateriasAlumno];
                
                cont = 0;
                btnRegistrar.Enabled = false;
                nudCantidadMaterias.Enabled = false;
            }
            else
            {
                if (cmbOcupacion.Text == "Maestro")
                {
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
                    objMaestro.cantidadMateriasMaestro = (int)nudCantidadMaterias.Value;
                    objMaestro.materias = new string[objMaestro.cantidadMateriasMaestro];
                    cont = 0;
                    btnRegistrar.Enabled = false;
                    nudCantidadMaterias.Enabled = false;
                    grbMaterias.Enabled = true;
                    txtCalificacion.Enabled = false;
                }
            }
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

            if (cmbOcupacion.Text == "Alumno")
            {
                objAlumno.nombre = txtNombre.Text;
                objAlumno.fechaNacimiento = dtpFechaNacimiento.Value;
                objAlumno.curp = txtCurp.Text;
                objAlumno.telefono = long.Parse(txtTelefono.Text);
                objAlumno.eMail = txtEmail.Text;
                objAlumno.numeroControl = int.Parse(txtNumero.Text);
                objAlumno.carrera = txtSC.Text;
                ImprimirDatosAlumno();
            }
            else
            {
                
                if (cmbOcupacion.Text == "Maestro")
                {
                    objMaestro.nombre = txtNombre.Text;
                    objMaestro.fechaNacimiento = dtpFechaNacimiento.Value;
                    objAlumno.telefono = long.Parse(txtTelefono.Text);
                    objMaestro.curp = txtCurp.Text;
                    objMaestro.eMail = txtEmail.Text;
                    objMaestro.numeroMaestro = int.Parse(txtNumero.Text);
                    objMaestro.sueldo = double.Parse(txtSC.Text);
                    ImprimirDatosMaestro();
                }
            }
            limpiarControles();
            
        }

            public void limpiarControles()
        {
            cmbOcupacion.SelectedIndex = -1;
            txtNombre.Text = " ";
            txtCurp.Text = " ";
            txtTelefono.Text = " ";
            txtNumero.Text = " ";
            txtSC.Text = " ";
            txtCalificacion.Text =  " ";
            txtMateria.Text = " ";
        }

        private void nudCantidadMaterias_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
