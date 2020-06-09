using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4AlumnosMaestrosUnidad6
{
    class Maestro:Persona
    {
        public int j = 0;
   

        public int[] numeroMaestro { get; set; }
        public double[] sueldo { get; set; }
        public string[] materias { get; set; }
        //public int[] cantidadMateriasMaestro { get; set; }
        public int cantMatM  { get; set; }
        public int[] MatM { get; set; }


        public string imprimirDatosMaestro()
        {
            var cadena = "Nombre: " + nombre[j] + "\nFecha de nacimiento: " + fechaNacimiento[j].ToString() + "\nCurp: " + curp[j] + "\nTelefono: " + telefono[j] + "\nE-mail: " + eMail[j] + "\nNúmero de maestro: " + numeroMaestro[j] + "\nSueldo: " + sueldo[j] + "\nMaterias " + "\n" ;

            for (int i = 0; i < MatM[j]; i++)
            {
                cadena += materias[i] + "\n";
            }

            return cadena;
        }
    }
}
