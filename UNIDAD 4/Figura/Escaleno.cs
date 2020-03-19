using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    class Escaleno:Triangulo
    {
        public override void calcArea()
        {
            Area = (LadoB * Altura) / 2;
            //base.calcArea();
        }
        public override void calcPerimetro()
        {
            Perimetro = LadoA + LadoB + LadoC;
            //base.calcPerimetro();
        }
    }
}
