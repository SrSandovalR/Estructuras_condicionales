using System;

internal class Ejercicio3
{
    private static void Main(string[] args)
    {
        try
        {


            Console.WriteLine("Si el producto tiene un valor de mas de 100 tendra un descuento del %10.");
            Console.WriteLine("Ingresa el precio original del producto: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());




            if (numero1 > 100)
            {
                Console.Clear();
                float resultado = (float)0.1 * numero1;
                Console.WriteLine($"El descuento es:{resultado} ");
                Console.Read();

            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Precio sin descuento:{numero1} ");
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

