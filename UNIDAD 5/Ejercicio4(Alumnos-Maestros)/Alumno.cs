using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_Alumnos_Maestros_
{
    class Alumno : Persona
    {
        public int j = 0;
        public Alumno()
        {
            cantidadMateriasAlumno = 0;
        }

        public int[] numeroControl { get; set; }
        public string[] carrera { get; set; }
        public string[,] materias { get; set; }
        public double[,] calificacion { get; set; }
        public int cantidadMateriasAlumno { get; set; }
        public string imprimirDatosAlumno()
        {

            var cadena = "Nombre: " + nombre[j] + "\nFecha de nacimiento: " + fechaNacimiento[j].ToString() + "\nCurp: " + curp[j] + "\nTelefono: " + telefono[j] + "\nE-mail: " + eMail[j] + "\nNúmero de alumno: " + numeroControl[j] + "\nCarrera: " + carrera[j] + "\nMaterias " + "\n";

            for (int i = 0; i < materias.Length; i++)
            {
                cadena += materias[j,i] + ": " + calificacion[j,i] + "\n";

            }
            return cadena;
        }
    }
}
