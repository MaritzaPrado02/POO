using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoRestaurante
{
    class Cajero:Empleado
    {
        //Atribtutos propios de la clase
        int numCaja;

        public int NumCaja
        {
            get
            {
                return numCaja;
            }
            set
            {
                numCaja = value;
            }
        }

        public Cajero()
        {
            numCaja = 0;
        }

        public override void calcularSueldo()
        {
            if (numCaja == 1)
            {
                Sueldo = (SueldoDiario * DiasTrabajados)+ ((SueldoDiario * DiasTrabajados) * .03);
            }
            else
            {
                Sueldo = SueldoDiario * DiasTrabajados;
            }
            
        }
    }
}
