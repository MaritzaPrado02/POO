using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificaciones
{
    public class ClaseCalificacion
    {
        //Atributos de la clase
        public decimal caliCapturada = 0, sumaCal = 0, promedio = 0;

        public int cAprob, cReprob;


        //Metodo de la clase // esto sirve para tal cosa, esta variable 
        public void contarAprobacion() //Metodo para contar los aprobados y reprobados 
        {
            if (caliCapturada < 70)
            {
                cReprob++;
            }
            else if (caliCapturada >= 70 && caliCapturada <= 100)
            {
                cAprob++;
            }
        }


        //public/private son parte del acceso 
        public void sumarCalificaciones() //Metodo para  sumar las calificaciones
        {
            sumaCal += caliCapturada;

        }

        public decimal calcularPromedio() //Metodo para calcular promedio
        {
            promedio = sumaCal / (cAprob + cReprob);

            return promedio; //Se le pone return vacio  para que no moleste, para despues asignar con que va a retornar
                             // Tarea Modificadores de acceso y asignar si son public/private
        }

    }
}
