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
    public partial class frmRepartidor : Form
    {
        Repartidor objRepartidor = new Repartidor();
        public frmRepartidor()
        {
            InitializeComponent();
        }

        private void frmRepartidor_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcularSueldoRep_Click(object sender, EventArgs e)
        {
            objRepartidor.SueldoDiario = double.Parse(txtSueldoDiarioRep.Text);
            objRepartidor.DiasTrabajados = int.Parse(cmbDiasTrabajadosRep.Text);
            objRepartidor.Zona = int.Parse(cmbZona.Text);
            objRepartidor.PedidosCobradosSem = int.Parse(txtCantidadPedidos.Text);
            objRepartidor.calcularSueldo();
            lblSueldoFinalRep.Text = Convert.ToString(objRepartidor.Sueldo);
           
        }
    }
}
