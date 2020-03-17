using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehiculos
{
    public partial class frmVehiculo : Form
    {
        Aereo objAereo = new Aereo(); //(Cuanto se ejecuta el new se ejecuta el constructor = new Aereo();)
        
        public frmVehiculo()
        {
            InitializeComponent();
        }

        private void frmVehiculo_Load(object sender, EventArgs e)
        {

        }

        private void btnArrancar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(objAereo.arrancarMotor(txtSonidoArrrancar.Text));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objAereo.tipoCombustible = txtTipoCombustible.Text;
            objAereo.color = txtColor.Text;
            objAereo.numAlas = Convert.ToInt32(txtNumAlas.Text);
            objAereo.numTurbinas = Convert.ToInt32(txtNumTurbinas.Text);
            objAereo.numHelices = Convert.ToInt32(txtNumHelices.Text);
            objAereo.tipoAereo = cmbTipoVehiculo.Text;
            objAereo.numeroLlantas = Convert.ToInt32(txtNumLlantas.Text);
            objAereo.numeroPuertas = Convert.ToInt32(txtNumPuertas.Text);
            objAereo.numeroVentanas = Convert.ToInt32(txtNumVentanas.Text);
            MessageBox.Show("La información del objeto " + objAereo.tipoAereo + " se guardo correctamente");

        }

        private void txtEstadoVuelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
           MessageBox.Show(objAereo.pararMotor(txtSonidoParar.Text));
        }

        private void btnVolar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(objAereo.enVuelo(txtEstadoVuelo.Text));
        }

        private void txtSonidoArrrancar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
