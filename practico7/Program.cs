// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;
Console.WriteLine("Hello, World!");

double termino = 0;
bool funciona1 = false;
string? numString1 = "";
int opcion;

Calculadora Ndato = new Calculadora();

do
{
    Console.WriteLine("Elija una opcion de la calculadora:");
    Console.WriteLine("1)Sumar\n 2)Restar\n 3)Multiplicar\n 4)Dividir\n 5)Limpiar\n 6)Salir\n");
    opcion = Console.ReadKey().KeyChar;


    switch (opcion)
    {
        case '1':
            do
            {
                Console.WriteLine("\nIngrese los números en la calculadora: (Para salir al menú principal ingrese cualquier letra)");
                numString1 = Console.ReadLine();
                funciona1 = double.TryParse(numString1, out termino);
                if (!funciona1)
                {
                    Console.WriteLine(numString1 + " No es un numero valido");
                }
                else
                {
                    {
                        Ndato.Sumar(termino);
                        Console.WriteLine("El Resultado es: " + Ndato.Resultado);

                    }
                }

            } while (funciona1);
            break;
        case '2':
            do
            {
                Console.WriteLine("\nIngrese los números en la calculadora: (Para salir al menú principal ingrese cualquier letra)");
                numString1 = Console.ReadLine();
                funciona1 = double.TryParse(numString1, out termino);
                if (!funciona1)
                {
                    Console.WriteLine(numString1 + " No es un numero valido");
                }
                else
                {
                    {
                        Ndato.Restar(termino);
                        Console.WriteLine("El Resultado es: " + Ndato.Resultado);

                    }
                }

            } while (funciona1);
            break;
        case '3':
            do
            {
                Console.WriteLine("\nIngrese los números en la calculadora: (Para salir al menú principal ingrese cualquier letra)");
                numString1 = Console.ReadLine();
                funciona1 = double.TryParse(numString1, out termino);
                if (!funciona1)
                {
                    Console.WriteLine(numString1 + " No es un numero valido");
                }
                else
                {
                    {
                        Ndato.Multiplicar(termino);
                        Console.WriteLine("El Resultado es: " + Ndato.Resultado);

                    }
                }

            } while (funciona1);
            break;
        case '4':
            do
            {
                Console.WriteLine("\nIngrese los números en la calculadora: (Para salir al menú principal ingrese cualquier letra)");
                numString1 = Console.ReadLine();
                funciona1 = double.TryParse(numString1, out termino);
                if (!funciona1)
                {
                    Console.WriteLine(numString1 + " No es un numero valido");
                }
                else
                {
                    {
                        Ndato.Dividir(termino);
                        Console.WriteLine("El Resultado es: " + Ndato.Resultado);

                    }
                }

            } while (funciona1);
            break;
        case '5':
            Ndato.Limpiar();
            break;
        case '6':
            Console.WriteLine("Saliendo del programa");

            break;


        default:

            break;
    }
} while (opcion != 6);






