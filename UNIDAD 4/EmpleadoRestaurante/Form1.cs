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
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmSueldoEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnCapturarDatos_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Introduce el nombre");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            if (cmbTipoEmpleado.Text == "")
            {
                errorProvider1.SetError(cmbTipoEmpleado, "Seleccione el tipo empleado");
                cmbTipoEmpleado.Focus();
                return;
            }
            errorProvider1.SetError(cmbTipoEmpleado, "");

            MessageBox.Show("Datos capturados exitosamente");
        }


        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            switch (cmbTipoEmpleado.Text)
            {
                case "Mesero":
                    {
                        frmMesero sueldoMesero = new frmMesero();
                        sueldoMesero.Show();
                        break;
                    }
                case "Repartidor":
                    {
                        frmRepartidor sueldoRepartidor = new frmRepartidor();
                        sueldoRepartidor.Show();
                        break;
                    }
                case "Cajero":
                    {

                        frmCajero sueldoCajero = new frmCajero();
                        sueldoCajero.Show();
                        break;
                    }
            }
            
            
            
        }
    }
}
