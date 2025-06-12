namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato;
        public void Sumar(double termino)
        {
            dato += termino;
        }
        public void Restar(double termino)
        {
            dato -= termino;
        }
        public void Multiplicar(double termino)
        {
            dato *= termino;
        }
        public void Dividir(double termino)
        {
            if (termino != 0)
            {
                dato /= termino;
            }
            else
            {
                Console.WriteLine("Error: No se puede dividir por cero.");
            }
        }
        public void Limpiar(double termino)
        {
            dato = 0;
        }
        private double resultado;
        public double Resultado { get => resultado; } 
    }
}