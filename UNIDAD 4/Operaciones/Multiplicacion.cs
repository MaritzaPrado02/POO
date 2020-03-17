using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class Multiplicacion:Operacion
    {
        public void calcularMultiplicacion()
        {
            Resultado = Valor1 * Valor2;
        }
    }
}
