using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertidorGrados
{
    public class claseTemperatura
    {
        //Atributos
        public string sistema;
        public double grados;
        public double conversion;
    
     

        //Métodos
        public double convertirTemperatura()
        {
            switch (sistema)
            {
                case "Centigrados":
                    {
                        conversion = grados * (1.8 + 32);
                        break;
                    }
                case "Fahrenheit":
                    {
                        conversion = (grados - 32) / 1.8;
                        break;
                    }

                    
            }
            return grados;

            
        }

    }
}
