using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpleadoRestaurante
{
    public partial class frmMesero : Form
    {
        Mesero objMesero = new Mesero();
        public frmMesero()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objMesero.SueldoDiario = double.Parse(txtSueldoDiario.Text);
            objMesero.DiasTrabajados = int.Parse(cmbDiasTrabajados.Text);
            objMesero.PropinaSemanal = double.Parse(txtPropinaSemanalM.Text);
            objMesero.calcularSueldo();
            lblSueldoFinal.Text = Convert.ToString(objMesero.Sueldo);
        }
    }
}
