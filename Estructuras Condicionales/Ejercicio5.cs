using System;


internal class Ejercicio5
{
    private static void Main(string[] args)
    {
        try
        {


            Console.Write("Introduce un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());



            if (numero % 2 == 0)
            {
                Console.Clear();
                Console.WriteLine("El numero es par.");
                Console.Read();

            }
            else
            {
                Console.Clear();
                Console.WriteLine("El numero es impar.");
                Console.Read();
            }

        }
        catch (FormatException)
        {
            Console.Clear();
            Console.WriteLine("Ha ocurrido un error solo debe ingresar numeros.");
            Console.Read();
            Console.ReadLine();
            throw;
        }
    }
}