using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizSumaFCD
{
    class claseMatriz
    {
        public int filas { get; set; }
        public int columnas { get; set; }
        public int[,] MatrizNM { get; set; }
        public int[] sumaFilas { get; set; }
        public int acumFila { get; set; }
        public int sumaSumaFilas { get; set; }
        public int[] sumaColumnas { get; set; }
        public int acumColumna { get; set; }
        public int sumaSumaColumnas { get; set; }
        public int[] elementosDiagonal { get; set; }
        public int sumaDiagonal { get; set; }



       public void sumarFilas()
        {
            for (int f = 0; f < filas; f++)
            {
                acumFila = 0;
                for (int c = 0; c < columnas; c++)
                {
                    acumFila += MatrizNM[f,c];
                    sumaFilas[f] = acumFila;
                }
            }


            for (int f = 0; f < columnas; f++)
            {
                sumaSumaFilas += sumaFilas[f];
            }
        }

       public void sumarColumnas()
        {
            for (int c = 0; c < columnas; c++)
            {
                acumColumna = 0;
                for (int f = 0; f < filas; f++)
                {
                    acumColumna += MatrizNM[f, c];
                    sumaColumnas[c] = acumColumna;
                }
            }


            for (int c = 0; c < filas; c++)
            {
                sumaSumaColumnas += sumaColumnas[c];
            }
        }

        public void sumarDiagonal()
        {
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c  < columnas; c ++)
                {
                    if (f == c)
                    {
                        elementosDiagonal[f] = MatrizNM[f, c];
                    }
                }
            }

            for (int d = 0; d < filas; d++)
            {
                sumaDiagonal += elementosDiagonal[d];
            }
        }
    }


}
