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

namespace MatrizSumaFCDUnidad6
{
    public partial class frmMatrizSumaFCD : Form
    {
        claseMatriz objMatriz = new claseMatriz();
        TextWriter archivo;
        
        public frmMatrizSumaFCD()
        {
            InitializeComponent();
            grbFilas.Enabled = false;
            grbColumnas.Enabled = false;
            grbDiagonal.Enabled = false;
            btnImprimirMatriz.Enabled = false;
            btnGuardarDatos.Enabled = false;
            btnAbrir.Enabled = false;
            btnLeer.Enabled = false;
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void btnImprimirMatriz_Click(object sender, EventArgs e)
        {
        }

        private void btnCapturar_Click_1(object sender, EventArgs e)
        {
            objMatriz.filas = (int)nudTamanioMatriz.Value;
            objMatriz.columnas = (int)nudTamanioMatriz.Value;

            objMatriz.MatrizNM = new int[objMatriz.filas, objMatriz.columnas];
            objMatriz.sumaFilas = new int[objMatriz.columnas];
            objMatriz.sumaColumnas = new int[objMatriz.filas];
            objMatriz.elementosDiagonal = new int[objMatriz.filas];
           
            for (int f = 0; f < objMatriz.filas; f++)
            {
                for (int c = 0; c < objMatriz.columnas; c++)
                {
                    objMatriz.MatrizNM[f, c] = Convert.ToInt16(Interaction.InputBox("Introduce el elemento [" + f + "][" + c + "]"));
                }
            }

            objMatriz.sumarFilas();
            objMatriz.sumarColumnas();
            objMatriz.sumarDiagonal();

            btnImprimirMatriz.Enabled = true;
            btnCapturar.Enabled = false;
        }

        private void btnImprimirMatriz_Click_1(object sender, EventArgs e)
        {       
            for (int f = 0; f < objMatriz.filas; f++)
            {
                for (int c = 0; c < objMatriz.MatrizNM.GetLength(0); c++)
                {
                    rtbMatrizI.Text += objMatriz.MatrizNM[f, c] + " ";                   
                }
                rtbMatrizI.Text += "\n";
            }

            btnImprimirMatriz.Enabled = false;
            grbFilas.Enabled = true;
            btnSumarFila.Enabled = true; 
            grbColumnas.Enabled = true;
            btnSumarColumnas.Enabled = false;
            grbDiagonal.Enabled = true;
            btnSumarDiagonal.Enabled = false;
        }

        private void btnSumarFila_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < objMatriz.sumaFilas.GetLength(0); i++)
            {
                rtbSumaFila.Text += objMatriz.sumaFilas[i] + " ";
            }

            txtSumaSumaFila.Text = objMatriz.sumaSumaFilas.ToString();
            btnSumarColumnas.Enabled = true;
        }

        private void btnSumarColumnas_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < objMatriz.sumaColumnas.GetLength(0); i++)
            {
                rtbSumaColumnas.Text += objMatriz.sumaColumnas[i] + " ";
            }
            txtSumaSumaColumna.Text = objMatriz.sumaSumaColumnas.ToString();
            btnSumarDiagonal.Enabled = true;
        }

        private void btnSumarDiagonal_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < objMatriz.elementosDiagonal.GetLength(0); i++)
            {
                rtbElementosDiagonal.Text += objMatriz.elementosDiagonal[i] + " ";
            }
            txtSumaDiagonal.Text = objMatriz.sumaDiagonal.ToString();
            btnGuardarDatos.Enabled = true;
        }

        private void frmMatrizSumaFCD_Load(object sender, EventArgs e)
        {
            archivo = new StreamWriter("ArchivoMatrizSumaFCD.txt");
        }

       public void generarArchivo()
        {
            var cadena = "Matriz";
            cadena += "\n" + "\n";
                for (int f = 0; f < objMatriz.filas; f++)
            {
                for (int c = 0; c < objMatriz.MatrizNM.GetLength(0); c++)
                {
                    cadena += objMatriz.MatrizNM[f, c] + " ";
                }
                cadena += "\n";
            }
            cadena += "\n";
            cadena += "\nLa suma de las filas es: ";

            for (int i = 0; i < objMatriz.sumaFilas.GetLength(0); i++)
            {
                cadena += objMatriz.sumaFilas[i] + " , ";
            }

            cadena += "\nLa suma de la suma de las filas es: "+ objMatriz.sumaSumaFilas.ToString();
            cadena += "\n";
            cadena += "\nLa suma de las columnas es: ";


            for (int i = 0; i < objMatriz.sumaColumnas.GetLength(0); i++)
            {
                cadena += objMatriz.sumaColumnas[i] + " , ";
            }
            cadena += "\nLa suma de la suma de las columnas es: " + objMatriz.sumaSumaColumnas.ToString();
            cadena += "\n";
            cadena += "\nLos elementos de la diagonal son: ";
            for (int i = 0; i < objMatriz.elementosDiagonal.GetLength(0); i++)
            {
                cadena += objMatriz.elementosDiagonal[i] + " , ";
            }
            cadena += "\nLa suma de los elementos de la diagonal es: " + objMatriz.sumaDiagonal.ToString();

            archivo.WriteLine(cadena);
            archivo.Close();
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            generarArchivo();
            MessageBox.Show("Los datos han sido guardados en un archivo", "Guardados exitosamente");
            btnLeer.Enabled = true;
            btnAbrir.Enabled = true;
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            TextReader leerArchivo;

            leerArchivo = new StreamReader("ArchivoMatrizSumaFCD.txt");

            MessageBox.Show(leerArchivo.ReadToEnd(), "ArchivoMatrizSumaFCD.txt");
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Process.Start("ArchivoMatrizSumaFCD.txt");
        }
    }
}
    

