using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Preguntas
{
    abstract class categoriaPreguntas : IPreguntas
    {
        //Atributos de la clase (-)
        string respuesta1;
        string respuesta2;
        string respuesta3;
        int correctas;
        string calificar; 

        //Acceso a atributos para otras clases
        public string Respuesta1
        {
            get
            {
                return respuesta1;
            }
            set
            {
                respuesta1 = value;
            }
        }

        public string Respuesta2
        {
            get
            {
                return respuesta2;
            }
            set
            {
                respuesta2 = value;
            }
        }

        public string Respuesta3
        {
            get
            {
                return respuesta3;
            }
            set
            {
                respuesta3 = value;
            }
        }

        public int Correctas
        {
            get
            {
                return correctas;
            }
            set
            {
                correctas = value;
            }
        }

        public string Calificar
        {
            get
            {
                return calificar;
            }
            set
            {
                calificar = value;
            }
        }

        //Constructor de la clase (categoriaPreguntas)
        public categoriaPreguntas()
        {
            respuesta1 = " ";
            respuesta2 = " ";
            respuesta3 = " ";
            correctas = 0;
            calificar = " ";
        }


        /*En los seguientes métodos se evalúa cada una de las preguntas con sus respectivas 
         * respuestas que en este caso son 3 preguntas por categoría de preguntas.*/
        public abstract void Pregunta1();
        public abstract void Pregunta2();
        public abstract void Pregunta3();

        /*En este método se calculan la cantidad de respuestas correctas 
         * (3 puntos, como máximo) de cada sección para obtener puntaje. */
        public abstract void ResCorrectas();
    }
}
