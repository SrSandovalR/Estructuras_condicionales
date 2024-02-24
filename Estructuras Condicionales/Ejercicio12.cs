using System;

internal class Ejercicio12
{
    private static void Main(string[] args)
    {
        Console.Write("Introduce la calificación del examen: ");
        int calificacion = Convert.ToInt32(Console.ReadLine());

        switch (calificacion)
        {
            case int n when n >= 90 && n <= 100:
                Console.WriteLine("Sobresaliente");
                break;

            case int n when n >= 80 && n < 90:
                Console.WriteLine("Notable");
                break;

            case int n when n >= 70 && n < 80:
                Console.WriteLine("Decente");
                break;

            case int n when n >= 61 && n < 70:
                Console.WriteLine("Minimo");
                break;

            case int n when n <= 60:
                Console.WriteLine("Reprobado");
                break;
            default:
                Console.WriteLine("Calificación no válida.");
                break;
        }

        if (calificacion % 2 == 0)
        {


            Console.WriteLine("La calificacion es par.");


        }
        else
        {
            Console.WriteLine("La calificacion es impar.");

        }
    }
}