using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recibo_Electricidad
{
    public partial class frmElectridad : Form
    {
        claseRecibo objCosto = new claseRecibo();
        public frmElectridad()
        {
            InitializeComponent();
        }

        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {
            objCosto.Kw = Convert.ToInt32(txtCantidadKw.Text);
            objCosto.tipo = Convert.ToString(cmbTipo.Text);
            objCosto.calcularCosto();

            txtCosto.Text = objCosto.costo.ToString();

        }
    }
}
