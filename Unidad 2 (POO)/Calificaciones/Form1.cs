using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calificaciones
{
    public partial class frmCalificaciones : Form
    {
        ClaseCalificacion objcalificacion = new ClaseCalificacion();
       
        public frmCalificaciones()
        {
            InitializeComponent();
        }

        private void frm_Load(object sender, EventArgs e)
        {

        }

        private void btnCaptura_Click(object sender, EventArgs e)
        {
           
            {
                objcalificacion.caliCapturada = Convert.ToDecimal(txtCalificacion.Text);
                objcalificacion.contarAprobacion();
                objcalificacion.sumarCalificaciones();
                MessageBox.Show("Calificacion Capturada");

            }

           

            txtCalificacion.Clear();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            txtNumAprob.Text = objcalificacion.cAprob.ToString();
            txtNumReprob.Text = objcalificacion.cReprob.ToString();
            txtPromedioGral.Text = objcalificacion.calcularPromedio().ToString();
        }

        private void lblCalificacion_Click(object sender, EventArgs e)
        {
           
        }
    }
}
