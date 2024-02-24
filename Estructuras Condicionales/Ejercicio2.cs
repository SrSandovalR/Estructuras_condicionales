using System;

internal class Ejercicio2
{
    private static void Main(string[] args)
    {
        try
        {


            Console.WriteLine("Podras entrar al club solo si eres mayor de edad.");
            Console.WriteLine("Ingresa tu edad: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());




            if (numero1 >= 18)
            {
                Console.Clear();
                Console.WriteLine("Eres Mayor de edad.");
                Console.WriteLine("PUEDES PASAR...");
                Console.Read();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Eres menor de edad.");
                Console.WriteLine("NO PUEDES PASAR...");
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