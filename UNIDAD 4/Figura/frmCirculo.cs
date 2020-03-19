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
    public partial class frmCirculo : Form
    {
        Circulo objCirculo = new Circulo();
        public frmCirculo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objCirculo.Radio = double.Parse(txtRadio2.Text);                 
            objCirculo.calcPerimetro();
            objCirculo.calcArea();
            lblRPerimetro.Text = Convert.ToString(objCirculo.Perimetro);
            lblRArea.Text = Convert.ToString(objCirculo.Area);
        }
    }
}
