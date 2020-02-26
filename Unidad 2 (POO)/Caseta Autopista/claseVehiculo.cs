using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caseta_Autopista
{
    class claseVehiculo
    {
        //atributos 
        public string tipoVehiculo;
        public int precio;
        //metodo

        public void precioVehiculo()
        {
            switch (tipoVehiculo)
            {
                case "Motociclista":
                    {
                        precio = 50;
                        break;
                    }
                case "Automóvil":
                    {
                        precio = 112;
                        break;
                    }
                case "Autobús":
                    {
                        precio = 170;
                        break;
                    }
                case "Tráiler":
                    {
                        precio = 250;
                        break;
                    }
            }
        }
    }
}
