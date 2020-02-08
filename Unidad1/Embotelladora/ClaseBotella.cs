using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embotelladora
{
    class ClaseBotella
    {
        //Atributos de la clase
        public int nivelLlenado;
        int mililitrosVerficados;

        //Métodos de la clase

        public String verificarLlenado()
        {
            String mensaje;
            if (nivelLlenado == 250)
                mensaje = "Llenado perfecto";
            else if (nivelLlenado < 250)
            {

                mililitrosVerficados = 250 - nivelLlenado;
                mensaje = "Le faltan " + mililitrosVerficados + " mililitros";

            }
            else
            {
                mililitrosVerficados = nivelLlenado - 250;
                mensaje = "Le sobran " + mililitrosVerficados + " mililitros";

            }
                                                 
            return mensaje;

        }
        
    } 
}
