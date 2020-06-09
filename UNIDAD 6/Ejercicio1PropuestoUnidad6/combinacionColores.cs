using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1PropuestoUnidad6
{
    abstract class combinacionColores
    {
        //Atributos de la clase
        string color1;
        string color2;
        string nuevoColor;

        //Acceso de variables

        public string Color1
        {
            get
            {
                return color1;
            }
            set
            {
                color1 = value;
            }
        }

        public string Color2
        {
            get
            {
                return color2;
            }
            set
            {
                color2 = value;
            }
        }

        public string NuevoColor
        {
            get
            {
                return nuevoColor;
            }
            set
            {
                nuevoColor = value;
            }
        }

        //Constructor
        public combinacionColores()
        {
            color1 = " ";
            color2 = " ";
            nuevoColor = " ";
        }

        public abstract void combinar();
    }
}
