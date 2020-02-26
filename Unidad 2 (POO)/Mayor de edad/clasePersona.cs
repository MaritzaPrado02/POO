using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayor_de_edad
{
    public class clasePersona
    {
        //Atributos
        public int anioNac = 0, mesNac = 0, diaNac = 0, anioActual = 0, mesActual = 0, diaActual = 0;
        public string mensajeMayor;
        public void identificarMayorEdad()//(int anioNac, int mesNac, int diaNac, int anioActual, int mesActual, int diaActual, string mensaje)
        {
            if (anioActual - anioNac > 18)
            {
                mensajeMayor = "es mayor de edad";
            }
            else if ((anioActual - anioNac) == 18)
            {
                if (mesActual > mesNac)
                {
                    mensajeMayor = "es mayor de edad";
                }
                else if (mesActual == mesNac)
                {
                    if (diaActual > diaNac)
                    {
                        mensajeMayor = "es mayor de edad";
                    }
                    else if (diaActual == diaNac)
                    {
                        mensajeMayor = "es mayor de edad";
                    }
                    else
                    {
                        mensajeMayor = "es menor de edad";
                    }
                }
                else
                {
                    mensajeMayor = "es menor de edad";
                }
            }
            else
            {
                mensajeMayor = "es menor de edad";
            }



        }

    }
}



    

