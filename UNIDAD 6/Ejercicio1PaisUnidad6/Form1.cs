using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Ejercicio1PaisUnidad6
{
    public partial class frmRegistrarPais : Form
    {
        Pais datosPais = new Pais();
        TextWriter archivo;
        public frmRegistrarPais()
        {
            InitializeComponent();
            btnAbrir.Enabled = false;
            btnLeer.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistrarPais_Load(object sender, EventArgs e)
        {
            archivo = new StreamWriter("ArchivoDatosPais.txt");
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbNombrePais.Text == "")
            {
                errorProvider1.SetError(cmbNombrePais, "Debe seleccionar país");
                cmbNombrePais.Focus();
                return;
            }
            errorProvider1.SetError(cmbNombrePais, "");

            decimal numHabitantes;
            if (!Decimal.TryParse(txtNumHabitantes.Text, out numHabitantes))
            {
                errorProvider1.SetError(txtNumHabitantes, "Debe ingresar números en el campo de habitantes");
                txtNumHabitantes.Focus();
                return;
            }
            errorProvider1.SetError(txtNumHabitantes, "");

            if (cmbIdioma.Text == "")
            {
                errorProvider1.SetError(cmbIdioma, "Debe seleccionar un idioma");
                cmbIdioma.Focus();
                return;
            }
            errorProvider1.SetError(cmbIdioma, "");

            if (txtColor1.Text == "")
            {
                errorProvider1.SetError(txtColor1, "Debe ingresar un color");
                txtColor1.Focus();
                return;
            }
            errorProvider1.SetError(txtColor1, "");

            if (txtColor2.Text == "")
            {
                errorProvider1.SetError(txtColor2, "Debe ingresar color");
                txtColor2.Focus();
                return;
            }
            errorProvider1.SetError(txtColor2, "");

            if (txtColor3.Text == "")
            {
                errorProvider1.SetError(txtColor3, "Debe ingresar color o en su defecto ingrese (sin color)");
                txtColor3.Focus();
                return;
            }
            errorProvider1.SetError(txtColor3, "");

            Pais datosPais = new Pais();
            datosPais.nombrePais = cmbNombrePais.Text;
            datosPais.numHabitantes = Convert.ToInt32(txtNumHabitantes.Text);
            datosPais.idioma = cmbIdioma.Text;
            datosPais.colores[0] = txtColor1.Text;
            datosPais.colores[1] = txtColor2.Text;
            datosPais.colores[2] = txtColor3.Text;

            MessageBox.Show(" Pais: " + datosPais.nombrePais + "\n Habitantes: " + datosPais.numHabitantes + "\n Idioma: " + datosPais.idioma + "\n Colores Bandera: " + datosPais.colores[0] + ", " + datosPais.colores[1] + ", " + datosPais.colores[2], "País Registrado");
            archivo.WriteLine(" Pais: " + datosPais.nombrePais + "\n Habitantes: " + datosPais.numHabitantes + "\n Idioma: " + datosPais.idioma + "\n Colores Bandera: " + datosPais.colores[0] + ", " + datosPais.colores[1] + ", " + datosPais.colores[2]);
            archivo.Close();
            MessageBox.Show("Los datos han sido guardados en un archivo", "Guardados exitosamente");
            btnLeer.Enabled = true;
            btnAbrir.Enabled = true;
            limpiarControles();
        }

        public void limpiarControles()
        {
            cmbNombrePais.SelectedIndex = 0;
            txtNumHabitantes.Clear();
            cmbIdioma.SelectedIndex = 0;
            txtColor1.Clear();
            txtColor2.Clear();
            txtColor3.Clear();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            TextReader leerArchivo;

            leerArchivo = new StreamReader("ArchivoDatosPais.txt");

            MessageBox.Show(leerArchivo.ReadToEnd(), "ArchivoDatosPais.txt");
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Process.Start("ArchivoDatosPais.txt");
        }
    }
}
