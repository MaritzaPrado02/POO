using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoRestaurante
{
    class Mesero:Empleado
    {
        //Atributos propios de su clase
        double propinaSemanal;

        public double PropinaSemanal
        {
            get
            {
                return propinaSemanal;
            }
            set
            {
                propinaSemanal = value;
            }
        }

        public Mesero()
        {
            propinaSemanal = 0;
        }
        public override void calcularSueldo()
        {
            Sueldo = (SueldoDiario * DiasTrabajados) + propinaSemanal;
            
        }
    }
}
