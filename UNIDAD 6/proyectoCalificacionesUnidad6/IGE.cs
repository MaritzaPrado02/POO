using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoCalificacionesUnidad6
{    
    class IGE:claseCarreras
    {
        public int i = 0;
        public int k = 0;
        public double acumProm = 0;
        

        public void calcularPromedio()
        {
            for (int a = 0; a < cantidadAlumnos; a++)
            {
                promedio = 0;
                for (int m = 0; m < cantidadMaterias; m++)
                {
                    promedio += arregloCalificaciones[a, m];
                    promedios[a] = (promedio / cantidadMaterias);
                }
            }
        }


        public void calcularPromedioGrupal()
        {
            for (int a = 0; a < cantidadAlumnos; a++)
            {
                acumProm += promedios[a];
            }
            promedioGralGrupal = (acumProm / cantidadAlumnos);
        } 

        public string imprimirDatos()
        {           
            var  cadena = "Nombre: " + nombre[i] + "\nNo. Control: " + NumControl[i] + "\nMaterias" + " \n";
                
              
                for (k = 0; k < cantidadMaterias ; k++)
                {
                cadena += materias[k] + ": " + arregloCalificaciones[i,k] + "\n";                                    
                }              
            cadena += "Promedio: " + promedios[i] + "\n";     
            return cadena;                
        }     
    }
}
