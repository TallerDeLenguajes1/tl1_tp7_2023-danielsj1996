// See https://aka.ms/new-console-template for more information
namespace EspacioCalculadora;


public class Calculadora
{


    private double dato = 0;
    private double resultado;
    public double Dato { get => dato; set => dato = value; }
    public double Resultado { get => Dato; }


    public void Sumar(double termino)
    {
        Dato = Dato + termino;
       
    }
    public void Restar(double termino)
    {
        Dato = Dato - termino;

    }
    public void Multiplicar(double termino)
    {
        Dato = Dato * termino;

    }
    public void Dividir(double termino)
    {
        if (termino != 0)
        {

            Dato = Dato / termino;
        }
        else
        {
            Console.WriteLine("No se puede realizar la division ");
        }

    }
    public void Limpiar()
    {
        //Vuelve el valor a 0
        Dato = 0;
        Console.WriteLine("Resultado volvio a su valor original: " + Dato);
    }

    public void Mostrar()
    {
        Console.WriteLine("El Resultado es: " + Resultado);
    }


}




