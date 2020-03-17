using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones
{
    public partial class frmOperacion : Form
    {
        Operacion objOperacion = new Operacion();
        Suma objSuma = new Suma();
        Resta objResta = new Resta();
        Multiplicacion objMultiplicacion = new Multiplicacion();
        Division objDivision = new Division();




        public frmOperacion()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            switch(cmbOperadores.Text)
            {
                case "+":
                    {
                        objSuma.Valor1 = Convert.ToDouble(txtNum1.Text);
                        objSuma.Valor2 = Convert.ToDouble(txtNum2.Text);
                        objSuma.calcularSuma();
                        txtResultado.Text = Convert.ToString(objResta.Resultado);
                        break;
                    }
                case "-":
                    {
                        objResta.Valor1 = Convert.ToDouble(txtNum1.Text);
                        objResta.Valor2 = Convert.ToDouble(txtNum2.Text);
                        objResta.calcularResta();
;                       txtResultado.Text = Convert.ToString(objResta.Resultado);
                        break;
                    }
                case  "*":
                    {
                        objMultiplicacion.Valor1 = Convert.ToDouble(txtNum1.Text);
                        objMultiplicacion.Valor2 = Convert.ToDouble(txtNum2.Text);
                        objMultiplicacion.calcularMultiplicacion();
                        txtResultado.Text = Convert.ToString(objMultiplicacion.Resultado);
                        break;
                    }
                case "/":
                    {
                        objDivision.Valor1 = Convert.ToDouble(txtNum1.Text);
                        objDivision.Valor2 = Convert.ToDouble(txtNum2.Text);
                        objDivision.calcularDivisión();
                        txtResultado.Text = Convert.ToString(objDivision.Resultado);
                        break;
                    }


            }


        }

        private void frmOperacion_Load(object sender, EventArgs e)
        {

        }
    }
}
