using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Captura_de_datos
{
    class ClaseDatos
    {
        //Atributos
        private string nombre, apellidoPaterno, apellidoMaterno;
        public int fechaNacimiento, telefono;
        public string tipoPersona, estadoNacimiento;
        public int contadorEstado = 0;
        public int contadorAlumnos = 0, contadorAdministrativos = 0, contadorDocentes = 0;
        public int contadorMayoresEdad = 0;

        //Métodos
        public void registarPersona(string nombreM, string apPaternoM, string apMaternoM, int fechaNacimientoM, string estadoNacimientoM, string tipoPersonaM, int telefonoM)
        {
            nombre = nombreM;
            apellidoPaterno = apPaternoM;
            apellidoMaterno = apMaternoM;
            fechaNacimiento = fechaNacimientoM;
            estadoNacimiento = estadoNacimientoM;
            tipoPersona = tipoPersonaM;
            telefono = telefonoM;       
        }

        public void contarNayarit()
        {
            if (estadoNacimiento == "Nayarit")
            {
                contadorEstado++;
            }
        }

        public void contarTipo()
        {
            switch (tipoPersona)
            {
                case "Adminstrativo":
                    {
                        contadorAdministrativos++;
                        break;
                    }
                case "Alumno":
                    {
                        contadorAlumnos++;
                        break;
                    }
                case "Docente":
                    {
                        contadorDocentes++;
                        break;
                    }              
            }
        }
        public void identificarMayorEdad(int añoNac, int mesNac, int diaNac, int añoActual, int mesActual, int diaActual)
        {
            if ((añoActual - añoNac) > 18)
            {
                contadorMayoresEdad++;
            }
            else
            {
                if ((añoActual - añoNac) == 18)
                {
                    if (mesActual > mesNac)
                    {
                        contadorMayoresEdad++;
                    }
                    else
                    {
                        if (mesActual == mesNac)
                        {
                            if (diaActual > diaNac)
                            {
                                contadorMayoresEdad++;
                            }
                            else
                            {
                                if (diaActual == diaNac)
                                {
                                    contadorMayoresEdad++;
                                }
                            }
                        }
                    }
                  
                }           
            }
        }
    }
}
