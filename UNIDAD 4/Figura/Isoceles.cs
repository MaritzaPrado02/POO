using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    class Isoceles:Triangulo
    {
        public override void calcArea()
        {
            Area = (LadoA * Altura) / 2;
            //base.calcArea();
        }
        public override void calcPerimetro()
        {
            Perimetro = LadoA + LadoB + LadoC;
            //base.calcPerimetro();
        }
    }
}
