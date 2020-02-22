using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perimetro_y_Area
{
    public partial class frmCuadrado : Form
    {
        claseCuadrado objCuadrado = new claseCuadrado();
        
        public frmCuadrado()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            objCuadrado.lado = Convert.ToInt32(txtLado.Text);
            objCuadrado.calcularPerimetro();
            objCuadrado.calcularArea();

            txtPerimetro.Text = objCuadrado.perimetro.ToString();
            txtArea.Text = objCuadrado.area.ToString();
        }
    }
}
