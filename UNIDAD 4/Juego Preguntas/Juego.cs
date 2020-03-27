using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_Preguntas
{
    public partial class Juego : Form
    {
        int puntos;
        double porcentaje;
        string mensaje;

        Programacion objProgramacion = new Programacion();
        Ciencia objCiencia = new Ciencia();
        Cultura objCultura = new Cultura();
        Matematicas objMatematicas = new Matematicas();
        Cine objCine = new Cine();
        Historia objHistoria = new Historia();
        public Juego()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //Respuestas Programacion
            objProgramacion.Respuesta1 = Convert.ToString(cmbR1.Text);
            objProgramacion.Pregunta1();
            lblR1.Text = Convert.ToString(objProgramacion.Calificar);

            objProgramacion.Respuesta2 = Convert.ToString(cmbR2.Text);
            objProgramacion.Pregunta2();
            lblR2.Text = Convert.ToString(objProgramacion.Calificar);

            objProgramacion.Respuesta3 = Convert.ToString(cmbR3.Text);
            objProgramacion.Pregunta3();
            lblR3.Text = Convert.ToString(objProgramacion.Calificar);

            objProgramacion.ResCorrectas();

            //Respuestas Ciencia
            objCiencia.Respuesta1 = Convert.ToString(cmbR4.Text);
            objCiencia.Pregunta1();
            lblR4.Text = Convert.ToString(objCiencia.Calificar);

            objCiencia.Respuesta2 = Convert.ToString(cmbR5.Text);
            objCiencia.Pregunta2();
            lblR5.Text = Convert.ToString(objCiencia.Calificar);

            objCiencia.Respuesta3 = Convert.ToString(cmbR6.Text);
            objCiencia.Pregunta3();
            lblR6.Text = Convert.ToString(objCiencia.Calificar);

            objCiencia.ResCorrectas();

            //Respuestas Cultura
            objCultura.Respuesta1 = Convert.ToString(cmbR7.Text);
            objCultura.Pregunta1();
            lblR7.Text = Convert.ToString(objCultura.Calificar);

            objCultura.Respuesta2 = Convert.ToString(cmbR8.Text);
            objCultura.Pregunta2();
            lblR8.Text = Convert.ToString(objCultura.Calificar);

            objCultura.Respuesta3 = Convert.ToString(cmbR9.Text);
            objCultura.Pregunta3();
            lblR9.Text = Convert.ToString(objCultura.Calificar);

            objCultura.ResCorrectas();

            //Respuestas Matematicas
            objMatematicas.Respuesta1 = Convert.ToString(cmbR10.Text);
            objMatematicas.Pregunta1();
            lblR10.Text = Convert.ToString(objMatematicas.Calificar);

            objMatematicas.Respuesta2 = Convert.ToString(cmbR11.Text);
            objMatematicas.Pregunta2();
            lblR11.Text = Convert.ToString(objMatematicas.Calificar);

            objMatematicas.Respuesta3 = Convert.ToString(cmbR12.Text);
            objMatematicas.Pregunta3();
            lblR12.Text = Convert.ToString(objMatematicas.Calificar);

            objMatematicas.ResCorrectas();

            //Respuestas Cine
            objCine.Respuesta1 = Convert.ToString(cmbR13.Text);
            objCine.Pregunta1();
            lblR13.Text = Convert.ToString(objCine.Calificar);

            objCine.Respuesta2 = Convert.ToString(cmbR14.Text);
            objCine.Pregunta2();
            lblR14.Text = Convert.ToString(objCine.Calificar);

            objCine.Respuesta3 = Convert.ToString(cmbR15.Text);
            objCine.Pregunta3();
            lblR15.Text = Convert.ToString(objCine.Calificar);

            objCine.ResCorrectas();

            //Respuesta Historia
            objHistoria.Respuesta1 = Convert.ToString(cmbR16.Text);
            objHistoria.Pregunta1();
            lblR16.Text = Convert.ToString(objHistoria.Calificar);

            objHistoria.Respuesta2 = Convert.ToString(cmbR17.Text);
            objHistoria.Pregunta2();
            lblR17.Text = Convert.ToString(objHistoria.Calificar);

            objHistoria.Respuesta3 = Convert.ToString(cmbR18.Text);
            objHistoria.Pregunta3();
            lblR18.Text = Convert.ToString(objHistoria.Calificar);

            objHistoria.ResCorrectas();

            /*En esta seccion se realizaron algunas operaciones para poder obtener la puntuacion
             final, tal manera imprimir esos puntos en pantalla junto con el porcentaje correspondiente
             y un mensaje.*/
            puntos = (objProgramacion.Correctas + objCiencia.Correctas + objCultura.Correctas + objMatematicas.Correctas + objCine.Correctas + objHistoria.Correctas);

            porcentaje = (puntos * 100) / 18;

            if (porcentaje == 100)
            {
                mensaje = "Perfecto";
            }
            else
            {
                if (porcentaje >= 80 && porcentaje <= 99)
                {
                    mensaje = "Bien hecho";
                }
                else
                {
                    if(porcentaje >= 50 && porcentaje <= 79)
                    {
                        mensaje = "Puedes mejorar";
                    }
                    else
                    {
                        if (porcentaje >= 0 && porcentaje <= 49)
                        {
                            mensaje = "Fatal";
                        }
                    }
                }
            }

            lblPuntuacion.Text = Convert.ToString("Puntuación:");
            lblPorcentaje.Text = Convert.ToString("Porcentaje:");
            lblPuntuacionF.Text = Convert.ToString(puntos);
            lblPorcentajeF.Text = Convert.ToString(porcentaje + " %");
            lblMensaje.Text = Convert.ToString(mensaje);

            //Inicializa en 0 el contador Correctas para que no tome como referencia resultados anteriores
            objProgramacion.Correctas = Convert.ToInt32(0);
            objCiencia.Correctas = Convert.ToInt32(0);
            objCultura.Correctas = Convert.ToInt32(0);
            objMatematicas.Correctas = Convert.ToInt32(0);
            objCine.Correctas = Convert.ToInt32(0);
            objHistoria.Correctas = Convert.ToInt32(0);
        }
    }
}
