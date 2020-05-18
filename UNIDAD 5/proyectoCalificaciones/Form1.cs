using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace proyectoCalificaciones
{
    public partial class frmDatos : Form
    {
        IGE objIGE = new IGE();
        ITIC objITIC = new ITIC();
        IIA objIIA = new IIA();
        int cont;
        //double[] promedioCarreras = new double[3];
        string mejorCarrera;
        double mejorPromedio;
        double mejorPromedioIGE;
        string mejorAlumnoIGE;
        int numControlMA_IGE;
        double mejorPromedioITIC;
        string mejorAlumnoITIC;
        int numControlMA_ITIC;
        double mejorPromedioIIA;
        string mejorAlumnoIIA;
        int numControlMA_IIA;
        frmInforme Informe = new frmInforme();

        public frmDatos()
        {
            InitializeComponent();
            grbAlumnos.Enabled = false;
            grbMaterias.Enabled = false;
            btnCapturarCalificaciones.Enabled = false;
            btnOtraCarrera.Enabled = false;
        }

        private void frmDatos_Load(object sender, EventArgs e)
        {

        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            grbMaterias.Enabled = true;
            cont = 0;
            if (cmbCarreras.Text == "")
            {
                errorProvider1.SetError(cmbCarreras, "Seleccione una carrera o bien ya ha registrado todas las carreras");
                cmbCarreras.Focus();
                return;
            }
            errorProvider1.SetError(cmbCarreras, "");
            switch (cmbCarreras.Text)
            {
                case "IGE":
                    {
                        objIGE.cantidadAlumnos = (int)nudCantidadAlumnos.Value;
                        objIGE.cantidadMaterias = (int)nudCantidadMaterias.Value;

                        objIGE.materias = new string[objIGE.cantidadMaterias];
                        objIGE.nombre = new string[objIGE.cantidadAlumnos];
                        objIGE.NumControl = new int[objIGE.cantidadAlumnos];
                        objIGE.promedios = new double[objIGE.cantidadAlumnos];
                        objIGE.arregloCalificaciones = new int[objIGE.cantidadAlumnos, objIGE.cantidadMaterias];
                        break;
                    }
                case "ITIC":
                    {
                        objITIC.cantidadAlumnos = (int)nudCantidadAlumnos.Value;
                        objITIC.cantidadMaterias = (int)nudCantidadMaterias.Value;

                        objITIC.materias = new string[objITIC.cantidadMaterias];
                        objITIC.nombre = new string[objITIC.cantidadAlumnos];
                        objITIC.NumControl = new int[objITIC.cantidadAlumnos];
                        objITIC.promedios = new double[objITIC.cantidadAlumnos];
                        objITIC.arregloCalificaciones = new int[objITIC.cantidadAlumnos, objITIC.cantidadMaterias];
                        break;
                    }
                case "IIA":
                    {
                        objIIA.cantidadAlumnos = (int)nudCantidadAlumnos.Value;
                        objIIA.cantidadMaterias = (int)nudCantidadMaterias.Value;

                        objIIA.materias = new string[objIIA.cantidadMaterias];
                        objIIA.nombre = new string[objIIA.cantidadAlumnos];
                        objIIA.NumControl = new int[objIIA.cantidadAlumnos];
                        objIIA.promedios = new double[objIIA.cantidadAlumnos];
                        objIIA.arregloCalificaciones = new int[objIIA.cantidadAlumnos, objIIA.cantidadMaterias];
                        break;
                    }
            }
            grbDatosGenerales.Enabled = false;
        }

        private void btnCapturarMateria_Click(object sender, EventArgs e)
        {
            if (txtMateria.Text == "")
            {
                errorProvider1.SetError(txtMateria, "Ingrese materia");
                txtMateria.Focus();
                return;
            }
            errorProvider1.SetError(txtMateria, "");

            switch (cmbCarreras.Text)
            {
                case "IGE":
                    {
                        if (cont <= objIGE.cantidadMaterias)
                        {
                            objIGE.materias[cont] = Convert.ToString(txtMateria.Text);
                            cont++;
                            txtMateria.Text = "";
                        }

                        if (cont == objIGE.cantidadMaterias)
                        {
                            MessageBox.Show("Se han registrado correctamente las " + cont + " materias", "Materias");
                            grbMaterias.Enabled = false;
                            grbAlumnos.Enabled = true;
                            cont = 0;
                        }

                        break;
                    }
                case "ITIC":
                    {
                        if (cont <= objITIC.cantidadMaterias)
                        {
                            objITIC.materias[cont] = Convert.ToString(txtMateria.Text);
                            cont++;
                            txtMateria.Text = "";
                        }

                        if (cont == objITIC.cantidadMaterias)
                        {
                            MessageBox.Show("Se han registrado correctamente las " + cont + " materias", "Materias");
                            grbMaterias.Enabled = false;
                            grbAlumnos.Enabled = true;
                            cont = 0;
                        }
                        break;
                    }
                case "IIA":
                    {
                        if (cont <= objIIA.cantidadMaterias)
                        {
                            objIIA.materias[cont] = Convert.ToString(txtMateria.Text);
                            cont++;
                            txtMateria.Text = "";
                        }

                        if (cont == objIIA.cantidadMaterias)
                        {
                            MessageBox.Show("Se han registrado correctamente las " + cont + " materias", "Materias");
                            grbMaterias.Enabled = false;
                            grbAlumnos.Enabled = true;
                            cont = 0;
                        }
                        break;
                    }
            }
        }

        private void btnCapturarDatosAlumno_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Ingrese nombre completo del alumno");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            if (txtNumeroControl.Text == "")
            {
                errorProvider1.SetError(txtNumeroControl, "Ingrese nombre completo del alumno");
                txtNumeroControl.Focus();
                return;
            }
            errorProvider1.SetError(txtNumeroControl, "");

            decimal nControl;
            if (!Decimal.TryParse(txtNumeroControl.Text, out nControl))
            {
                errorProvider1.SetError(txtNumeroControl, "Debe ingresar unicamente números en el campo Número de control");
                txtNumeroControl.Focus();
                return;
            }
            errorProvider1.SetError(txtNumeroControl, "");



            switch (cmbCarreras.Text)
            {
                case "IGE":
                    {
                        if (cont <= objIGE.cantidadAlumnos)
                        {
                            objIGE.nombre[cont] = Convert.ToString(txtNombre.Text);
                            objIGE.NumControl[cont] = int.Parse(txtNumeroControl.Text);
                            cont++;
                            txtNombre.Text = "";
                            txtNumeroControl.Text = "";
                        }

                        if (cont == objIGE.cantidadAlumnos)
                        {
                            MessageBox.Show("Se han registrado correctamente los " + cont + " alumnos", "Alumnos");
                            grbAlumnos.Enabled = false;
                            btnCapturarCalificaciones.Enabled = true;
                        }
                        break;
                    }
                case "ITIC":
                    {
                        if (cont <= objITIC.cantidadAlumnos)
                        {
                            objITIC.nombre[cont] = Convert.ToString(txtNombre.Text);
                            objITIC.NumControl[cont] = int.Parse(txtNumeroControl.Text);
                            cont++;
                            txtNombre.Text = "";
                            txtNumeroControl.Text = "";
                        }

                        if (cont == objITIC.cantidadAlumnos)

                        {
                            MessageBox.Show("Se han registrado correctamente los " + cont + " alumnos", "Alumnos");
                            grbAlumnos.Enabled = false;
                            btnCapturarCalificaciones.Enabled = true;
                        }
                        break;
                    }


                case "IIA":
                    {
                        if (cont <= objIIA.cantidadAlumnos)
                        {
                            objIIA.nombre[cont] = Convert.ToString(txtNombre.Text);
                            objIIA.NumControl[cont] = int.Parse(txtNumeroControl.Text);
                            cont++;
                            txtNombre.Text = "";
                            txtNumeroControl.Text = "";
                        }

                        if (cont == objIIA.cantidadAlumnos)
                        {
                            MessageBox.Show("Se han registrado correctamente los " + cont + " alumnos", "Alumnos");
                            grbAlumnos.Enabled = false;
                            btnCapturarCalificaciones.Enabled = true;
                        }
                        break;
                    }

            }

        }


        private void btnCapturarCalificaciones_Click(object sender, EventArgs e)
        {
            switch (cmbCarreras.Text)
            {
                case "IGE":
                    {
                        for (int a = 0; a < objIGE.cantidadAlumnos; a++)
                        {
                            for (int m = 0; m < objIGE.cantidadMaterias; m++)
                            {
                                objIGE.arregloCalificaciones[a, m] = Convert.ToInt16(Interaction.InputBox("Ingrese calificaciones del alumno: " + objIGE.nombre[a] + "\nMateria: " + objIGE.materias[m], "Captura de calificaciones"));
                            }
                        }
                        MessageBox.Show("Las calificaciones se han capturado correctamente", "Calificaciones");
                        //Metodos
                        objIGE.calcularPromedio();
                        objIGE.calcularPromedioGrupal();
                        imprimirDatosIGE();
                        //objIGE.promedioGralGrupal = promedioCarreras[0];
                        btnCapturarCalificaciones.Enabled = false;
                        btnOtraCarrera.Enabled = true;
                        break;
                    }
                case "ITIC":
                    {
                        for (int a = 0; a < objITIC.cantidadAlumnos; a++)
                        {
                            for (int m = 0; m < objITIC.cantidadMaterias; m++)
                            {
                                objITIC.arregloCalificaciones[a, m] = Convert.ToInt16(Interaction.InputBox("Ingrese la calificaciones del alumno: " + objITIC.nombre[a] + "\nMateria: " + objITIC.materias[m], "Captura de calificaciones"));
                            }
                        }
                        MessageBox.Show("Las calificaciones se han capturado correctamente", "Calificaciones");
                        //Metodos
                        objITIC.calcularPromedio();
                        objITIC.calcularPromedioGrupal();
                        imprimirDatosITIC();
                        //objITIC.promedioGralGrupal = promedioCarreras[1];
                        btnCapturarCalificaciones.Enabled = false;
                        btnOtraCarrera.Enabled = true;
                        break;
                    }
                case "IIA":
                    {
                        for (int a = 0; a < objIIA.cantidadAlumnos; a++)
                        {
                            for (int m = 0; m < objIIA.cantidadMaterias; m++)
                            {
                                objIIA.arregloCalificaciones[a, m] = Convert.ToInt16(Interaction.InputBox("Ingrese la calificaciones del alumno: " + objIIA.nombre[a] + "\nMateria: " + objIIA.materias[m], "Captura de calificaciones"));
                            }
                        }
                        MessageBox.Show("Las calificaciones se han capturado correctamente", "Calificaciones");
                        //Metodos
                        objIIA.calcularPromedio();
                        objIIA.calcularPromedioGrupal();
                        imprimirDatosIIA();
                        //objIIA.promedioGralGrupal = promedioCarreras[2];
                        btnCapturarCalificaciones.Enabled = false;
                        btnOtraCarrera.Enabled = true;
                        break;
                    }
            }
        }

        private void btnOtraCarrera_Click(object sender, EventArgs e)
        {
            grbDatosGenerales.Enabled = true;
            cmbCarreras.Items.RemoveAt(cmbCarreras.SelectedIndex);
            cmbCarreras.SelectedIndex = -1;
            nudCantidadAlumnos.Value = nudCantidadAlumnos.Minimum;
            nudCantidadMaterias.Value = nudCantidadMaterias.Minimum;
            grbMaterias.Enabled = false;
            grbAlumnos.Enabled = false;
            btnCapturarCalificaciones.Enabled = false;
            btnInforme.Enabled = true;
            btnOtraCarrera.Enabled = false;
        }


        public void imprimirDatosIGE()
        {

            string datosIGE = "";
            for (int i = 0; i < objIGE.cantidadAlumnos; i++)
            {
                string datos = objIGE.imprimirDatos();
                datosIGE += datos + Environment.NewLine;
                objIGE.k++;
                objIGE.i++;
            }
            MessageBox.Show(datosIGE, "Calificaciones alumnos IGE");
        }

        public void imprimirDatosITIC()
        {

            string datosITIC = "";
            for (int i = 0; i < objITIC.cantidadAlumnos; i++)
            {
                string datos = objITIC.imprimirDatos();
                datosITIC += datos + Environment.NewLine;
                objITIC.k++;
                objITIC.i++;
            }
            MessageBox.Show(datosITIC, "Calificaciones alumnos ITIC");
        }

        public void imprimirDatosIIA()
        {

            string datosIIA = "";
            for (int i = 0; i < objIIA.cantidadAlumnos; i++)
            {
                string datos = objIIA.imprimirDatos();
                datosIIA += datos + Environment.NewLine;
                objIIA.k++;
                objIIA.i++;
            }
            MessageBox.Show(datosIIA, "Calificaciones alumnos IIA");
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            carreraMejorPromedio();
            MejorPromedioIGE();
            MejorPromedioITIC();
            MejorPromedioIIA();
            Informe.Show();
        }

        public void carreraMejorPromedio()
        {
            double[] promedioCarreras = { objIGE.promedioGralGrupal, objITIC.promedioGralGrupal, objIIA.promedioGralGrupal };
            string[] carreras = { "IGE", "ITIC", "IIA" };
            { for (int i = 0; i < promedioCarreras.Length; i++)
                {
                    if (promedioCarreras[i] > mejorPromedio)
                    {
                        mejorPromedio = promedioCarreras[i];
                        mejorCarrera = carreras[i];
                    }
                }
                Informe.lblCarrera.Text = mejorCarrera;
                Informe.lblPromedio.Text = mejorPromedio.ToString();
            }

            
        }public void MejorPromedioIGE()
            {
                for (int i = 0; i < objIGE.promedios.Length; i++)
                {
                    if (objIGE.promedios[i] > mejorPromedioIGE)
                    {
                        mejorPromedioIGE = objIGE.promedios[i];
                        mejorAlumnoIGE = objIGE.nombre[i];
                        numControlMA_IGE = objIGE.NumControl[i];
                    }
                }
                Informe.lblNombreAlumnoIGE.Text = mejorAlumnoIGE;
                Informe.lblNumControlIGE.Text = numControlMA_IGE.ToString();
                Informe.lblPromedioFinaIIGE.Text = mejorPromedioIGE.ToString();
            }
            public void MejorPromedioITIC()
            {
                for (int i = 0; i < objITIC.promedios.Length; i++)
                {
                    if (objITIC.promedios[i] > mejorPromedioITIC)
                    {
                        mejorPromedioITIC = objITIC.promedios[i];
                        mejorAlumnoITIC = objITIC.nombre[i];
                        numControlMA_ITIC = objITIC.NumControl[i];
                    }
                }
                Informe.lblNombreAlumnoITIC.Text = mejorAlumnoITIC;
                Informe.lblNumControlITIC.Text = numControlMA_ITIC.ToString();
                Informe.lblPromedioFinalITIC.Text = mejorPromedioITIC.ToString();
            }
            public void MejorPromedioIIA()
            {
                for (int i = 0; i < objIIA.promedios.Length; i++)
                {
                    if (objIIA.promedios[i] > mejorPromedioIIA)
                    {
                        mejorPromedioIIA = objIIA.promedios[i];
                        mejorAlumnoIIA = objIIA.nombre[i];
                        numControlMA_IIA = objIIA.NumControl[i];
                    }
                }
                Informe.lblNombreAlumnoIIA.Text = mejorAlumnoIIA;
                Informe.lblNumControlIIA.Text = numControlMA_IIA.ToString();
                Informe.lblPromedioFinalIIA.Text = mejorPromedioIIA.ToString();
            }
    }
}




