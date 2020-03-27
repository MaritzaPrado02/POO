using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Preguntas
{
    class Historia : categoriaPreguntas
    {
        //CATEGORIA HISTORIA

            //Constructor de la clase (Historia)
        public Historia()
        {
            Respuesta1 = " ";
            Respuesta2 = " ";
            Respuesta3 = " ";
            Correctas = 0;
            Calificar = " ";
        }

        //1. ¿Cuando termino la Segunda Guerra Mundial?
        public override void Pregunta1()
        {
            if (Respuesta1 == "1945")
            {
                Calificar = "C";
            }
            else
            {
                if (Respuesta1 != "1945")
                {
                    Calificar = "I";
                }
            }
            //throw new NotImplementedException();
        }

        //2. Año en que ocurrió la Batalla de Puebla
        public override void Pregunta2()
        {
            if (Respuesta2 == "1862")
            {
                Calificar = "C";
            }
            else
            {
                if (Respuesta2 != "1862")
                {
                    Calificar = "I";
                }
            }
            //throw new NotImplementedException();
        }

        //3. Dia en que se celebra la Independencia de México
        public override void Pregunta3()
        {
            if (Respuesta3 == "16 de Septiembre")
            {
                Calificar = "C";
            }
            else
            {
                if (Respuesta3 != "16 de Septiembre")
                {
                    Calificar = "I";
                }
            }
            //throw new NotImplementedException();
        }

        public override void ResCorrectas()
        {
            if (Respuesta1 == "1945")
            {
                Correctas = Correctas + 1;
            }

            if (Respuesta2 == "1862")
            {
                Correctas = Correctas + 1;
            }

            if (Respuesta3 == "16 de Septiembre")
            {
                Correctas = Correctas + 1;
            }
            //throw new NotImplementedException();
        }
    }
}
