using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    class Equilatero: Triangulo 
    {
        public override void calcArea()
        {
            Area = ((Math.Sqrt(3)) * (Lado * Lado)) / 4;
            //base.calcArea();
        }
        public override void calcPerimetro()
        {
            Perimetro = Lado + Lado + Lado;
            //base.calcPerimetro();
        }
    }
}
