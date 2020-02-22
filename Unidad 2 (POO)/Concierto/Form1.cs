using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concierto
{
    
    public partial class frmConcierto : Form
    {
        ClasePersona objPersona = new ClasePersona();
        public frmConcierto()
        {
            InitializeComponent(); //constructor de cmb
        }

        private void btnContabilizar_Click(object sender, EventArgs e)
        {

            objPersona.persona = Convert.ToString(cmbAsistentes.Text); // 1
            objPersona.cantidad = Convert.ToInt32(cmbCantidad.Text);   // 2
            objPersona.personasContabilizadas();
            MessageBox.Show("Registrados");
            //objPersona.persona = cmbAsistente.SelectedItem.ToString(); (este se puede utilizar para leer asistente(1))
            //objPersona.cantidad = int.Parse(cmbCantidad.Text); (este se puede utilizar para leer un valor de tipo entero o numerico(2))
           // cmbAsistentes.Text = (" ");
            //cmbCantidad.Text = (" ");
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            txtBebés.Text = objPersona.bebes.ToString();
            txtNiños.Text = objPersona.niños.ToString();
            txtAdultos.Text = objPersona.adultos.ToString();
            txtTerceraEdad.Text = objPersona.adultosTerceraEdad.ToString();
            
        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void frmConcierto_Load(object sender, EventArgs e)
        {
            //se puede poner las colecciones de Items
        }
    }
}
