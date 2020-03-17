using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    class Triangulo:Figura
    {
        string tipoTriangulo;
        double Altura, Base, ladoA, ladoB, ladoC; 

        public Triangulo()
        {
            tipoTriangulo = " ";
            Altura = 0;
            Base = 0;
            ladoA = 0;
            ladoB = 0;
            ladoC = 0;
        }



        public override void calcPerimetro()
        {
            throw new NotImplementedException(); 
        }
        public override void calcArea()
        {
            throw new NotImplementedException();
        }
    }
}
