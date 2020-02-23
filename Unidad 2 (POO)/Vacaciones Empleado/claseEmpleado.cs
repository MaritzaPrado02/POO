using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacaciones_Empleado
{
    public class claseEmpleado
    {
        //Atributos
        public int aniosTrabajados;
        public int diasVacaciones;

        //Métodos
        public void calcularVacaciones()
        {
            if (aniosTrabajados >=1 && aniosTrabajados <= 5)
            {
                diasVacaciones = 5;
            }
            else
            {
                if (aniosTrabajados >=6 && aniosTrabajados <= 10)
                {
                    diasVacaciones = 10;
                }
                else
                {
                    if (aniosTrabajados >10 && aniosTrabajados <= 20)
                    {
                        diasVacaciones = 10 + (aniosTrabajados - 10);
                    }
                    else
                    {
                        if (aniosTrabajados > 20 && aniosTrabajados < 32 )
                        {
                            diasVacaciones = 20 + ((aniosTrabajados - 20) * 2);
                        }
                        else
                        {
                            if (aniosTrabajados >= 32 )
                            {
                                diasVacaciones = 45;
                            }
                        }
                    }
                }
            }
        }


    }
}
