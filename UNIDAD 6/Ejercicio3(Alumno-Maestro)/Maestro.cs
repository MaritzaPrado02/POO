using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_Alumno_Maestro_
{
    class Maestro:Persona
    {
        //Constructor de la clase
        public Maestro()
        {
            nombre = " ";
            fechaNacimiento = DateTime.Today;
            curp = " ";
            telefono = 0;
            eMail = " ";
            cantidadMateriasMaestro = 0;
        }
        public int numeroMaestro { get; set; }
        public double sueldo { get; set; }
        public string[] materias { get; set; }
        public int cantidadMateriasMaestro { get; set; }


        public string imprimirDatosMaestro()
        {

            var cadena = "Nombre: " + nombre +"\n " + "\nFecha de nacimiento: " + fechaNacimiento.ToString() + "\nCurp: " + curp + "\nTelefono: " + telefono + "\nE-mail: " + eMail + "\nNúmero de maestro: " + numeroMaestro + "\nSueldo: " + sueldo + "\nMaterias " + "\n ";

            for (int i = 0; i < materias.Length; i++)
            {
                cadena += materias[i] + "\n";

            }
            return cadena;
        }
     }
}
