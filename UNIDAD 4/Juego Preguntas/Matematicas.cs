using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Preguntas
{
    class Matematicas : categoriaPreguntas
    {
        //CATEGORIA MATEMATICAS

            //Constructor de la clase (Matematicas)
        public Matematicas()
        {
            Respuesta1 = " ";
            Respuesta2 = " ";
            Respuesta3 = " ";
            Correctas = 0;
            Calificar = " ";
        }

        //1. Resultado de 2X si X = 3
        public override void Pregunta1()
        {
            if (Respuesta1 == "6")
            {
                Calificar = "C";
            }
            else
            {
                if (Respuesta1 != "6")
                {
                    Calificar = "I";
                }
            }
            //throw new NotImplementedException();
        }

        //2. Formula que representa el binomio al cuadrado
        public override void Pregunta2()
        {
            if (Respuesta2 == "(a+b)^2")
            {
                Calificar = "C";
            }
            else
            {
                if (Respuesta2 != "(a+b)^2")
                {
                    Calificar = "I";
                }
            }
            //throw new NotImplementedException();
        }

        //3. Resultado de 2 + 2 * 3 = ?
        public override void Pregunta3()
        {
            if (Respuesta3 == "8")
            {
                Calificar = "C";
            }
            else
            {
                if (Respuesta3 != "8")
                {
                    Calificar = "I";
                }
            }
            //throw new NotImplementedException();
        }

        public override void ResCorrectas()
        {
            if (Respuesta1 == "6")
            {
                Correctas = Correctas + 1;
            }

            if (Respuesta2 == "(a+b)^2")
            {
                Correctas = Correctas + 1;
            }

            if (Respuesta3 == "8")
            {
                Correctas = Correctas + 1;
            }
            //throw new NotImplementedException();
        }
    }
}
