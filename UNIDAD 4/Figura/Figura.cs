using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    public abstract class Figura
    {
        //Atributos
        double lado, perimetro, area;


        //Publicos 
        public double Lado
        {
            get
            {
                return lado;
            }
            set
            {
                lado = value;
            }
        }
    public double Perimetro
        {
            get
            {
                return perimetro;
            }
            set
            {
                perimetro = value;
            }
        }
        public double Area
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
            }          
        }


        public Figura()
        {
            lado = 0;
            area = 0;
            perimetro = 0;
        }

        public abstract void calcPerimetro(); // abstract es vacio, probando el polimorfismo


        public abstract void calcArea();
    }
}
