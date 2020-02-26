using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caseta_Autopista
{
    public partial class frmCaseta : Form
    {
        claseVehiculo objVehiculo = new claseVehiculo();
        public frmCaseta()
        {
            InitializeComponent();
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            objVehiculo.tipoVehiculo = Convert.ToString(cmbVehiculos.Text);
            objVehiculo.precioVehiculo();
            txtPrecio.Text = objVehiculo.precio.ToString();

        }
    }
}
