using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosMayorMenorUnidad6
{
    public class numeros
    {     
        public int mayor { get; set; }
        public int menor { get; set; }
        public int[] arregloNumeros { get; set; }


        public void mayormenor()
        {
            for (int i = 0; i < arregloNumeros.Length; i++)
            {
                if (arregloNumeros[i] > mayor)
                {
                    mayor = arregloNumeros[i];
                }
                if (arregloNumeros[i] < menor)
                {
                    menor = arregloNumeros[i];
                }
            }
        }

    }

}
