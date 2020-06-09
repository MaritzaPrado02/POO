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
using System.IO;
using System.Diagnostics;

namespace NumerosMayorMenorUnidad6
{
    public partial class frmNumeros : Form
    {
        numeros objNumero;
        int cantidad;
        int cont;
        TextWriter archivo;

        public frmNumeros()
        {
            InitializeComponent();
            btnImprimir.Enabled = false;
            btnIngresar.Enabled = false;
            txtNumero.Enabled = false;
            btnAbrir.Enabled = false;
            btnLeer.Enabled = false;
        
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (cont <= cantidad)
            { 
                objNumero.arregloNumeros[cont] = Convert.ToInt32(txtNumero.Text);
                cont++;
                txtNumero.Text = "";
            }
            
            if (cont == cantidad)
            {
                MessageBox.Show("Se han registrado los " + cont + " números");
                btnImprimir.Enabled = true;
            }

            objNumero.mayor = objNumero.arregloNumeros[0];
            objNumero.menor = objNumero.arregloNumeros[0];
            objNumero.mayormenor();
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            objNumero = new numeros();
            cantidad = (int)nudCantidad.Value;
            cont = 0;
            objNumero.arregloNumeros = new int[cantidad];
            btnIngresar.Enabled = true;
            txtNumero.Enabled = true;

            nudCantidad.Enabled = false;
            btnSeleccionar.Enabled = false;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Número mayor: " + objNumero.mayor + "\nNúmero menor: " + objNumero.menor);
            archivo.WriteLine("Número mayor: " + objNumero.mayor + "\nNúmero menor: " + objNumero.menor);
            archivo.Close();
            MessageBox.Show("Los datos se han guardado en un archivo", "Guardados exitosamente");
            btnLeer.Enabled = true;
            btnAbrir.Enabled = true;
        }

        private void frmNumeros_Load(object sender, EventArgs e)
        {
            archivo = new StreamWriter("ArchivoNumerosMayorMenor.txt");
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            TextReader leerArchivo;

            leerArchivo = new StreamReader("ArchivoNumerosMayorMenor.txt");

            MessageBox.Show(leerArchivo.ReadToEnd(), "ArchivoNumerosMayorMenor.txt");
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Process.Start("ArchivoNumerosMayorMenor.txt");
        }
    }
}
