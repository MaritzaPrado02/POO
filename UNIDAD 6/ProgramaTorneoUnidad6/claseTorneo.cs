using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaTorneoUnidad6
{
    class claseTorneo
    {
        public claseTorneo()
        {
            nombreTorneo = "";
            numEquipos = 0;
            numPartidos = 0;
            fechaInicio = DateTime.Today;
            fechaFin = DateTime.Today;
            PGanado = 0;
            PEmpate = 0;
            PPerdido = 0;
        }
        public string nombreTorneo { get; set; }
        public int numEquipos { get; set; }
        public int numPartidos { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public int PGanado { get; set; }
        public int PEmpate { get; set; }
        public int PPerdido { get; set; }
        public int PuntEquipo  { get; set; }
        public int[,] PuntajeXPartidos{ get; set; }
        public int[] sumaPuntajes { get; set; }

        public int EquipoGanador { get; set; }
        public int puntEquipoGanador { get; set; }

        public void numeroPartidos()
        {
            numPartidos = numEquipos - 1;
        }
       
        //Sumar los puntajes de cada equipo 
        public void puntosEquipo()
        {            
            for (int f = 0; f < numEquipos; f++)
            {
                PuntEquipo = 0;
                for (int c = 0; c < numPartidos; c++)
                {
                    PuntEquipo += PuntajeXPartidos[f,c];
                    sumaPuntajes[f] = PuntEquipo;   
                } 
                       
            }
        }

        public void ganador()
        {
            for (int p = 0; p < sumaPuntajes.Length; p++)
            {
                if(sumaPuntajes[p] > puntEquipoGanador)
                {
                    EquipoGanador = (p + 1);
                    puntEquipoGanador = sumaPuntajes[p];
                }
                
            }
        }

    }
}
