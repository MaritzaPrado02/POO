using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
using System.Diagnostics;

namespace ProgramaTorneoUnidad6
{
    public partial class frmTorneo : Form
    {
        TextWriter archivo;
        claseTorneo objTorneo = new claseTorneo();
        int cont = 1;
        int punt = 1;

        public frmTorneo()
        {
            InitializeComponent();
            btnImprimir.Enabled = false;
            btnAbrir.Enabled = false;
            btnLeer.Enabled = false;
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            objTorneo.nombreTorneo = txtNombreTorneo.Text;
            objTorneo.numEquipos = (int)nudNumeroEquipos.Value;
            objTorneo.numeroPartidos();
            objTorneo.sumaPuntajes = new int[objTorneo.numPartidos];
            objTorneo.fechaInicio = dtpFechaInicio.Value;
            objTorneo.fechaFin = dtpFechaFin.Value;
            objTorneo.PGanado = (int)nudPuntosGanado.Value;
            objTorneo.PEmpate = (int)nudPuntosEmpate.Value;
            objTorneo.PPerdido = (int)nudPuntosPerdido.Value;

            if (txtNombreTorneo.Text == "")
            {
                errorProvider1.SetError(txtNombreTorneo, "Ingrese nombre del torneo");
                txtNombreTorneo.Focus();
                return;
            }
            errorProvider1.SetError(txtNombreTorneo, "");
            

            objTorneo.PuntajeXPartidos = new int[objTorneo.numEquipos, objTorneo.numPartidos];
            objTorneo.sumaPuntajes = new int[objTorneo.numEquipos];

            for (int f = 0; f < objTorneo.numEquipos; f++)
            {
                for (int c = 0; c < objTorneo.numPartidos; c++)
                {                  
                    objTorneo.PuntajeXPartidos[f, c] = Convert.ToInt16(Interaction.InputBox("Introduce puntaje " + punt + " de equipo " + cont + ":","Puntos de partidos por equipo"));
                    punt++;
                }
                cont++;
                punt = 1;
            }

            
            //Sumar puntajes
            objTorneo.puntosEquipo();
            objTorneo.puntEquipoGanador = objTorneo.sumaPuntajes[0];
            objTorneo.ganador();

            grbDatosGenerales.Enabled = false;
            btnImprimir.Enabled = true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nombre del torneo: " + objTorneo.nombreTorneo + "\nNúmero de equipos: " + objTorneo.numEquipos + " \nNúmero de partidos: " + objTorneo.numPartidos + "\nFecha inicio: " + objTorneo.fechaInicio.ToString() +  "\nFecha fin: " + objTorneo.fechaFin.ToString() +  "\nEl equipo ganador es el equipo " + objTorneo.EquipoGanador + "\nCon " + objTorneo.puntEquipoGanador + " puntos.","Informe del ganador");
            archivo.WriteLine("Nombre del torneo: " + objTorneo.nombreTorneo + "\nNúmero de equipos: " + objTorneo.numEquipos + " \nNúmero de partidos: " + objTorneo.numPartidos + "\nFecha inicio: " + objTorneo.fechaInicio.ToString() + "\nFecha fin: " + objTorneo.fechaFin.ToString() + "\nEl equipo ganador es el equipo " + objTorneo.EquipoGanador + "\nCon " + objTorneo.puntEquipoGanador + " puntos.");
            archivo.Close();
            MessageBox.Show("Los datos se han guardado en un archivo", "Guardados exitosamente");
            btnLeer.Enabled = true;
            btnAbrir.Enabled = true;
        }

        private void frmTorneo_Load(object sender, EventArgs e)
        {
            archivo = new StreamWriter("ArchivoTorneo.txt");
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            TextReader leerArchivo;

            leerArchivo = new StreamReader("ArchivoTorneo.txt");

            MessageBox.Show(leerArchivo.ReadToEnd(), "ArchivoTorneo.txt");
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Process.Start("ArchivoTorneo.txt");
        }
    }
}
