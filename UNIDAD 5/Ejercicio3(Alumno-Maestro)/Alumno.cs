using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_Alumno_Maestro_
{
    class Alumno:Persona
    {
        //constructor 
        public Alumno()
        {
            nombre = " ";
            fechaNacimiento = DateTime.Today;
            curp = " ";
            telefono = 0;
            eMail = " ";
            numeroControl = 0;
            carrera = " ";
            cantidadMateriasAlumno = 0;
        }

        
        public int numeroControl { get; set; }
        public string carrera { get; set; }
        public string[] materias { get; set; }
        public double[] calificacion { get; set; }
        public int cantidadMateriasAlumno { get; set; }
        public string imprimirDatosAlumno()
        {
              
           var cadena = "Nombre: " + nombre +  "\nFecha de nacimiento: " + fechaNacimiento.ToString() + "\nCurp: " + curp + "\nTelefono: " + telefono + "\nE-mail: " + eMail + "\nNúmero de alumno: " + numeroControl + "\nCarrera: " + carrera + "\nMaterias " + "\n";

            for (int i = 0; i < materias.Length; i++)
            {
                cadena += materias[i] + ": " + calificacion[i] + "\n";

            }
            return cadena;
        }
    }
}
