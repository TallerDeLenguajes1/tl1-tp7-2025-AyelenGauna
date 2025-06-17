namespace EspacioEmpleado
{
     class Empleado
    {
        //Enumeración de cargos de un empleado en una empresa
        enum Cargos{Auxiliar, Administrativo, Ingeniero, Especialista, Investigador}
        
        //Datos personales de un empleado
        private string nombre, apellido;
        public string Nombre{
            get => nombre;
            set => nombre = value;
        }
        public string Apellido{
            get => apellido;
            set => apellido = value;
        }

        private DateTime fechaNacimiento = new DateTime();
        public DateTime FechaNacimiento{
            get => fechaNacimiento;
            set => fechaNacimiento = value;
        }
        
        private char estadoCivil;
        public char EstadoCivil{
            get => estadoCivil;
            set => estadoCivil = value;
        }
        
        private DateTime fechaIngreso = new DateTime();
        public DateTime FechaIngreso{
            get => fechaIngreso;
            set => fechaIngreso = value;
        }
        
        private double sueldoBasico;
        public double SueldoBasico{
            get => sueldoBasico;
            set => sueldoBasico = value;
        }

        private Cargos cargos;

    }
}