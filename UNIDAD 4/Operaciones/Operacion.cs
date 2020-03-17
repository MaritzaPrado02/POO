using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class Operacion
    {
            
        //Atributos
        double valor1, valor2, resultado;

        public  double Valor1
        {
            get
            {
                return valor1;
            }
            set
            {
                valor1 = value;
            }
        }
        public double Valor2
        {
            get
            {
                return valor2;
            }
            set
            {
                valor2 = value;
            }

        }

        public double Resultado
        {
            get
            {
                return resultado;
            }
            set
            {
                resultado = value;
            }
        }

        public Operacion()
        {
            valor1 = 0;
            valor2 = 0;
            resultado = 0;
        }

        //Metodo 
       public void calcularResultado()
        {
                                      
        }
    }
}
