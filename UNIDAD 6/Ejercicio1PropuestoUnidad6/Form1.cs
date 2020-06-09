using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Ejercicio1PropuestoUnidad6
{
    public partial class frmCombinacionColores : Form
    {
        //Objetos de las clases correspondientes para acceder a los nuevos colores
        Primario_Primario objSecundario = new Primario_Primario();
        Primario_Secundario objTerciario = new Primario_Secundario();

        //Archivo
        TextWriter archivo;
        
        //Se declaran los arreglos que se imprimiran en los ComboBox
        string[] array_Primario = new string[3] { "Rojo", "Amarillo", "Azul" };
        string[] array_Secundario = new string[3] { "Verde", "Violeta", "Naranja" };
        public frmCombinacionColores()
        {
            InitializeComponent();
            cargar_cmbPrimario1();
            cmbPrimario1.SelectedIndex = -1;
            cargar_cmbPrimario2();
            cmbPrimario2.SelectedIndex = -1;
            cargar_cmbPrimario3();
            cmbPrimario3.SelectedIndex = -1;
            cargar_cmbSecundario();
            cmbSecundario.SelectedIndex = -1;
            btnAbrir.Enabled = false;
            btnLeer.Enabled = false;

        }

        private void btnCombinarPP_Click(object sender, EventArgs e)
        {
            
            objSecundario.Color1 = Convert.ToString(cmbPrimario1.Text);
            objSecundario.Color2 = Convert.ToString(cmbPrimario2.Text);
            objSecundario.combinar();

            switch (objSecundario.NuevoColor)
            {
                case "Rojo":
                    {
                        lblNColorS.Text = Convert.ToString(objSecundario.NuevoColor);
                        lblNColorS.BackColor = Color.Red;
                        break;
                    }
                case "Azul":
                    {
                        lblNColorS.Text = Convert.ToString(objSecundario.NuevoColor);
                        lblNColorS.BackColor = Color.DodgerBlue;
                        break;
                    }
                case "Amarillo":
                    {
                        lblNColorS.Text = Convert.ToString(objSecundario.NuevoColor);
                        lblNColorS.BackColor = Color.Yellow;
                        break;
                    }
                case "Verde":
                    {
                        lblNColorS.Text = Convert.ToString(objSecundario.NuevoColor);
                        lblNColorS.BackColor = Color.LawnGreen;
                        break;
                    }
                case "Naranja":
                    {
                        lblNColorS.Text = Convert.ToString(objSecundario.NuevoColor);
                        lblNColorS.BackColor = Color.Orange;
                        break;
                    }
                case "Violeta":
                    {
                        lblNColorS.Text = Convert.ToString(objSecundario.NuevoColor);
                        lblNColorS.BackColor = Color.Purple;
                        break;
                    }
            }
            //cmbPrimario1.SelectedIndex = -1;
            //cmbPrimario2.SelectedIndex = -1;
        }

        public void cargar_cmbPrimario1()
        {
            for (int i = 0; i < array_Primario.Length; i++)
            {
                cmbPrimario1.Items.Add(array_Primario[i].ToString());
            }

        }
        public void cargar_cmbPrimario2()
        {
            for (int i = 0; i < array_Primario.Length; i++)
            {
                cmbPrimario2.Items.Add(array_Primario[i].ToString());
            }
        }
        public void cargar_cmbPrimario3()
        {
            for (int i = 0; i < array_Primario.Length; i++)
            {
                cmbPrimario3.Items.Add(array_Primario[i].ToString());
            }
        }
        public void cargar_cmbSecundario()
        {
            for (int i = 0; i < array_Secundario.Length; i++)
            {
                cmbSecundario.Items.Add(array_Secundario[i].ToString());
            }
        }

        private void btnCombinarPS_Click(object sender, EventArgs e)
        {
            objTerciario.Color1 = Convert.ToString(cmbPrimario3.Text);
            objTerciario.Color2 = Convert.ToString(cmbSecundario.Text);
            objTerciario.combinar();

            switch (objTerciario.NuevoColor)
            {
                case "Rojo Naranja":
                    {
                        lblNColorT.Text = Convert.ToString(objTerciario.NuevoColor);
                        lblNColorT.BackColor = Color.OrangeRed;
                        break;
                    }
                case "Rojo Violeta":
                    {
                        lblNColorT.Text = Convert.ToString(objTerciario.NuevoColor);
                        lblNColorT.BackColor = Color.Crimson;
                        break;
                    }
                case "Amarillo Naranja":
                    {
                        lblNColorT.Text = Convert.ToString(objTerciario.NuevoColor);
                        lblNColorT.BackColor = Color.Gold;
                        break;
                    }
                case "Amarillo Verde":
                    {
                        lblNColorT.Text = Convert.ToString(objTerciario.NuevoColor);
                        lblNColorT.BackColor = Color.GreenYellow;
                        break;
                    }
                case "Azul Verde":
                    {
                        lblNColorT.Text = Convert.ToString(objTerciario.NuevoColor);
                        lblNColorT.BackColor = Color.MediumSpringGreen;
                        break;
                    }
                case "Azul Violeta":
                    {
                        lblNColorT.Text = Convert.ToString(objTerciario.NuevoColor);
                        lblNColorT.BackColor = Color.MediumSlateBlue;
                        break;
                    }
                default:
                    {
                        lblNColorT.Text = Convert.ToString(objTerciario.NuevoColor);
                        lblNColorT.BackColor = Color.White;
                        break;
                    }                   
            }
            //cmbPrimario3.SelectedIndex = -1;
            //cmbSecundario.SelectedIndex = -1;
       
        }

        private void frmCombinacionColores_Load(object sender, EventArgs e)
        {
            archivo = new StreamWriter("ArchivoColores.txt");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbPrimario1.Text + " + " + cmbPrimario2.Text + " = " + objSecundario.NuevoColor + "\n" + cmbPrimario3.Text + " + " + cmbSecundario.Text + " = " + objTerciario.NuevoColor,"Combinaciones realizadas");
            archivo.WriteLine("Combinaciones realizadas" + "\n" + cmbPrimario1.Text + " + " + cmbPrimario2.Text + " = " + objSecundario.NuevoColor + "\n" + cmbPrimario3.Text + " + " + cmbSecundario.Text + " = " + objTerciario.NuevoColor);
            archivo.Close();
            MessageBox.Show("Los datos se han guardado en un archivo", "Guaradados exitosamente");
            btnLeer.Enabled = true;
            btnAbrir.Enabled = true;
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            TextReader leerArchivo;

            leerArchivo = new StreamReader("ArchivoColores.txt");

            MessageBox.Show(leerArchivo.ReadToEnd(), "ArchivoColores.txt");
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Process.Start("ArchivoColores.txt");
        }
    }
}
