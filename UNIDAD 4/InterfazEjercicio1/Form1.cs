using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InterfazEjercicio1
{
    public partial class frmExamen : Form
    {
        claseExamen objPromedio = new claseExamen();
        public frmExamen()
        {
            InitializeComponent();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            objPromedio.TotalRespuestas = int.Parse(txtTotalRespuestas.Text);
            objPromedio.Aciertos = int.Parse(txtAciertos.Text);
            objPromedio.calcularPromedio();
            objPromedio.nivelExamen();
            txtPromedio.Text = Convert.ToString(objPromedio.Promedio);
            lblNivel.Text = Convert.ToString(objPromedio.Mensaje);

        }
    }
}
