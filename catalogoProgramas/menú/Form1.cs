using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menú
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Embotelladora.frmEmbotelladora frmEmbotelladora1 = new Embotelladora.frmEmbotelladora();
            frmEmbotelladora1.Show();
        }

        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            Calificaciones.frmCalificaciones frmCalificaciones2 = new Calificaciones.frmCalificaciones();
            frmCalificaciones2.Show();
        }

        private void btnCasetaAutopista_Click(object sender, EventArgs e)
        {
            Caseta_Autopista.frmCaseta frmCasetaAutopista2 = new Caseta_Autopista.frmCaseta();
            frmCasetaAutopista2.Show();
        }

        private void btnConcierto_Click(object sender, EventArgs e)
        {
            Concierto.frmConcierto frmConcierto2 = new Concierto.frmConcierto();
            frmConcierto2.Show();
        }

        private void btnConvertidor_Click(object sender, EventArgs e)
        {
            ConvertidorGrados.frmConvertidor frmConvertidor2 = new ConvertidorGrados.frmConvertidor();
            frmConvertidor2.Show();
        }

        private void btnEmbotelladora_Click(object sender, EventArgs e)
        {
            Embotelladora.frmEmbotelladora frmEmbotelladora2 = new Embotelladora.frmEmbotelladora();
            frmEmbotelladora2.Show();
        }

        private void btnMayorEdad_Click(object sender, EventArgs e)
        {
            Mayor_de_edad.Form1 frmMayorEdad2 = new Mayor_de_edad.Form1();
            frmMayorEdad2.Show();
        }

        private void btnPerimetroArea_Click(object sender, EventArgs e)
        {
            Perimetro_y_Area.frmCuadrado frmPerimetroArea2 = new Perimetro_y_Area.frmCuadrado();
            frmPerimetroArea2.Show();
        }

        private void btnReciboElectricidad_Click(object sender, EventArgs e)
        {
            Recibo_Electricidad.frmElectridad frmElectricidad2 = new Recibo_Electricidad.frmElectridad();
            frmElectricidad2.Show();
        }

        private void btnVacaciones_Click(object sender, EventArgs e)
        {
            Vacaciones_Empleado.frmAñosTrabajadosEmpleado frmVacacionesEmpleado2 = new Vacaciones_Empleado.frmAñosTrabajadosEmpleado();
            frmVacacionesEmpleado2.Show();
        }

        private void btnCapturaDatos_Click(object sender, EventArgs e)
        {

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            EmpleadoRestaurante.frmEmpleado frmEmpleado4 = new EmpleadoRestaurante.frmEmpleado();
            frmEmpleado4.Show();
        }

        private void btnFiguras_Click(object sender, EventArgs e)
        {
            Figura.frmFigura frmFigura4 = new Figura.frmFigura();
            frmFigura4.Show();
        }

        private void btnInterfaz_Click(object sender, EventArgs e)
        {
            InterfazEjercicio1.frmExamen frmInterfaz4 = new InterfazEjercicio1.frmExamen();
            frmInterfaz4.Show();
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            Operaciones.frmOperacion frmOperacion4 = new Operaciones.frmOperacion();
            frmOperacion4.Show();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            Vehiculos.frmVehiculo frmVehiculo4 = new Vehiculos.frmVehiculo();
            frmVehiculo4.Show();
        }

        private void btnJuego_Click(object sender, EventArgs e)
        {
            Juego_Preguntas.frmInicio frmJuego4 = new Juego_Preguntas.frmInicio();
            frmJuego4.Show();
        }

        private void btnBidimensional11_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBidimesional_Click(object sender, EventArgs e)
        {
            Bidimensional2_1_.frmBidimensional frmBidimensional5 = new Bidimensional2_1_.frmBidimensional();
            frmBidimensional5.Show();
        }

        private void btnEjercicioPropuesto_Click(object sender, EventArgs e)
        {
            Ejercicio1_Propuesto.frmCombinacionColores frmEjercicioPropuesto5 = new Ejercicio1_Propuesto.frmCombinacionColores();
            frmEjercicioPropuesto5.Show();
        }

        private void btnEjercicioPais_Click(object sender, EventArgs e)
        {
            Ejercicio1_Pais_.frmRegistrarPais frmPais5 = new Ejercicio1_Pais_.frmRegistrarPais();
            frmPais5.Show();
        }

        private void btnPaises_Click(object sender, EventArgs e)
        {
            Ejercicio2_Paises_.frmDatosPaises frmPaises5 = new Ejercicio2_Paises_.frmDatosPaises();
            frmPaises5.Show();
        }

        private void btnAlumnoMaestro_Click(object sender, EventArgs e)
        {
            Ejercicio3_Alumno_Maestro_.frmDatos frmAlumnoMaestro5 = new Ejercicio3_Alumno_Maestro_.frmDatos();
            frmAlumnoMaestro5.Show();
        }

        private void btnAlumnosMaestros_Click(object sender, EventArgs e)
        {
            Ejercicio4_Alumnos_Maestros_.Form1 frmAlumnosMaestros = new Ejercicio4_Alumnos_Maestros_.Form1();
            frmAlumnosMaestros.Show();
        }

        private void btnTorneo_Click(object sender, EventArgs e)
        {
            ProgramaTorneo.frmTorneo frmTorneo5 = new ProgramaTorneo.frmTorneo();
            frmTorneo5.Show();
        }

        private void btnMayorMenor5_Click(object sender, EventArgs e)
        {
            NumerosMayorMenor.frmNumeros frmNumero5 = new NumerosMayorMenor.frmNumeros();
            frmNumero5.Show();
        }

        private void btnMatrizFCFD_Click(object sender, EventArgs e)
        {
            MatrizSumaFCD.frmMatrizSumaFCD frmMatriz5 = new MatrizSumaFCD.frmMatrizSumaFCD();
            frmMatriz5.Show();
        }

        private void btnPrimeraClase_Click(object sender, EventArgs e)
        {
            MiPrimeraClase_Video_.frmPersonas frmPersonas5 = new MiPrimeraClase_Video_.frmPersonas();
            frmPersonas5.Show();
        }

        private void btnProyectoCalificaciones_Click(object sender, EventArgs e)
        {
            proyectoCalificaciones.frmDatos frmProyecto5 = new proyectoCalificaciones.frmDatos();
            frmProyecto5.Show();
        }

        private void btnBidimensional6_Click(object sender, EventArgs e)
        {
            Bidimensional2Unidad6.frmBidimensional frmBidimensional6 = new Bidimensional2Unidad6.frmBidimensional();
            frmBidimensional6.Show();     
        }

        private void btnEjercicioPropuesto6_Click(object sender, EventArgs e)
        {
            Ejercicio1PropuestoUnidad6.frmCombinacionColores frmPropuesto6 = new Ejercicio1PropuestoUnidad6.frmCombinacionColores();
            frmPropuesto6.Show();
        }

        private void btnPais6_Click(object sender, EventArgs e)
        {
            Ejercicio1PaisUnidad6.frmRegistrarPais frmPais6 = new Ejercicio1PaisUnidad6.frmRegistrarPais();
            frmPais6.Show();
        }

        private void btnPaises6_Click(object sender, EventArgs e)
        {
            Ejercicio2PaisesUnidad6.frmDatosPaises frmPaises6 = new Ejercicio2PaisesUnidad6.frmDatosPaises();
            frmPaises6.Show();
        }

        private void btnAlumnoMaestro6_Click(object sender, EventArgs e)
        {
            Ejercicio3AlumnoMaestroUnidad6.frmDatos frmDatos6 = new Ejercicio3AlumnoMaestroUnidad6.frmDatos();
            frmDatos6.Show();
        }

        private void btnAlumnosMaestros6_Click(object sender, EventArgs e)
        {
            Ejercicio4AlumnosMaestrosUnidad6.Form1 frmOcupacion6 = new Ejercicio4AlumnosMaestrosUnidad6.Form1();
            frmOcupacion6.Show();
        }

        private void btnTorneo6_Click(object sender, EventArgs e)
        {
            ProgramaTorneoUnidad6.frmTorneo frmTorneo6 = new ProgramaTorneoUnidad6.frmTorneo();
            frmTorneo6.Show();
        }

        private void btnMayorMenor6_Click(object sender, EventArgs e)
        {
            NumerosMayorMenorUnidad6.frmNumeros frmNumeros6 = new NumerosMayorMenorUnidad6.frmNumeros();
            frmNumeros6.Show();
        }

        private void btnSumaFCD6_Click(object sender, EventArgs e)
        {
            MatrizSumaFCDUnidad6.frmMatrizSumaFCD frmMatriz6 = new MatrizSumaFCDUnidad6.frmMatrizSumaFCD();
            frmMatriz6.Show();
        }

        private void btnPrimeraClase6_Click(object sender, EventArgs e)
        {
            MiPrimeraClaseVideoUnidad6.frmPersonas frmPersonas6 = new MiPrimeraClaseVideoUnidad6.frmPersonas();
            frmPersonas6.Show();
        }

        private void btnProyectoCalificaciones6_Click(object sender, EventArgs e)
        {
            proyectoCalificacionesUnidad6.frmDatos frmDatos6 = new proyectoCalificacionesUnidad6.frmDatos();
            frmDatos6.Show();
        }

        private void grbUnidad5_Enter(object sender, EventArgs e)
        {

        }
    }
}
