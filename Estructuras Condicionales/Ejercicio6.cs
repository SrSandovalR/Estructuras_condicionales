using System;


internal class Ejercicio6
{
    private static void Main(string[] args)
    {
        try
        {


            Console.Write("Ingrese su edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el monto del prestamo: ");
            int prestamo = Convert.ToInt32(Console.ReadLine());



            if (edad > 60 || prestamo < 5000)
            {
                Console.Clear();
                Console.WriteLine("Prestamo aprobado.");
                Console.Read();

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Prestamo denegado.");
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