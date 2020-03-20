using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazEjercicio1
{
    class claseExamen : IPromedioExamen
    {

        /*Ejercicio propuesto: (Descrito en un documento que se se puede encontrar
          en Investigacion y ejercicio propuesto/Descripción Ejercicio Propuesto
          (Prado Maritza, POO)*
          Descrición Breve: 
          Un profesor necesita un programa el cual le ayude a calcular el promedio 
          de los examenes de sus alumnos tomando en cuenta los aciertos y total de aciertos
          para así poder calcular el promedio del examen de cada alumno y este le asigne el 
          mensaje correspondiente con referencia a sus examen con el siguiente rango:
          Promedio (entre 90 y 100) = Excelente
          Promedio (entre 70 y 89) = Suficiente
          Promedio (entre 0 y 69) = Insuficiente*/
        //Atributos de la clase
        double promedio;
        int aciertos;
        int totalRespuestas;
        string mensaje;




        public double Promedio
        {
            get
            {
                return promedio;
            }
            set
            {
                promedio = value;
            }
        }
        public int TotalRespuestas
        {
            get
            {
                return totalRespuestas;
            }
            set
            {
                totalRespuestas = value;
            }
        }
        public int Aciertos
        {
            get
            {
                return aciertos;
            }
            set
            {
                aciertos = value;
            }
        }
        public string Mensaje
        {
            get
            {
                return mensaje;
            }
            set
            {
                mensaje = value;
            }
        }

        public claseExamen()
        {
            mensaje = "";
            totalRespuestas = 0;
            aciertos = 0;
            promedio = 0;
        }


       



        //Metodos que heredo del interface IPromedioExamen
        public void nivelExamen()
        {
            if (promedio >= 90 && Promedio <= 100)
            {
                mensaje = "Excelente";
            }
            else
            {
                if (promedio >= 70 && promedio < 90)
                {
                    mensaje = "Suficiente";
                }
                else
                {
                    mensaje = "Insuficiente";
                }

            }
            //throw new NotImplementedException();
        }

        public void calcularPromedio()
        {
            promedio = (aciertos * 100) / totalRespuestas;
            //throw new NotImplementedException();
        }
    }
}


