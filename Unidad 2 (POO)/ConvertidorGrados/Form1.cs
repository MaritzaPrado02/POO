using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertidorGrados
{
    public partial class frmConvertidor : Form
    {
        claseTemperatura objGrados = new claseTemperatura();

        public frmConvertidor()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            objGrados.grados = Convert.ToInt32(txtTemperatura.Text);
            objGrados.sistema = Convert.ToString(cmbTemperatura.Text);
            objGrados.convertirTemperatura();
            txtResultadoConversion.Text = objGrados.conversion.ToString();
            lblGradosResultado.Text = objGrados.establecerSistema().ToString(); 
        }

        private void lblGradosResultado_Click(object sender, EventArgs e)
        {
            
        }
    }
}
