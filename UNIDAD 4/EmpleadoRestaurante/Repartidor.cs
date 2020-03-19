using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoRestaurante
{
    class Repartidor:Empleado
    {
        //Atributos propios de su clase
        double propinaSemanalM;
        int  zona; //zona en la que reparte
        int pedidosCobradosSem; //total de abonos cobrados a la semana
       
        public double PropinaSemanalM
        {
            get
            {
                return propinaSemanalM;
            }
            set
            {
                propinaSemanalM = value;
            }      
        }

        public int Zona
        {
            get
            {
                return zona;
            }
            set
            {
                zona = value;
            }
        }

        public int PedidosCobradosSem
        {
            get
            {
                return pedidosCobradosSem;
            }
            set
            {
                pedidosCobradosSem = value;
            }
        }

        public Repartidor()
        {
            propinaSemanalM = 0;
            zona = 0;
            pedidosCobradosSem = 0;
        }
        public override void calcularSueldo()
        {
            if (zona == 1)
            {
                Sueldo = (DiasTrabajados * SueldoDiario) + (pedidosCobradosSem * 5);
            }
            else
            {
                Sueldo = (DiasTrabajados * SueldoDiario) + (pedidosCobradosSem * 2);
            }
        }
    }
}
