using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4AlumnosMaestrosUnidad6
{
    public partial class Form1 : Form
    {
        frmAlumno pantallaAlumno = new frmAlumno();
        frmMaestro pantallaMaestro = new frmMaestro();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (cmbOcupacion.Text == "Alumno")
            {
                pantallaAlumno.Show();                
            }
            else
            {
                if (cmbOcupacion.Text == "Maestro")
                {
                    pantallaMaestro.Show();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
