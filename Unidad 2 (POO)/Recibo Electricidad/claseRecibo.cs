using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recibo_Electricidad
{
    public class claseRecibo
    {
        //Atributos
        public int Kw;
        public double costo;
        public string tipo;


        //Métodos
        public double calcularCosto()
        {
            switch (tipo)
            {
                case "Hogar":
                    {
                        if (Kw > 0 && Kw <= 250)
                        {
                            costo = Kw * .65;
                        }
                        else
                        {
                            if (Kw >=251 && Kw <= 500)
                            {
                                costo = Kw * .85;
                            }
                            else
                            {
                                if (Kw >=501 && Kw <= 1200)
                                {
                                    costo = Kw * 1.5;
                                }
                                else
                                {
                                    if (Kw >= 1201 && Kw <= 2100)
                                    {
                                        costo = Kw * 2.5;
                                    }
                                    else
                                    {
                                        if (Kw >= 2101)
                                        {
                                            costo = Kw * 3;
                                        }
                                    }
                                }
                            }
                        }

                        break;
                    }
                case "Negocio":
                    {
                        costo = Kw * 5;
                        break;
                    }
            }
            return costo;
        }


       
    }
}
