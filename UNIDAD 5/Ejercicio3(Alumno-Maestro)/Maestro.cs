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

        }
        public int cantidadMaterias { get; set; }      
        public int numeroMaetro { get; set; }
        public double sueldo { get; set; }
        public string[] materias { get; set; }

        
        
            public string imprimirDatosMaestro()
        {

            var cadena = "Materias" + "\n ";

            for (int i = 0; i < cantidadMaterias; i++)
            {
                cadena += materias[i] + "\n ";

            }
            return cadena;
        }
     }
}
