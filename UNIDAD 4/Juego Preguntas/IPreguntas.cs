using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Preguntas
{
    //Interfaz para juego de preguntas y respuestas
    interface IPreguntas
    {
        //Métodos los cuales se implementaran una clase de tipo abstract (categoriaPreguntas) los cuales se definiran en sus clases hijas.
        void Pregunta1();
        void Pregunta2();
        void Pregunta3();
        void ResCorrectas();
    }
}
