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

namespace MatrizSumaFCD
{
    public partial class frmMatrizSumaFCD : Form
    {
        claseMatriz objMatriz = new claseMatriz();
        public frmMatrizSumaFCD()
        {
            InitializeComponent();
            grbFilas.Enabled = false;
            grbColumnas.Enabled = false;
            grbDiagonal.Enabled = false;
            btnImprimirMatriz.Enabled = false;
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
            grbColumnas.Enabled = true;
            grbDiagonal.Enabled = true;
        }

        private void btnSumarFila_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < objMatriz.sumaFilas.GetLength(0); i++)
            {
                rtbSumaFila.Text += objMatriz.sumaFilas[i] + " ";
            }

            txtSumaSumaFila.Text = objMatriz.sumaSumaFilas.ToString();
        }

        private void btnSumarColumnas_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < objMatriz.sumaColumnas.GetLength(0); i++)
            {
                rtbSumaColumnas.Text += objMatriz.sumaColumnas[i] + " ";
            }
            txtSumaSumaColumna.Text = objMatriz.sumaSumaColumnas.ToString();
        }

        private void btnSumarDiagonal_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < objMatriz.elementosDiagonal.GetLength(0); i++)
            {
                rtbElementosDiagonal.Text += objMatriz.elementosDiagonal[i] + " ";
            }
            txtSumaDiagonal.Text = objMatriz.sumaDiagonal.ToString();
        }
        
    }
}
    

