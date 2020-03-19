using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    class Triangulo:Figura
    {
        double altura, baseTri, ladoA, ladoB, ladoC; 

        public double Altura
        {
            get
            {
                return altura;
            }
            set
            {
                altura = value;
            }
        }
        public double BaseTri
        {
            get
            {
                return baseTri;
            }
            set
            {
                baseTri = value;
            }
        }
        public double LadoA
        {
            get
            {
                return ladoA;
            }
            set
            {
                ladoA = value;
            }
        }
        public double LadoB
        {
            get
            {
                return ladoB;
            }
            set
            {
                ladoB = value;
            }
        }
        public double LadoC
        {
            get
            {
                return ladoC;
            }
            set
            {
                ladoC = value;
            }
        }

        public Triangulo()
        {
            Altura = 0;
            BaseTri = 0;
            ladoA = 0;
            ladoB = 0;
            ladoC = 0;
        }



        public override void calcPerimetro()
        {
            //throw new NotImplementedException(); 
        }
        public override void calcArea()
        {
            //throw new NotImplementedException();
        }
    }
}
