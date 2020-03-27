using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Preguntas
{
    class Programacion : categoriaPreguntas
    {
        //CATEGORIA PROGRAMACIÓN

            //Constructor de la clase (Programacion)
        public Programacion()
        {
            Respuesta1 = " ";
            Respuesta2 = " ";
            Respuesta3 = " ";
            Correctas = 0;
            Calificar = " ";
        }

        //1. int, float, string son: 
        public override void Pregunta1()
        {
            if (Respuesta1 == "Tipos de datos")
            {
                Calificar = "C";
            }
            else
            {
                if (Respuesta1 != "Tipos de datos")
                {
                    Calificar = "I";
                }
            }
            //throw new NotImplementedException();
        }


        //2. if, else, for y while son:
        public override void Pregunta2()
        {
            if (Respuesta2 == "Sentencias de control")
            {
                Calificar = "C";
            }
            else
            {
                if (Respuesta2 != "Sentencias de control")
                {
                    Calificar = "I";
                }
            }
            //throw new NotImplementedException();
        }

        //3. Imperativo, declarativo y orientado a objetos son:
        public override void Pregunta3()
        {
            if (Respuesta3 == "Paradigmas de programación")
            {
                Calificar = "C";
            }
            else
            {
                if (Respuesta3 != "Paradigmas de programación")
                {
                    Calificar = "I";
                }

            }
            //throw new NotImplementedException();
        }
        

        public override void ResCorrectas()
        {
            if (Respuesta1 == "Tipos de datos")
            {
                Correctas = Correctas + 1;
            }

            if (Respuesta2 == "Sentencias de control")
            {
                Correctas = Correctas + 1;
            }

            if (Respuesta3 == "Paradigmas de programación")
            {
                Correctas = Correctas + 1;
            }
            //throw new NotImplementedException();
        }
    }
}
