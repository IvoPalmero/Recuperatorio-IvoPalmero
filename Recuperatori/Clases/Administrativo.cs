using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEmpleados
{
    public class Administrativo : Empleado
    {
        public int Antiguedad { get; set; }
        public override int CalcularSueldoFinal()
        {
             return SueldoBase + Antiguedad * 100;
        }
        public override string TipoEmpleado()
        {
            return "Administrativo";
        }
    }
}
