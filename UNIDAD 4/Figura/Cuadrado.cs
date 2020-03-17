using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    class Cuadrado:Figura
    {
        public override void calcPerimetro()
        {
            Perimetro = Lado * 4;
            throw new NotImplementedException();
            

        }
        public override void calcArea()
        {
            Area = Lado * Lado;
            throw new NotImplementedException();         
        }
    }
}
