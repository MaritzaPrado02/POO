using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoRestaurante
{
    abstract class Empleado
    {
        //Atributos 
        string nombre;
        int fechaNacimiento, diasTrabajados;
        double sueldoDiario, sueldo;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public int DiasTrabajados
        {
            get
            {
                return diasTrabajados;
            }
            set
            {
                diasTrabajados = value;
            }
        }

        public int FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }
            set
            {
                fechaNacimiento = value;
            }
        }

        public double Sueldo
        {
            get
            {
                return sueldo;
            }
            set
            {
                sueldo = value;
            }
        }

        public double SueldoDiario
        {
            get
            {
                return sueldoDiario;
            }
            set
            {
                sueldoDiario = value;
            }
        }


        public Empleado()
        {
            sueldoDiario = 0;
            sueldo = 0;
            nombre = "";
            diasTrabajados = 0;           
        }

        public abstract void calcularSueldo();

    }
}
