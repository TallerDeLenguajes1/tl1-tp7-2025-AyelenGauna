namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double resultado;
        public double Resultado { get => resultado; } 
        private double dato;
        public void Sumar(double termino)
        {
            dato += termino;
            resultado = dato;
        }
        public void Restar(double termino)
        {
            dato -= termino;
            resultado = dato;
        }
        public void Multiplicar(double termino)
        {
            dato *= termino;
            resultado = dato;
        }
        public void Dividir(double termino)
        {
            if (termino != 0)
            {
                dato /= termino;
                resultado = dato;
            }
            else
            {
                Console.WriteLine("Error: No se puede dividir por cero.");
            }
        }
        public void Limpiar()
        {
            dato = 0;
            resultado = 0;
        }
        
    }
}