using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1PaisUnidad6
{
    class Pais
    {
        public string nombrePais { get; set; }
        public int numHabitantes { get; set; }
        public string idioma { get; set; }
        public string[] colores { get; set; }

        public Pais()
        {
            colores = new string[3];
        }
    }
}
