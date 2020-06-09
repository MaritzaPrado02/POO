using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1PropuestoUnidad6
{
    class Primario_Primario : combinacionColores
    {
        //Constructor de la clase
        public Primario_Primario()
        {
            Color1 = " ";
            Color2 = " ";
            NuevoColor = " ";
        }
        public override void combinar()
        {
            if (Color1 == "Rojo" && Color2 == "Rojo") //Rojo + Rojo =  Rojo
            {
                NuevoColor = "Rojo";
            }
            else
            {
                if (Color1 == "Rojo" && Color2 == "Azul") //Rojo + Azul = Violeta
                {
                    NuevoColor = "Violeta";
                }
                else
                {
                    if (Color1 == "Rojo" && Color2 == "Amarillo") //Rojo + Amarillo = Naranja
                    {
                        NuevoColor = "Naranja";
                    }
                }
            }


            if (Color1 == "Azul" && Color2 == "Rojo") //Azul + Rojo = Violeta
            {
                NuevoColor = "Violeta";
            }
            else
            {
                if (Color1 == "Azul" && Color2 == "Azul") //Azul + Azul = Azul
                {
                    NuevoColor = "Azul";
                }
                else
                {
                    if (Color1 == "Azul" && Color2 == "Amarillo") //Azul + Amarillo = Verde
                    {
                        NuevoColor = "Verde";
                    }
                }
            }


            if (Color1 == "Amarillo" && Color2 == "Rojo") //Amarillo +  Rojo = Naranja
            {
                NuevoColor = "Naranja";
            }
            else
            {
                if (Color1 == "Amarillo" && Color2 == "Azul")  //Amarillo + Azul = Verde
                {
                    NuevoColor = "Verde";
                }
                else
                {
                    if (Color1 == "Amarillo" && Color2 == "Amarillo") //Amarillo + Amarillo = Amarillo
                    {
                        NuevoColor = "Amarillo";
                    }
                }
            }
            //throw new NotImplementedException();
        }
    }
}
