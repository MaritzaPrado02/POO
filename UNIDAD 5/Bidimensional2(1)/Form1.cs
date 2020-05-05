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

namespace Bidimensional2_1_
{
    public partial class frmBidimensional : Form
    {
        public frmBidimensional()
        {
            InitializeComponent();
        }

        int i, j;
        String acumArray;
        int[,] arrayBidi = new int[100, 100];

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
                acumArray += "\n";
                for (int j = 0; j < columnas; j++)
                {
                    arrayBidi[i, j] = Convert.ToInt16(Interaction.InputBox("Ingresa el valor " + i + ", " + j));
                    acumArray += arrayBidi[i, j] + ", ";
                }
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(acumArray, "Elementos del arreglo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

        }
    }
}
