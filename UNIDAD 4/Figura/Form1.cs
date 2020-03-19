using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figura
{
    public partial class frmFigura : Form
    {
        string[] array_Figura = { "", "Cuadrado", "Circulo", "Triangulo" };
        string[] array_Triangulo = { "Isoceles", "Equilatero", "Escaleno" };


        public frmFigura()
        {        
            InitializeComponent();
            cargar_cmbFigura();
            cmbFigura.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbFigura_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FiguraCmb = cmbFigura.Text;
            {
                if (FiguraCmb == "Triangulo")
                {
                    cargar_TipoTriangulo();
                }
            }
        }

        private void frmFigura_Load(object sender, EventArgs e)
        {

            
        }

        private void cargar_cmbFigura()
        {
            for (int i = 0; i < array_Figura.Length; i++)
            {
                cmbFigura.Items.Add(array_Figura[i].ToString());
            }
        }

        private void cargar_TipoTriangulo()
        {
            for (int i = 0; i < array_Triangulo.Length; i++)
            {
                cmbTriangulo.Items.Add(array_Triangulo[i].ToString());
            }

        }

        private void btnCalcularAreaPerimetro_Click(object sender, EventArgs e)
        {
            switch (cmbFigura.Text)
            {
                case "Cuadrado":
                    {
                        frmCuadrado Cuadrado = new frmCuadrado();
                        Cuadrado.Show();
                        break;
                    }
                case "Circulo":
                    {
                        frmCirculo Circulo = new frmCirculo();
                        Circulo.Show();
                        break;
                    }
                case "Triangulo":
                    {
                        switch (cmbTriangulo.Text)
                        {
                            case "Isoceles":
                                {
                                    frmTri_Isoceles Isoceles = new frmTri_Isoceles();
                                    Isoceles.Show();
                                    break;
                                }
                            case "Equilatero":
                                {
                                    frmTri_Equilatero Equilatero = new frmTri_Equilatero();
                                    Equilatero.Show();
                                    break;
                                }

                            case "Escaleno":
                                {
                                    frmTri_Escaleno Escaleno = new frmTri_Escaleno();
                                    Escaleno.Show();
                                    break;
                                }
                        }
                        break;
                    }
            }
        }
    }
}
