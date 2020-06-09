using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1PropuestoUnidad6
{
    class Primario_Secundario : combinacionColores
    {
        //Constructor de la clase
        public Primario_Secundario()
        {
            Color1 = " ";
            Color2 = " ";
            NuevoColor = " ";
        }
        public override void combinar()
        {
            if (Color1 == "Rojo" && Color2 == "Naranja") //Rojo + Naranja = Rojo Naranja
            {
                NuevoColor = "Rojo Naranja";
            }
            else
            {
                if (Color1 == "Rojo" && Color2 == "Verde") //Rojo + Verde = no se puede combinar
                {
                    NuevoColor = ":c no se puede combinar";
                }
                else
                {
                    if (Color1 == "Rojo" && Color2 == "Violeta") //Rojo + Violeta = Rojo Violeta
                    {
                        NuevoColor = "Rojo Violeta";
                    }
                }
            }


            if (Color1 == "Azul" && Color2 == "Naranja") //Azul + Naranja = no se puede combinar
            {
                NuevoColor = ":c no se puede combinar";
            }
            else
            {
                if (Color1 == "Azul" && Color2 == "Verde") //Azul + Verde = Azul Verde
                {
                    NuevoColor = "Azul Verde";
                }
                else
                {
                    if (Color1 == "Azul" && Color2 == "Violeta") //Azul + Violeta = Azul Violeta
                    {
                        NuevoColor = "Azul Violeta";
                    }
                }
            }


            if (Color1 == "Amarillo" && Color2 == "Naranja") //Amarillo + Naranja = Amarillo Naranja
            {
                NuevoColor = "Amarillo Naranja";
            }
            else
            {
                if (Color1 == "Amarillo" && Color2 == "Verde") //Amarillo + Verde = Amarillo Verde
                {
                    NuevoColor = "Amarillo Verde";
                }
                else
                {
                    if (Color1 == "Amarillo" && Color2 == "Violeta") //Amarillo + Violeta = no se puede combinar
                    {
                        NuevoColor = ":c no se puede combinar";
                    }
                }
            }
            //throw new NotImplementedException();
        }
    }
}
