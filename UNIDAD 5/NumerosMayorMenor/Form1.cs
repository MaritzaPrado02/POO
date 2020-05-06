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

namespace NumerosMayorMenor
{
    public partial class frmNumeros : Form
    {
        numeros objNumero;
        int cantidad;
        int cont;

        public frmNumeros()
        {
            InitializeComponent();
            btnImprimir.Enabled = false;
            btnIngresar.Enabled = false;
            txtNumero.Enabled = false;
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
        }
    }
}
