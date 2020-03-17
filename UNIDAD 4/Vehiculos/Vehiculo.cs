using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Vehiculo
    {
        //Atributos
        public string tipoCombustible, color;
        public int numeroLlantas, numeroPuertas, numeroVentanas;

        //Concepto de contructor,cuando ese objeto se construye se dispara , es un metodo de una clase

            //vehiculo objVehiculo = new vehiculo ()


     /*Constructor de la clase, es un metodo que se llama igual que la clase
      y se ejecuta automaticamente al crear el objeto*/
     public Vehiculo()
        {
            tipoCombustible = "";
            color = "Blanco";
            numeroLlantas = 1;
            numeroPuertas = 0;
            numeroVentanas = 0;
        }
      //Método
      public string arrancarMotor( string sonido)
        {
            return "Se arranco el motor" + sonido;

            /*string mensaje;
            mensaje = "Se arranco el motor " + sonido;
            return mensaje;*/
        }

        public string pararMotor (string sonido)
        {
            return "Se detuvo el sonido" + sonido;
        }


    }
}
