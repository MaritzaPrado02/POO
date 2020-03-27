using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Preguntas
{
    class Ciencia : categoriaPreguntas
    {
        //CATEGORIA CIENCIA

            //Constructor de la clase (Ciencia)
        public Ciencia()
        {
            Respuesta1 = " ";
            Respuesta2 = " ";
            Respuesta3 = " ";
            Correctas = 0;
            Calificar = " "; 
        }

        //1. Simbolo de Sodio:
        public override void Pregunta1()
        {
            if (Respuesta1 == "Na")
            {
                Calificar = "C";
            }
            else
            {
                if (Respuesta1 != "Na")
                {
                    Calificar = "I";
                }
            }
            //throw new NotImplementedException();
        }

        //2. Fuerza física que la tierra ejerce sobre los cuerpos
        public override void Pregunta2()
        {
            if (Respuesta2 == "Gravedad")
            {
                Calificar = "C";
            }
            else
            {
                if (Respuesta2 != "Gravedad")
                {
                    Calificar = "I";
                }
            }
            //throw new NotImplementedException();
        }

        //3. Particulas subatomicas con carga electrica negativa
        public override void Pregunta3()
        {
            if (Respuesta3 == "Electrones")
            {
                Calificar = "C";
            }
            else
            {
                if (Respuesta3 != "Electrones")
                {
                    Calificar = "I";
                }
            }
            //throw new NotImplementedException();
        }



        public override void ResCorrectas()
        {
            if (Respuesta1 == "Na")
            {
                Correctas = Correctas + 1;
            }

            if (Respuesta2 == "Gravedad")
            {
                Correctas = Correctas + 1;
            }

            if (Respuesta3 == "Electrones")
            {
                Correctas = Correctas + 1;
            }
            //throw new NotImplementedException();
        }
    }
}
