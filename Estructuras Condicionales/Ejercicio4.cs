using System;


internal class Ejercicio4
{
    private static void Main(string[] args)
    {
        try
        {
            string usuario = "usuario";
            string contrasena = "contrasena";

            Console.Write("Ingrese su usuario: ");
            string pedirusuario = Console.ReadLine();

            Console.Write("Ingrese su contrasena: ");
            string pedircontrasena = Console.ReadLine();



            if (pedirusuario == usuario && pedircontrasena == contrasena)
            {
                Console.Clear();
                Console.WriteLine("Acceso permitido.");
                Console.Read();

            }
            else
            {
                Console.Clear();
                Console.WriteLine("El usuario o contrasena son incorrectos.");
                Console.Read();
            }

        }
        catch (FormatException)
        {
            Console.Clear();
            Console.WriteLine("Ha ocurrido un error.");
            Console.Read();
            Console.ReadLine();
            throw;
        }
    }
}