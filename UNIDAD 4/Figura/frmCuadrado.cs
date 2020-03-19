using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figura
{
    public partial class frmCuadrado : Form
    {
        Cuadrado objCuadrado = new Cuadrado();
        public frmCuadrado()
        {
            InitializeComponent();
        }

        private void frmCuadrado_Load(object sender, EventArgs e)
        {

        }

        private void txtLado_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objCuadrado.Lado = double.Parse(txtLado.Text);
            objCuadrado.calcArea();
            objCuadrado.calcPerimetro();
            lblRArea.Text = Convert.ToString(objCuadrado.Area);
            lblRPerimetro.Text = Convert.ToString(objCuadrado.Perimetro);
        }
    }
}
