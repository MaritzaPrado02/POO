using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3_Alumno_Maestro_
{
    public partial class frmDatos : Form
    {
        Alumno objAlumno;
        Maestro objMaestro;
        Alumno[] Materias;
        Alumno[] Calificaciones;  
        Maestro[] materiasImp;
        int cantidadMaterias;
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
            btnImprimir.Enabled = false;
            btnRegistrar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            grbDatosGenerales.Enabled = true;
            //grbMaterias.Enabled = true;
            grbDatosEspecificos.Enabled = true;
            btnRegistrar.Enabled = true;
            //btnImprimir.Enabled = true;
            cont = 0;

            if (cmbOcupacion.Text == "Alumno")
            {
                lblNumero.Text = "Número de control:";
                lblSC.Text = "Carrrera:";
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
                if (cont < cantidadMaterias)
                {
                    Materias[cont] = new Alumno();
                    Calificaciones[cont] = new Alumno();
                    Materias[cont].materias[cont] = txtMateria.Text;
                    Calificaciones[cont].calificacion[cont] = Convert.ToInt32(txtCalificacion.Text);
                    cont++;
                    MessageBox.Show("Materia capturada");
                    limpiarControles();
                }
                if (cont == cantidadMaterias)
                {
                    MessageBox.Show("Se han capturado todas las materias");                   
                    grbDatosGenerales.Enabled = false;
                    grbDatosEspecificos.Enabled = false;
                    grbMaterias.Enabled = false;
                    btnImprimir.Enabled = true;
                    //cantidadMaterias = 0;
                    limpiarControles();
                    btnCapturar.Enabled = false;
                }
                
            }
          else
            {
                if (cmbOcupacion.Text == "Maestro")
                {
                    if (cont < cantidadMaterias)
                    {
                        materiasImp[cont] = new Maestro();                      
                        materiasImp[cont].materias[cont] = txtMateria.Text;                      
                        MessageBox.Show("Materia capturada");
                        limpiarControles();
                    }
                    if (cont == cantidadMaterias)
                    {
                        MessageBox.Show("Se han capturado todas las materias");
                        grbDatosGenerales.Enabled = false;
                        grbDatosEspecificos.Enabled = false;
                        grbMaterias.Enabled = false;
                        btnImprimir.Enabled = true;
                        //cantidadMaterias = 0;
                        limpiarControles();
                        btnCapturar.Enabled = false;
                    }
                }
            }
        }

        public void ImprimirDatosAlumno()
        {
            string materias = "";

            for (int i = 0; i < cont; i++)
            {
                string datos = objAlumno.materias[i];
                objAlumno.imprimirDatosAlumno();
                materias += datos + Environment.NewLine;
               
            }

            MessageBox.Show(materias);
        }
        public void ImprimirDatosMaestro()
        {
            string materias = "";

            for (int i = 0; i < cont; i++)
            {
                string datos = objMaestro.materias[i];
                objMaestro.imprimirDatosMaestro();
                materias += datos + Environment.NewLine;

            }

            MessageBox.Show(materias);

        }
      


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (cmbOcupacion.Text == "Alumno")
            {
                if (cmbOcupacion.Text == "Alumno")
                {
                    var cadena = " Nombre: " + objAlumno.nombre + "\n Fecha de nacimiento: " + objAlumno.fechaNacimiento.ToString() + "\n Número de control" +
                     objAlumno.numeroControl + "\n Carrera: " + objAlumno.carrera;

                    MessageBox.Show(cadena);
                    ImprimirDatosAlumno();
                }
                else
                {
                    if (cmbOcupacion.Text == "Maestro")
                    {
                        var cadena = " Nombre: " + objMaestro.nombre + "\n Fecha de nacimiento: " + objMaestro.fechaNacimiento.ToString() + "\n Número de maestro" +
                        objMaestro.numeroMaetro + "\n Sueldo: " + objMaestro.sueldo;

                        MessageBox.Show(cadena);
                        ImprimirDatosMaestro();
                    }

                }

            }
        }


        private void ctnRegistrar_Click(object sender, EventArgs e)
        {
            grbMaterias.Enabled = true;
            btnCapturar.Enabled = true;
            //nudCantidadMaterias = null;
            txtMateria.Enabled = true;
            if (cmbOcupacion.Text == "Alumno")
            {
                
                txtCalificacion.Enabled = true;
                objAlumno.cantidadMaterias = int.Parse(nudCantidadMaterias.Text);
                cantidadMaterias = int.Parse(nudCantidadMaterias.Text);
                Materias = new Alumno[cantidadMaterias];
                Calificaciones = new Alumno[cantidadMaterias];
                cont = 0;
                btnRegistrar.Enabled = false;
                nudCantidadMaterias.Enabled = false;
            }
            else
            {
                if(cmbOcupacion.Text == "Maestro")
                {
                    materiasImp =  new Maestro[cantidadMaterias];
                    objMaestro.cantidadMaterias = int.Parse(nudCantidadMaterias.Text);
                    cantidadMaterias = int.Parse(nudCantidadMaterias.Text);
                    materiasImp = new Maestro[cantidadMaterias];
                    cont = 0;
                    btnRegistrar.Enabled = false;
                    nudCantidadMaterias.Enabled = false;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objAlumno = new Alumno();
            if (cmbOcupacion.Text == "Alumno")
            {
                //validaciones
                objAlumno.nombre = txtNombre.Text;
                objAlumno.fechaNacimiento = dtpFechaNacimiento.Value;
                objAlumno.curp = txtCurp.Text;
                objAlumno.telefono = int.Parse(txtTelefono.Text);
                objAlumno.eMail = txtEmail.Text;
                objAlumno.numeroControl = int.Parse(txtNumero.Text);
                objAlumno.carrera = txtSC.Text;
            }
            else
            {
                objMaestro = new Maestro();
                if (cmbOcupacion.Text == "Maestro")
                {

                    objMaestro.nombre = txtNombre.Text;
                    objMaestro.fechaNacimiento = dtpFechaNacimiento.Value;
                    objMaestro.curp = txtCurp.Text;

                }
            }
        }

            public void limpiarControles()
        {
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
