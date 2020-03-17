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
    public partial class frmCajero : Form
    {
        Cajero objCajero = new  Cajero();
        public frmCajero()
        {
            InitializeComponent();
        }

        private void btnCalcularSueldoCaj_Click(object sender, EventArgs e)
        {
            objCajero.SueldoDiario = double.Parse(txtSueldoDiarioCaj.Text);
            objCajero.DiasTrabajados = int.Parse(cmbDiasTrabajadosCaj.Text);
            objCajero.NumCaja = int.Parse(cmbCaja.Text);
            objCajero.calcularSueldo();
            lblSueldoFinalCaj.Text = Convert.ToString(objCajero.Sueldo);
        }
    }
}
