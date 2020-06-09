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

namespace Ejercicio2PaisesUnidad6
{
    public partial class frmDatosPaises : Form
    {
        DatosPaises[] arregloPaises;
        int cantidadPaises;
        int cont;
        DatosPaises objDatosPais;
        TextWriter archivo;
        public frmDatosPaises()
        {
            InitializeComponent();
            btnAbrir.Enabled = false;
            btnLeer.Enabled = false;
            nudCantidad.Enabled = true;
        }

        private void frmDatosPaises_Load(object sender, EventArgs e)
        {
            archivo = new StreamWriter("ArchivoDatosPaises.txt");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCantidad_Click(object sender, EventArgs e)
        {
            grbDatosPais.Enabled = true;
            cantidadPaises = (int)nudCantidad.Value;
            nudCantidad.Enabled = false;
            btnCantidad.Enabled = false;
            arregloPaises = new DatosPaises[cantidadPaises];
            cont = 0;
            btnBuscar.Enabled = false;
            btnAgregar.Enabled = true;
            btnImprimir.Enabled = false;
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbPais.Text == "")
            {
                errorProvider1.SetError(cmbPais, "Debe seleccionar país");
                cmbPais.Focus();
                return;
            }
            errorProvider1.SetError(cmbPais, "");

            decimal numHabitantes;
            if (!Decimal.TryParse(txtnumHabitantes.Text, out numHabitantes))
            {
                errorProvider1.SetError(txtnumHabitantes, "Debe ingresar números en el campo de habitantes");
                txtnumHabitantes.Focus();
                return;
            }
            errorProvider1.SetError(txtnumHabitantes, "");

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

            if (cont < cantidadPaises)
            {
                arregloPaises[cont] = new DatosPaises();
                arregloPaises[cont].nombrePais = cmbPais.Text;
                arregloPaises[cont].numHabitantes = int.Parse(txtnumHabitantes.Text);
                arregloPaises[cont].idioma = cmbIdioma.Text;
                arregloPaises[cont].colores[0] = txtColor1.Text;
                arregloPaises[cont].colores[1] = txtColor2.Text;
                arregloPaises[cont].colores[2] = txtColor3.Text;
                cont++;
                MessageBox.Show("Los datos del país han sido registrados exitosamente","País registrado");
                limpiarControles();
                btnBuscar.Enabled = true;
                txtnumHabitantes.Focus();             
            }
            if (cont == cantidadPaises)
            {
                MessageBox.Show("Se han capturado los " + cantidadPaises + " paises.","Registro de paises");
                    grbDatosPais.Enabled = false;
                    nudCantidad.Enabled = true;
                    btnCantidad.Enabled = true;
                    cantidadPaises = 0;
                    btnAgregar.Enabled = false;
                    btnImprimir.Enabled = true;
                    limpiarControles();
            }
        }

        public void limpiarControles()
        {
            cmbPais.SelectedIndex = -1;
            txtnumHabitantes.Clear();
            cmbIdioma.SelectedIndex = -1;
            txtColor1.Clear();
            txtColor2.Clear();
            txtColor3.Clear();
            nudCantidad.Value = nudCantidad.Minimum;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            grbDatosPais.Enabled = true;
            int n = 0;

            for (int i = 0; i < arregloPaises.Length; i++)
            {
                if (cmbPais.Text == arregloPaises[i].nombrePais)
                {
                    MessageBox.Show("Pais encontrado","Búsqueda de país");
                    cmbPais.Text = arregloPaises[i].nombrePais;
                    txtnumHabitantes.Text = arregloPaises[i].numHabitantes.ToString();
                    txtColor1.Text = arregloPaises[i].colores[0];
                    txtColor2.Text = arregloPaises[i].colores[1];
                    txtColor3.Text = arregloPaises[i].colores[2];
                    i = arregloPaises.Length;
                    n = 1;
                }
            }
            if (n == 0)
            {
                MessageBox.Show("El país aun no ha sido registrado","Búsqueda de país");
            }
        
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimirPaises();
            btnLeer.Enabled = true;
            btnAbrir.Enabled = true;
            MessageBox.Show("Los datos se han guardado en un archivo", "Guardados exitosamente");
        }

        public void ImprimirPaises()
        {
            string datosPaises = "";

            for (int i = 0; i < cont; i++)
            {
                string datos = arregloPaises[i].imprimirDatos();
                datosPaises += datos + Environment.NewLine;
            }

            MessageBox.Show(datosPaises);
            archivo.WriteLine(datosPaises);
            archivo.Close();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            TextReader leerArchivo;

            leerArchivo = new StreamReader("ArchivoDatosPaises.txt");

            MessageBox.Show(leerArchivo.ReadToEnd(), "ArchivoDatosPaises.txt");
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Process.Start("ArchivoDatosPaises.txt");
        }
    }
}
