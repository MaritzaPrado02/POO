using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Paises_
{
    class DatosPaises
    {
        public string nombrePais { get; set; }
        public int numHabitantes { get; set; }
        public string idioma { get; set; }
        public string[] colores { get; set; }

        public DatosPaises()
        {
            colores = new string[3];
        }

        public string imprimirDatos()
        {
            var cadena = " Pais: " + nombrePais + "\n Habitantes: " + numHabitantes.ToString() +
                "\n Idioma: " + idioma + "\n Colores: ";

            for (int  i = 0;  i < colores.Length;  i++)
            {
                cadena += colores[i] + ", ";
            }
            cadena += "\n";
            return cadena;
        }

    }
}
