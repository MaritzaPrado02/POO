using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4AlumnosMaestrosUnidad6
{
    class Alumno : Persona
    {
        public int j = 0;
        public Alumno()
        {
            //cantidadMateriasAlumno = 0;
        }

        public int[] numeroControl { get; set; }
        public string[] carrera { get; set; }
        //public int[] cantMaterias { get; set; }
        public string[] materias { get; set; }
        public double[] calificacion { get; set; }
        public int numeroMaterias { get; set; }
        public int[] MatA { get; set; }
       
        public string imprimirDatosAlumno()
        {

            var cadena = "Nombre: " + nombre[j] + "\nFecha de nacimiento: " + fechaNacimiento[j].ToString() + "\nCurp: " + curp[j] + "\nTelefono: " + telefono[j] + "\nE-mail: " + eMail[j] + "\nNúmero de alumno: " + numeroControl[j] + "\nCarrera: " + carrera[j] + "\nMaterias " + "\n";

            for (int i = 0; i < MatA[j]; i++)
            {
                cadena += materias[i] + ": " + calificacion[i] + "\n";

            }
            return cadena;
        }
    }
}
