using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoCalificaciones
{
    class claseCarreras
    {
        public string carrera { get; set; }
        public int cantidadAlumnos { get; set; }
        public int cantidadMaterias { get; set; }
        public string[] materias { get; set; }
        public string[] nombre { get; set; }
        public int[] NumControl { get; set; }      
        public double promedio { get; set; }
        public double[] promedios { get; set; }
        public double promedioGralGrupal { get; set; }
        public int[,] arregloCalificaciones { get; set; }
    }
}
