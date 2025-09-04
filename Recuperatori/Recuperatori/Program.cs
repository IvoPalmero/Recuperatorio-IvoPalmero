using ClasesEmpleados;

namespace AplicacionConsola

{
    class Program
    {
        static List<Empleado> empleados = new List<Empleado>();
        static void Main(string[] args)
        {
            int opcion = 0;

            do
            {
                Console.WriteLine("Bienvenido al sistema de gestion de empleados");
                Console.WriteLine("1.Registrar empleado");
                Console.WriteLine("2.Mostrar información de un empleado");
                Console.WriteLine("3.Mostrar todos los empleados y estadísticas");
                Console.WriteLine("4.Salir");
                Console.WriteLine("Ingrese una opcion:");
                int.TryParse(Console.ReadLine(), out opcion);
                if (opcion == 1) RegistrarEmpleado();
                if (opcion == 2) MostrarEmpleado();
                if (opcion == 3) MostrarTodos();
            }
            while (opcion < 4);
            Console.WriteLine("Cerrando..");
        }

        static void RegistrarEmpleado()
        {
            Console.WriteLine("Ttipo de empleado:");
            Console.WriteLine("1. Administrativo");
            Console.WriteLine("2. Vendedor");
            int tipo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese dni:");
            string dni = Console.ReadLine();

            if (empleados.Exists(e => e.DNI == dni))
            {
                Console.WriteLine("Ya existe un empleado con ese dni");
                return;
            }

            Console.Write("Ingrese nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese sueldo base: ");
            int sueldoBase = int.Parse(Console.ReadLine());

            if (tipo == 1)
            {
                Console.Write("Ingrese antiguedad : ");
                int antiguedad = int.Parse(Console.ReadLine());
                empleados.Add(new Administrativo {DNI = dni, Nombre = nombre, SueldoBase = sueldoBase, Antiguedad = antiguedad});
            }
            else if (tipo == 2)
            {
                Console.Write("Ventas mensuales:");
                int ventas = int.Parse(Console.ReadLine());
                empleados.Add(new Vendedor {DNI = dni, Nombre = nombre, SueldoBase = sueldoBase, MontoVentasMensuales = ventas});
            }

        }

        static void MostrarEmpleado()
        {
            Console.Write("Ingrese DNI del empleado: ");
            string dni = Console.ReadLine();
            Empleado emp = empleados.Find(e => e.DNI == dni);
            if (emp == null)
            {
               Console.WriteLine("Empleado no encontrado");
            }
            else
            {
                emp.MostrarInfo();
            }
        }

        static void MostrarTodos()
        {
            Console.WriteLine("Lista de empleados");
            double totalSueldos = 0;
            foreach (Empleado empleado in empleados)
            {
                empleado.MostrarInfo();
                totalSueldos += empleado.CalcularSueldoFinal();
            }

            Console.WriteLine($"Cantidad total de empleados:{empleados.Count}");
            Console.WriteLine($"Total de sueldos a pagar:{totalSueldos}");
        }
    }
}
