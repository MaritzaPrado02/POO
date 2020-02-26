using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mayor_de_edad
{
    public partial class Form1 : Form
    {
        clasePersona objPersona = new clasePersona();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBotonEvaluarEdad_Click(object sender, EventArgs e)
        {
            objPersona.anioActual = int.Parse(DateTime.Today.Year.ToString());
            objPersona.mesActual = int.Parse(DateTime.Today.Month.ToString());
            objPersona.diaActual = int.Parse(DateTime.Today.Day.ToString());
            objPersona.anioNac = int.Parse(dtpFechaNacimiento.Value.Year.ToString());
            objPersona.mesNac = int.Parse(dtpFechaNacimiento.Value.Month.ToString());
            objPersona.diaNac = int.Parse(dtpFechaNacimiento.Value.Day.ToString());
            objPersona.identificarMayorEdad();
            lblMayorDeEdad.Text = objPersona.mensajeMayor;
            objPersona.mensajeMayor = "";
              
        }
    }
}
