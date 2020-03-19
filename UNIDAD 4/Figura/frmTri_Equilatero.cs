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
    public partial class frmTri_Equilatero : Form
    {
        Equilatero objEquilatero = new Equilatero();
        public frmTri_Equilatero()
        {
            InitializeComponent();
        }

        private void frmTri_Equilatero_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objEquilatero.Lado = double.Parse(txtLado.Text);
            objEquilatero.calcArea();
            objEquilatero.calcPerimetro();
            lblRArea.Text = Convert.ToString(objEquilatero.Area);
            lblRPerimetro.Text = Convert.ToString(objEquilatero.Perimetro);
        }
    }
}
