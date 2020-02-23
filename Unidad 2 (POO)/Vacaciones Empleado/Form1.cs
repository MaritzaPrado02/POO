using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vacaciones_Empleado
{
    public partial class frmAñosTrabajadosEmpleado : Form
    {
        claseEmpleado objEmpleado = new claseEmpleado();
        public frmAñosTrabajadosEmpleado()
        {
            InitializeComponent();
        }

        private void frmAñosTrabajadosEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcularVacaciones_Click(object sender, EventArgs e)
        {
            objEmpleado.aniosTrabajados = Convert.ToInt32(txtAñosTrabajados.Text);
            objEmpleado.calcularVacaciones();
            txtCantidadDias.Text = objEmpleado.diasVacaciones.ToString();
        }
    }
}
