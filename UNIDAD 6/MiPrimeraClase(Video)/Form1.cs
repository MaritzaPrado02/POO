using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace MiPrimeraClase_Video_
{
    public partial class frmPersonas : Form
    {
        TextWriter archivo;
        ArrayList Personas = new ArrayList();
        public frmPersonas()
        {
            InitializeComponent();
        }

        private void frmPersonas_Load(object sender, EventArgs e)
        {
            archivo = new StreamWriter("ArchivoPersonas.txt");
            Persona persona1 = new Persona();
            persona1.ID = "1010";
            persona1.Nombres = "Maritza";
            persona1.Apellidos = "Prado";
            persona1.Correo = "maritzaprado.dnm@gmail.com";
            persona1.FechaNacimiento = new DateTime(1999, 6, 2);
            persona1.Salario = 5000;
            Personas.Add(persona1);

            Persona persona2 = new Persona();
            persona2.ID = "2020";
            persona2.Nombres = "Evelyn";
            persona2.Apellidos = "Prado";
            persona2.Correo = "evelynprado.06@gmail.com";
            persona2.FechaNacimiento = new DateTime(2003, 9, 23);
            persona2.Salario = 7000;
            Personas.Add(persona2);

            dgvDatos.DataSource = Personas;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                errorProvider1.SetError(txtID, "Debe ingresar un ID de la persona");
                txtID.Focus();
                return;
            }
            errorProvider1.SetError(txtID, "");

            if (Existe(txtID.Text))
            {
                errorProvider1.SetError(txtID, "ID del empleado ya ha sido registrado");
                txtID.Focus();
                return;
            }
            errorProvider1.SetError(txtID, "");


            if (txtNombres.Text == "")
            {
                errorProvider1.SetError(txtNombres, "Debe ingresar nombre(s) de la persona");
                txtNombres.Focus();
                return;
            }
            errorProvider1.SetError(txtNombres, "");

             if (txtApellidos.Text == "")
            {
                errorProvider1.SetError(txtApellidos, "Debe ingresar apellido(s) de la persona");
                txtApellidos.Focus();
                return;
            }
            errorProvider1.SetError(txtApellidos, "");

            Regex reEmail = new Regex(@"^(([^<>()[\]\\.,;:\s@\""]+"
                                     + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                                     + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}]"
                                     + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                                     + @"[a-zA-Z]{2,}))$", RegexOptions.Compiled);

            if (!reEmail.IsMatch(txtCorreo.Text))
            {
                errorProvider1.SetError(txtCorreo, "Debe ingresar una dirección de correo válida");
                txtCorreo.Focus();
                return;
            }
            errorProvider1.SetError(txtCorreo, "");


            decimal Salario;
            if(!Decimal.TryParse(txtSalario.Text, out Salario))
            {
                errorProvider1.SetError(txtSalario, "Debe ingresar números en el campo salario");
                txtSalario.Focus();
                return;
            }
            //errorProvider1.SetError(txtSalario, "");

            if (Salario < 0)
            {
                errorProvider1.SetError(txtSalario, "Debe ingresar un número positivo");
                txtSalario.Focus();
                return;
            }
            errorProvider1.SetError(txtSalario, "");

            Persona miPersona = new Persona();
            miPersona.ID = txtID.Text;
            miPersona.Nombres = txtNombres.Text;
            miPersona.Apellidos = txtApellidos.Text;
            miPersona.Correo = txtCorreo.Text;
            miPersona.FechaNacimiento = dtpFechaNacimiento.Value;
            miPersona.Salario = Salario;
            Personas.Add(miPersona);

            
            archivo.WriteLine(Personas);
            archivo.Close();


            dgvDatos.DataSource = null;
            dgvDatos.DataSource = Personas;

            txtID.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtSalario.Clear();
            txtID.Focus();


        }

        private bool Existe(string ID)
        {
            foreach (Persona Persona in Personas)
            {
                if (Persona.ID == ID) return true;
            }
            return false;
            //throw new NotImplementedException();
        }

        private void tsBarraHerramientas_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void recolectarDatos()
        {

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            TextReader leerArchivo;

            leerArchivo = new StreamReader("ArchivoPersonas.txt");

            MessageBox.Show(leerArchivo.ReadToEnd());
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Process.Start("ArchivoPersonas.txt");
        }
    }
}
