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
    public partial class frmTri_Escaleno : Form
    {
        Escaleno objEscaleno = new Escaleno();
        public frmTri_Escaleno()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objEscaleno.LadoA = double.Parse(txtLadoA.Text);
            objEscaleno.LadoB = double.Parse(txtLadoB.Text);
            objEscaleno.LadoC = double.Parse(txtLadoC.Text);
            objEscaleno.Altura = double.Parse(txtAltura.Text);
            objEscaleno.calcArea();
            objEscaleno.calcPerimetro();
            lblRArea.Text = Convert.ToString(objEscaleno.Area);
            lblRPerimetro.Text = Convert.ToString(objEscaleno.Perimetro);
        }
    }
}
