using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captura_de_datos
{
    public partial class frmCapturaDatosPersona : Form
    {
        ClaseDatos objdatos = new ClaseDatos();
       
        public frmCapturaDatosPersona()
        {
            InitializeComponent();
        }

        private void frmCapturaDatosPersona_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            {
                objdatos.nombre = Convert.ToString(txtNombre.Text);
                objdatos.apellidoPaterno = Convert.ToString(txtApellidoPaterno.Text);
                objdatos.apellidoMaterno = Convert.ToString(txtApellidoMaterno.Text);
                objdatos.fechaNacimiento = Convert.ToInt32(dtpFechaDeNacimiento);
               
                


            }
            MessageBox.Show("El usuario a sido registrado");
            txtNombre.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            cmbEstado.Text = (" ");
            cmbTipoPersona.Text = (" ");
            txtTelefono.Clear();
            
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            this.Hide(); //Funcion para esconder este Form y abrir uno nuevo


            VentanaDeInforme v1 = new VentanaDeInforme();
            v1.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //objfecha.identificarMayorEdad(2002, 03, 20, 2020, 02, 20);
            //MessageBox.Show(objfecha.contadorMayoresEdad.ToString());
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
