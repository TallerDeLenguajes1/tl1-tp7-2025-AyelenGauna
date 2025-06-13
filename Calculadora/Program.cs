using EspacioCalculadora;

Calculadora calc = new Calculadora();

string opcion, continuar;
int numero;
Console.WriteLine("*** CALCULADORA SIMPLE ***");
Console.WriteLine("Esta es una calculadora donde encadena operaciones sobre un mismo resultado");

do
{
    do
    {
        Console.WriteLine("\nOpciones:\n1)Suma  2)Resta  3)Multiplicación  4)División");
        opcion = Console.ReadLine();

        if (int.TryParse(opcion, out numero) && (numero > 0 && 5 > numero))
        {
            int termino;

            Console.WriteLine("\nNúmero: ");
            termino = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    calc.Sumar(termino);
                    Console.WriteLine($"Resultado = {calc.Resultado}\n");
                    break;
                case 2:
                    calc.Restar(termino);
                    Console.WriteLine($"Resultado = {calc.Resultado}\n");
                    break;
                case 3:
                    calc.Multiplicar(termino);
                    Console.WriteLine($"Resultado = {calc.Resultado}\n");
                    break;
                case 4:
                    if (termino == 0)
                    {
                        Console.WriteLine("No se puede dividir sobre 0\n");
                    }
                    else
                    {
                        calc.Dividir(termino);
                        Console.WriteLine($"Resultado = {calc.Resultado}\n");
                    }
                    break;
            }

        }
        else
        {
            Console.WriteLine("\nEl dato ingresado no es un número o no es una opción válida");
        }

    } while (!(int.TryParse(opcion, out numero)) || (numero < 1 || 4 < numero));

    Console.WriteLine("¿Desea realizar otra operación?\nSI: 1\tNO: 0");
    continuar = Console.ReadLine();

    if (!int.TryParse(continuar, out numero) || (numero != 1 && numero != 0))
    {
        Console.WriteLine("El dato ingresado no es un número o no es una opción válida\n");
    }

    if (numero == 1)
    {
        string limpio;
        int num;

        do
        {
            Console.WriteLine("\nLimpiar el resultado acumulado (resultado = 0)\nSI: 1\tNO: 0");
            limpio = Console.ReadLine();

            if (int.TryParse(limpio, out num) && num == 1)
            {
                calc.Limpiar();
            }
            else
            {
                Console.WriteLine("\nEl dato ingresado no es un número o no es una opción válida");
            }


        } while (!int.TryParse(limpio, out num) || (num != 1 && num != 0));

    }
    
} while (!int.TryParse(continuar, out numero) || numero == 1);
