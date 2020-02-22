using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimetro_y_Area
{
    class claseCuadrado
    {
        //Atributos
        public double lado;
        public double perimetro, area;

        //Métodos
        public double calcularPerimetro()
        {
            perimetro = lado * 4;
            return perimetro;
        }

        public double calcularArea()
        {
            area = lado * lado;
            return area;
        }



    }
}
