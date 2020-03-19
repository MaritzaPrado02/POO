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
    public partial class frmTri_Isoceles : Form
    {
        Isoceles objIsoceles = new Isoceles();
        public frmTri_Isoceles()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objIsoceles.LadoA = double.Parse(txtLadoA.Text);
            objIsoceles.LadoB = double.Parse(txtLadoB.Text);
            objIsoceles.LadoC = double.Parse(txtLadoC.Text);
            objIsoceles.Altura = double.Parse(txtAltura.Text);
            objIsoceles.calcArea();
            objIsoceles.calcPerimetro();
            lblRArea.Text = Convert.ToString(objIsoceles.Area);
            lblRPerimetro.Text = Convert.ToString(objIsoceles.Perimetro);
        }
    }
}
