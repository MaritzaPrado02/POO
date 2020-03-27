using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Preguntas
{
    class Cine : categoriaPreguntas
    {
        //CATEGORIA CULTURA

            //Constructor de la clase (Cine)
        public Cine()
        {
            Respuesta1 = " ";
            Respuesta2 = " ";
            Respuesta3 = " ";
            Correctas = 0;
            Calificar = " ";
        }

        //1. ¿Como se llama el burro que siempre acompaña a Shrek?
        public override void Pregunta1()
        {
            if (Respuesta1 == "Burro")
            {
                Calificar = "C";
            }
            else
            {
                if (Respuesta1 != "Burro")
                {
                    Calificar = "I";
                }
            }
            //throw new NotImplementedException();
        }

        //2. Protagonistas de Titanic
        public override void Pregunta2()
        {
            if (Respuesta2 == "Rose y Jack")
            {
                Calificar = "C";
            }
            else
            {
                if (Respuesta2 != "Rose y Jack")
                {
                    Calificar = "I";
                }
            }
            //throw new NotImplementedException();
        }

        //3. Protagonista de La Sirenita
        public override void Pregunta3()
        {
            if (Respuesta3 == "Ariel")
            {
                Calificar = "C";
            }
            else
            {
                if (Respuesta3 != "Ariel")
                {
                    Calificar = "I";
                }
            }
            //throw new NotImplementedException();
        }

        public override void ResCorrectas()
        {
            if (Respuesta1 == "Burro")
            {
                Correctas = Correctas + 1;
            }

            if (Respuesta2 == "Rose y Jack")
            {
                Correctas = Correctas + 1;
            }

            if (Respuesta3 == "Ariel")
            {
                Correctas = Correctas + 1;
            }
            //throw new NotImplementedException();
        }
    }
}
