using EspacioEmpleado;

Empleado empleado = new Empleado();

double numero;
DateTime Hoy = DateTime.Now;

Console.WriteLine("Ingrese el sueldo básico del empleado: ");
string sueldoBasico = Console.ReadLine();

if (double.TryParse(sueldoBasico, out numero))
{
    empleado.SueldoBasico = numero;
    Console.WriteLine($"Sueldo básico del empleado: {empleado.SueldoBasico}\n");
    
}else
{
    Console.WriteLine("\nEl dato ingresado es inválido\n");
}

Console.WriteLine("Ingresa la fecha de ingreso del empleado (por ejemplo, 17/06/2025): ");

string fecha = Console.ReadLine();

DateTime fechaI = new DateTime();

if (DateTime.TryParse(fecha,out fechaI))
{
    empleado.FechaIngreso = fechaI;
    Console.WriteLine($"Fecha de ingreso del empleado: {empleado.FechaIngreso.ToString("dd/MM/yyyy")}\n");
}else
{
    Console.WriteLine("\nEl dato ingresado no es una fecha");
}

Console.WriteLine("Ingresa la fecha de nacimiento del empleado (por ejemplo, 17/06/2025): ");
fecha = Console.ReadLine();

if (DateTime.TryParse(fecha,out fechaI))
{
    empleado.FechaNacimiento = fechaI;
    Console.WriteLine($"Fecha de ingreso del empleado: {empleado.FechaNacimiento.ToString("dd/MM/yyyy")}\n");
}else
{
    Console.WriteLine("\nEl dato ingresado no es una fecha");
}

empleado.CalcularEdadyAntiguedad(Hoy);
Console.WriteLine($"Edad del empleado: {empleado.Edad}\n");

