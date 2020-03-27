using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Preguntas
{
    class Cultura : categoriaPreguntas
    {
        //CATEGORIA CULTURA

            //Contructor de la clase (Cultura)
        public Cultura()
        {
            Respuesta1 = " ";
            Respuesta2 = " ";
            Respuesta3 = " ";
            Correctas = 0;
            Calificar = " ";
        }

        //1. ¿Quien pinto la MonaLisa?
        public override void Pregunta1()
        {
            if (Respuesta1 == "Leonardo Da Vinci")
            {
                Calificar = "C";
            }
            else
            {
                if (Respuesta1 != "Leonardo Da Vinci")
                {
                    Calificar = "I";
                }
            }
            //throw new NotImplementedException();
        }

        //2. ¿Como se llama el fundador  de FaceBook?
        public override void Pregunta2()
        {
            if (Respuesta2 == "Mark Zuckerberg")
            {
                Calificar = "C";
            }
            else
            {
                if (Respuesta2 != "Mark Zuckerberg")
                {
                    Calificar = "I";
                }
            }
            //throw new NotImplementedException();
        }

        //3. ¿A que grupo de Rock le pertenece el tema "Hotel California"?
        public override void Pregunta3()
        {
            if (Respuesta3 == "Eagles")
            {
                Calificar = "C";
            }
            else
            {
                if (Respuesta3 != "Eagles")
                {
                    Calificar = "I";
                }
            }
            //throw new NotImplementedException();
        }




        public override void ResCorrectas()
        {
            if (Respuesta1 == "Leonardo Da Vinci")
            {
                Correctas = Correctas + 1;
            }

            if (Respuesta2 == "Mark Zuckerberg")
            {
                Correctas = Correctas + 1;
            }

            if (Respuesta3 == "Eagles")
            {
                Correctas = Correctas + 1;
            }
            //throw new NotImplementedException();
        }
    }
}
