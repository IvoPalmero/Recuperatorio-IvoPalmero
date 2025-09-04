namespace ClasesEmpleados
{
     public abstract class Empleado
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public int SueldoBase { get; set; }

        public abstract int CalcularSueldoFinal();
        public abstract string TipoEmpleado();
        public virtual void MostrarInfo()
        {
            Console.WriteLine($"DNI:{DNI}, Nombre:{Nombre}, Tipo:{TipoEmpleado()}, Sueldo Final:{CalcularSueldoFinal()}");
        }
    }
}
