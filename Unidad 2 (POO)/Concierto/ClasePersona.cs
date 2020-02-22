using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierto
{
    public class ClasePersona
    {   //Atributos de la clase                
        public string persona = "";
        public int cantidad;
        public int bebes, niños, adultos, adultosTerceraEdad;
        //Métodos de la clase
        public int personasContabilizadas()
        {
            switch (persona)
            {
                case "Bebés":
                    bebes = bebes + cantidad;
                    break;
                case "Niños":
                    niños = niños + cantidad;
                    break;
                case "Adultos":
                    adultos = adultos + cantidad;
                    break;
                case "Personas de la tercera edad":
                    adultosTerceraEdad = adultosTerceraEdad + cantidad;
                    break;
            }
            return cantidad;
        }
    }
}
