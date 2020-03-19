using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    class Circulo:Figura
    {
        double radio;

        public double Radio
        {
            get
            {
                return radio;
            }
            set
            {
                radio = value;
            }
        }

        public Circulo()
        {
            radio = 0;
        }

        public override void calcPerimetro()
        {
            Perimetro = 2 * 3.14159 * Radio;
            //throw new NotImplementedException(); //Manejo/control de excepciones
        }
        public override void calcArea()
        {
            Area = 3.14159 * (Radio * Radio);
            //throw new NotImplementedException();
        }
    }
}
