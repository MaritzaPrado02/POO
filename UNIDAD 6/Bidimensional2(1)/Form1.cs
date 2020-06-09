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

namespace Bidimensional2_1_
{
    public partial class frmBidimensional : Form
    {
 
        public frmBidimensional()
        {
            InitializeComponent();
            btnAbrir.Enabled = false;
            btnLeer.Enabled = false;
        }

        int i, j;
        String acumArray;
        int[,] arrayBidi = new int[100, 100];

        TextWriter archivo;

       

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtFilas.Text = "";
            txtColumnas.Text = "";
            acumArray = "";
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            int filas, columnas;
            filas = Convert.ToInt16(txtFilas.Text);
            columnas = Convert.ToInt16(txtColumnas.Text);

            int[,] arrayBidi = new int[10, 10];

            for (int i = 0; i < filas; i++)
            {
                
                for (int j = 0; j < columnas; j++)
                {
                    arrayBidi[i, j] = Convert.ToInt16(Interaction.InputBox("Ingresa el valor " + i + ", " + j));
                    acumArray += arrayBidi[i, j] + ", ";
                }
                acumArray += "\n";
            }
        }

        private void frmBidimensional_Load(object sender, EventArgs e)
        {
            archivo = new StreamWriter("ArchivoBidimensional(2).txt");
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            TextReader leerArchivo;

            leerArchivo = new StreamReader("ArchivoBidimensional(2).txt");

            MessageBox.Show(leerArchivo.ReadToEnd(), "ArchivoBidimensional(2).txt");
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Process.Start("ArchivoBidimensional(2).txt");
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(acumArray, "Elementos del arreglo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            archivo.WriteLine(acumArray);
            archivo.Close();
            MessageBox.Show("Los datos han sido guardados en un archivo", "ArchivoBidimensional(2).txt");
            btnLeer.Enabled = true;
            btnAbrir.Enabled = true;
        }
    }
}
